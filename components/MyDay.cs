﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TODOList.components;
using TODOList.Controls;
using TODOList.utils;

namespace TODOList
{
    public partial class MyDay : Form
    {

        //当前用户
        public int uid = 1;

        //是否为 [重要page]
        public bool is_important_page = false;

        public MyDay()
        {
            InitializeComponent();
            AddToOtherBtn.Text = is_important_page ? "添加到\"我的一天\"" : "添加到\"重要\"";

            AddAlertBtn.Text = "提醒我";
            AddAlertBtn.Image = Properties.Resources.time;
            AddDeadLineBtn.Text = "添加截止日期";
            AddDeadLineBtn.Image = Properties.Resources.course_table;
            RightSidePanel.Size = new Size(0, RightSidePanel.Size.Height);



            //初始化任务列表
            taskInit();
        }


        /**
         * 打开右侧窗口
         */
        private void active_right_side_Penal(TaskBox task)
        {

            rightSizePanelDataRender(task);


            if (RightSidePanel.Size.Width == 0) { 
                RightSidePanel.Size = new Size(266, RightSidePanel.Size.Height);
            }
            
            //RightSidePanel.Size.Width = 0
        }


        /**
         * 右侧边栏数据填充 及 初始化
         */
        private void rightSizePanelDataRender(TaskBox task)
        {
            int id = task.id;
            string title = task.TeskTitle;
            LinkedList<Dictionary<Object, Object>> steps = getTaskStep(id);
            

            StepPanel.Controls.Clear();

            //添加步骤按钮
            addStep(id, task.Describe);

            RightSideTitleLabel.Text = title;
            //遍历task
            foreach (Dictionary<Object, Object> step in steps)
            {
                StepBox stepBox = new StepBox();

                //填充数据
                stepBox.id = Convert.ToInt32(step["Id"]);
                stepBox.task_id = Convert.ToInt32(step["task_id"]);
                stepBox.title = Convert.ToString(step["detail"]);
                stepBox.sort = Convert.ToInt32(step["sort"]);
                stepBox.isCorrent = Convert.ToBoolean(step["is_corrent"]);
                stepBox.isFinish = Convert.ToBoolean(step["is_accomplish"]);

                stepStyle(stepBox);


                //添加进页面
                StepPanel.Controls.Add(stepBox);
            }


            
            

        }

        //添加步骤按钮
        private void addStep(int id, string describe)
        {
            //添加步骤按钮
            addStepBox = new StepBox();
            addStepBox.stepRightIcon.Visible = false;
            addStepBox.stepLeftIcon.Image = Properties.Resources.add_red_icon;
            addStepBox.afTextBox1.edit.ForeColor = Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            addStepBox.title = "添加步骤";
            addStepBox.EnterPressEvent += new EventHandler(onEnterPressEvent);
            //taskId
            addStepBox.id = id;
            stepStyle(addStepBox);
            StepPanel.Controls.Add(addStepBox);

            DetilTextBox.Text = describe;
        }


        /**
         * 添加步骤
         */
        private void onEnterPressEvent(object sender, EventArgs e)
        {
            StepBox box = sender as StepBox;
            string stepTile = addStepBox.afTextBox1.Text;
            if (stepTile == "") return;
            int sort = 50;
            int id = DB.insert("INSERT INTO tb_step (task_id, detail, sort ) VALUES ( " +
                                    box.id + ", '" +
                                    stepTile + "', " +
                                    sort + " )");


            StepPanel.Controls.Clear();
            //添加步骤按钮
            addStep(box.id, "");
            LinkedList<Dictionary<Object, Object>> steps = getTaskStep(box.id);
            

            //遍历task
            foreach (Dictionary<Object, Object> step in steps)
            {
                StepBox stepBox = new StepBox();

                //填充数据
                stepBox.id = Convert.ToInt32(step["Id"]);
                stepBox.task_id = Convert.ToInt32(step["task_id"]);
                stepBox.title = Convert.ToString(step["detail"]);
                stepBox.sort = Convert.ToInt32(step["sort"]);
                stepBox.isCorrent = Convert.ToBoolean(step["is_corrent"]);
                stepBox.isFinish = Convert.ToBoolean(step["is_accomplish"]);
                stepStyle(stepBox);

                //添加进页面
                StepPanel.Controls.Add(stepBox);
            }

            

            //填充数据
            //stepBox.id = id;
            //stepBox.task_id = box.id;
            //stepBox.title = stepTile;
            //stepBox.sort = sort;
            //stepBox.isCorrent = false;
            //stepBox.isFinish = false;

            //box.afTextBox1.Text = "添加步骤";

            //stepStyle(stepBox);
            ////添加进页面
            //StepPanel.Controls.Add(stepBox);
        }


        /**
         * 设置任务步骤控件样式
         */
        private void stepStyle(StepBox stepBox)
        {
            //设置样式 
            stepBox.Dock = System.Windows.Forms.DockStyle.Top;
            stepBox.Location = new System.Drawing.Point(0, 0);
            stepBox.Size = new System.Drawing.Size(266, 30);


            stepBox.StepLeftIconClick += new EventHandler(onStepBoxLeftIconClick);
        }


        private void onStepBoxLeftIconClick(object sender, EventArgs e)
        {
            StepBox stepBox = sender as StepBox;
            int id = stepBox.id;
            MessageBox.Show("id = " + id + "   isFinish" + stepBox.isFinish);
            int num = DB.getEffNum(string.Format("UPDATE tb_step SET is_accomplish = {0} WHERE Id = {1}", Convert.ToInt32(stepBox.isFinish), id));
        }



        private LinkedList<Dictionary<Object, Object>> getTaskStep(int id)
        {
            LinkedList<Dictionary<Object, Object>> data = DB.getLinkedList("SELECT * FROM tb_step WHERE task_id = " + id + " ORDER BY sort DESC");

            //这里处理数据

            return data;
        }



        /**
         * 打开右侧面板显示详细信息
         */
        private void active_right_side_Penal(object sender, EventArgs e)
        {
            if (RightSidePanel.Size.Width != 0)
            {
                RightSidePanel.Size = new Size(0, RightSidePanel.Size.Height);
            }
            else
            {
                RightSidePanel.Size = new Size(266, RightSidePanel.Size.Height);
            }
            //RightSidePanel.Size.Width = 0
        }


        private void taskInit()
        {
            //查询数据库
            LinkedList<Dictionary<Object, Object>> data = DB.getLinkedList("Select * from tb_task where uid = " + 
                                                                            uid + " and listing_id = 0 and is_important = " + 
                                                                            Convert.ToInt32(is_important_page));

            //LinkedList<Panel> taskPanels = TaskCreator.getTasks(data);
            LinkedList<TaskBox> taskBoxs = TaskCreator.getTasks(data);

            //遍历task
            foreach (TaskBox task in taskBoxs)
            {
                //添加点击事件
                addTaskBoxEvent(task);

                //添加panel 初始化样式  渲染入页面
                putTask(TaskCreator.getTaskPanel(task));
            }
        }


        /**
         * 为taskBox添加点击事件
         */
        private void addTaskBoxEvent(TaskBox task)
        {
            task.ClickTaskBoxEvent += new System.EventHandler(this.onTaskBoxClick);
        }



        /**
         * 渲染入页面
         */
        private void putTask(Panel taskPan)
        {
            this.taskListPanel.Controls.Add(taskPan);
        }


        /**
         * 按回车 添加任务 事件
         */
        private void onEnterSubmit(object sender, EventArgs e)
        {
            string title = addTaskBox1.Text;
            if ("" == title) return;

            //用户输入标题后  创建任务   渲染任务列表
            createTaskByUser(title);
        }


        /**
         * 用户输入后创建任务  数据库添加  渲染列表
         */
        private void createTaskByUser(string title)
        {
            string now = TimeUtil.GetNow();
            
            //获取id  上传数据库
            int id = DB.insert("INSERT INTO tb_task (uid, title, add_time, is_important ) VALUES ( "+ 
                                    uid +", '" + 
                                    title + "', " +
                                    now + ", '" +
                                    Convert.ToInt32(is_important_page) +
                                    "' )");

            TaskBox taskbox = new TaskBox();
            taskbox.id = id;
            taskbox.uid = uid;
            taskbox.TeskTitle = title;
            taskbox.add_time = Convert.ToUInt64(now);
            taskbox.isImportantTask = is_important_page;

            //添加点击事件
            addTaskBoxEvent(taskbox);
            //渲染进页面
            putTask(TaskCreator.getTaskPanel(taskbox));
        }



        /**
         * taskBox点击时事件
         */
        public void onTaskBoxClick(object sender, EventArgs e)
        {
            TaskBox task = sender as TaskBox;
            active_right_side_Penal(task);
        }



        private void onAddDeadLineBtn(object sender, EventArgs e)
        {
            MessageBox.Show("deadline");
        }

        private void onAddAlertBtn(object sender, EventArgs e)
        {
            MessageBox.Show("alert");
        }

        private void onAddToOtherBtn(object sender, EventArgs e)
        {
            MessageBox.Show("addBtn click 添加到");
        }
    }
}
