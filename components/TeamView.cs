﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
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
    public partial class TeamView : Form
    {


        //当前用户
        public int uid = 1;

        //是否为 [重要page]
        public bool is_important_page = false;

        public bool isListingPage = false;

        public int listingId = 0;

        //为0 则为list清单
        public int p_index = 0;

        public TaskBox RightSizeObj = null;

        public TeamView()
        {
            if(Form1.MainFrame != null)
            {
                uid = Form1.uid;
                Form1.MainFrame.show_listing();
            }


            InitializeComponent();
            
            init();
        }

        public TeamView(string title, bool isListingPage, bool isImportantPage, int listingId, int p_index)
        {
            if (Form1.MainFrame != null)
            {
                uid = Form1.uid;
                Form1.MainFrame.show_listing();
            }
            InitializeComponent();
            childFormTitle.Text = title;
            this.p_index = p_index;
            this.listingId = listingId;
            this.isListingPage = isListingPage;
            this.is_important_page = isImportantPage;

            init();
        }
        


        private void init()
        {
            if (Form1.MainFrame != null) uid = Form1.uid;

            AddToOtherBtn.Text = is_important_page ? "添加到\"我的一天\"" : "添加到\"重要\"";

            AddAlertBtn.Text = "提醒我";
            AddAlertBtn.Image = Properties.Resources.time;
            AddDeadLineBtn.Text = "添加截止日期";
            AddDeadLineBtn.Image = Properties.Resources.course_table;
            RightSidePanel.Size = new Size(0, RightSidePanel.Size.Height);

            DetilTextBox.edit.PlaceHolderStr = "添加备注!";


            AddDeadLineBtn.afTextBox1.edit.PlaceHolderStr = "添加截止日期";
            AddAlertBtn.afTextBox1.edit.PlaceHolderStr = "提醒我";

            AddDeadLineBtn.is_other_btn = true;
            AddAlertBtn.is_other_btn = true;



            //初始化任务列表
            teamListInit();
        }


        /**
         * 打开右侧窗口
         */
        private void active_right_side_Penal(TaskBox task)
        {
            RightSizeObj = task;
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

            AddToOtherBtn.id = id;
            AddToOtherBtn.isFinish = task.isImportantTask;
            AddDeadLineBtn.id = id;
            AddAlertBtn.id = id;
            DetilTextBox.id = id;




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
                                    box.id + ", N'" +
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


        private void teamListInit()
        {
            JoinedPanel.Controls.Clear();
            //查询数据库
            LinkedList<Dictionary<Object, Object>> joinedData = DB.getLinkedList("SELECT " +
                "tb_group.id id, tb_group.name name, tb_group.add_time add_time, tb_user_group.id ugid, tb_user_group.is_leader is_leader FROM tb_group " +
                "INNER JOIN tb_user_group " +
                "ON tb_group.id = tb_user_group.group_id " +
                "WHERE uid = " + uid);

            foreach(Dictionary<Object, Object> group in joinedData)
            {
                ShowGroupBox groupBox = new ShowGroupBox();
                groupBox.teamName = Convert.ToString(group["name"]);
                groupBox.id = Convert.ToInt32(group["id"]);
                groupBox.addTime = Convert.ToUInt64(group["add_time"]);
                groupBox.ugid = Convert.ToInt32(group["ugid"]);
                groupBox.numCount = getTeamNumCount(groupBox.id);
                groupBox.isLeader = Convert.ToBoolean(group["is_leader"]);

                teamBoxStyleInit(groupBox);
                addToJoinedPanel(groupBox);

            }



        }

        //初始化groupBox样式
        private void teamBoxStyleInit(ShowGroupBox groupBox)
        {
            groupBox.ShowGroupBoxClick += new EventHandler(onShowGroupBoxClick);
            groupBox.Size = new System.Drawing.Size(172, 58);
            groupBox.Cursor = Cursors.Hand;
        }

        private void addToJoinedPanel(ShowGroupBox groupBox)
        {
            JoinedPanel.Controls.Add(groupBox);
        }


        private int getTeamNumCount(int groupId)
        {
            return Convert.ToInt32(DB.getOne("SELECT COUNT(*) FROM tb_user_group WHERE group_id = " + groupId));
        }

        private void onShowGroupBoxClick(object sender, EventArgs e)
        {
            ShowGroupBox groupBox = sender as ShowGroupBox;
            int id = groupBox.id;
            MessageBox.Show(Convert.ToString(groupBox.isLeader));
        }


        /**
         * 为taskBox添加点击事件
         */
        private void addTaskBoxEvent(TaskBox task)
        {
            task.ClickTaskBoxEvent += new System.EventHandler(this.onTaskBoxClick);

            task.addToImportant += new EventHandler(onAddToImportant);
        }

        private void onAddToImportant(object sender, EventArgs e)
        {
            TaskBox btn = sender as TaskBox;
            int id = btn.id;
            bool is_important = btn.isImportantTask;
            int num = DB.getEffNum(string.Format("UPDATE tb_task SET is_important = {0} WHERE Id = {1}", Convert.ToInt32(btn.isImportantTask), id));
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

            int id;

            //获取id  上传数据库
            if (listingId != 0)
            {
                id = DB.insert("INSERT INTO tb_task (uid, title, p_index, add_time, is_important, listing_id ) VALUES ( " +
                                    uid + ", N'" +
                                    title + "', " +
                                    0 + ", " +
                                    now + ", '" +
                                    Convert.ToInt32(is_important_page) + "' , '" +
                                    listingId + "' )");
            }
            else
            {
                id = DB.insert("INSERT INTO tb_task (uid, p_index, title, add_time, is_important ) VALUES ( " +
                                    uid + ", " +
                                    p_index + ", N'" +
                                    title + "', " +
                                    now + ", '" +
                                    Convert.ToInt32(is_important_page) +
                                    "' )");
            }


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
            StepBox box = sender as StepBox;
            string value = box.afTextBox1.Text;
            long time = TimeUtil.getSeconds(value);
            //2010 - 01 - 05 15:14:20

            int num = DB.getEffNum(string.Format("UPDATE tb_task SET deadline = {0} WHERE Id = {1}", time, box.id));


            //string describu = afTextBox.Text;

            //int num = DB.getEffNum(string.Format("UPDATE tb_task SET detail = '{0}' WHERE Id = {1}", describu, id));
            //MessageBox.Show(describu);

            //RightSizeObj.Describe = describu;


        }

        private void onAddAlertBtn(object sender, EventArgs e)
        {
            StepBox box = sender as StepBox;
            string value = box.afTextBox1.Text;
            long time = TimeUtil.getSeconds(value);
            //2010 - 01 - 05 15:14:20

            int num = DB.getEffNum(string.Format("UPDATE tb_task SET alert_time = {0} WHERE Id = {1}", time, box.id));
        }


        private void onAddToOtherBtn(object sender, EventArgs e)
        {
            IconBtn btn = sender as IconBtn;
            btn.isFinish = !btn.isFinish;
            if (btn.isFinish)
            {
                btn.Text = "取消添加";
            }
            else
            {
                btn.Text = is_important_page ? "添加到\"我的一天\"" : "添加到\"重要\""; ;
            }

            int id = RightSizeObj.id;
            int num = DB.getEffNum(string.Format("UPDATE tb_task SET is_important = {0} WHERE Id = {1}", Convert.ToInt32(btn.isFinish), id));
            RightSizeObj.isImportantTask = btn.isFinish;
        }

        private void onDetilTextBox(object sender, EventArgs e)
        {
            AfTextBox afTextBox = sender as AfTextBox;
            int id = afTextBox.id;
            string describu = afTextBox.Text;

            int num = DB.getEffNum(string.Format("UPDATE tb_task SET detail = N'{0}' WHERE Id = {1}", describu, id));
            //MessageBox.Show(describu);

            RightSizeObj.Describe = describu;
        }
    }
}