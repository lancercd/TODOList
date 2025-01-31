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
    public partial class AssignTask : Form
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

        public AssignTask()
        {
            if(Form1.MainFrame != null)
            {
                uid = Form1.uid;
                Form1.MainFrame.show_listing();
            }


            
            InitializeComponent();
            
            init();
        }

        public AssignTask(string title, bool isListingPage, bool isImportantPage, int listingId, int p_index)
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




            assignConformBtn.selectedText = "提交";
            assignConformBtn.afLabelBox1.ForeColor = Color.White;
            assignConformBtn.afLabelBox1.edit.Font = new System.Drawing.Font("黑体", 16F);
            assignConformBtn.isSelect = false;



            //NotifyIcon fyIcon = new NotifyIcon();
            //fyIcon.Icon = new Icon("finished.ico");/*找一个ico图标将其拷贝到 debug 目录下*/
            //fyIcon.BalloonTipText = "Hello World！";/*必填提示内容*/
            //fyIcon.BalloonTipTitle = "通知";
            //fyIcon.Visible = true;/*必须设置显隐，因为默认值是 false 不显示通知*/
            // fyIcon.ShowBalloonTip(0);




            //初始化任务列表
            taskInit();
            AssignTaskInit();
        }


        /**
         * 打开右侧窗口
         */
        private void active_right_side_Penal(TaskBox task)
        {
            RightSizeObj = task;

            //是否显示下拉框
            showAssignListBox(task.need_to_assign);
            //渲染数据
            rightSizePanelDataRender(task);


            if (RightSidePanel.Size.Width == 0) { 
                RightSidePanel.Size = new Size(266, RightSidePanel.Size.Height);
            }
            
            //RightSidePanel.Size.Width = 0
        }


        private void showAssignListBox(bool need_open)
        {
            //如果不需要打开
            if (!need_open) {  assignPanel.Visible = false; return;}

            //需要显示
            assignPanel.Visible = true;


            List<KeyValuePair<int, string>> groups = getGroupInfoToComBox();

            
            assignGroupBox.DataSource = groups;
            assignGroupBox.ValueMember = "key";
            assignGroupBox.DisplayMember = "value";
            //assignGroupBox.Parent = this;//加入这一句



            //设置默认选择
            assignGroupBox.SelectedValue = RightSizeObj.gid;



            //TODO selectedChange   to do something


            //assignGroupBox

        }


        /**
         * 选择组改变
         */
        private void onGroupSelectChange(object sender, EventArgs e)
        {
            if (assignGroupBox.SelectedItem == null) return;
            KeyValuePair<int, string> value = (KeyValuePair<int, string>)assignGroupBox.SelectedItem;
            int id = value.Key;


            //添加到 选择组员 combox
            assignUserBox.DataSource = getGroupUserToComBox(id);
            assignUserBox.ValueMember = "key";
            assignUserBox.DisplayMember = "value";
            assignUserBox.SelectedValue = RightSizeObj.to_uid;

            //MessageBox.Show(Convert.ToString(value.Key));
        }

        
        /**
         * 分配确定按钮 点击事件
         */
        private void onAssignSelectBtnClick(object sender, EventArgs e)
        {
            KeyValuePair<int, string> gInfo = (KeyValuePair<int, string>)assignGroupBox.SelectedItem;
            int gid = gInfo.Key;
            if(gid == 0)
            {
                MessageBox.Show("请先选择分配的组");
                return;
            }

            KeyValuePair<int, string> uInfo = (KeyValuePair<int, string>)assignUserBox.SelectedItem;
            int to_uid = uInfo.Key;
            if(to_uid == 0)
            {
                MessageBox.Show("请选择需要分配的用户");
                return;
            }

            //上传数据库
            bool res = assignTask(gid, to_uid, RightSizeObj.id, RightSizeObj.is_assign);
            if (!res)
            {
                MessageBox.Show("修改失败");
                return;
            }
           
            RightSizeObj.to_uid = to_uid;
            RightSizeObj.gid = gid;
            showAssignListBox(true);
            AssignTaskInit();
            MessageBox.Show("修改成功");

        }



        private bool assignTask(int gid, int to_uid, int task_id, int assign_id)
        {
            string assignTasksql = string.Format("UPDATE tb_assign_task SET gid = {0}, to_uid = {1} WHERE Id = {2}", gid, to_uid, assign_id);
            string taskSql = string.Format("UPDATE tb_task SET uid = {0} WHERE Id = {1}", to_uid, task_id);
            int assignRes = DB.getEffNum(assignTasksql);
            if(assignRes != 0)
            {
                int taskRes = DB.getEffNum(taskSql);
                if (taskRes != 0) return true;
            }
            return false;
        }


        private List<KeyValuePair<int, string>> getGroupInfoToComBox()
        {
            LinkedList<Dictionary<Object, Object>> data = DB.getLinkedList(string.Format("SELECT " +
                " g.id, g.name FROM tb_user_group u JOIN tb_group g ON u.group_id = g.id " +
                "WHERE uid = {0}", uid));
            return D_to_L(data, "id", "name");
        }


        /**
         * 该组用户信息  并格式化数据
         */
        private List<KeyValuePair<int, string>> getGroupUserToComBox(int id)
        {
            LinkedList<Dictionary<Object, Object>> data = DB.getLinkedList(string.Format("SELECT " +
                " u.uid id, u.username name FROM tb_user_group g JOIN tb_user u ON u.uid = g.uid " +
                "WHERE group_id = {0}", id));
            return D_to_L(data, "id", "name");
        }


        private List<KeyValuePair<int, string>> D_to_L(LinkedList<Dictionary<Object, Object>> data, string k1, string k2)
        {
            List<KeyValuePair<int, string>> formData = new List<KeyValuePair<int, string>>();
            foreach (Dictionary<Object, Object> d in data)
            {
                formData.Add(new KeyValuePair<int, string>(Convert.ToInt32(d[k1]), Convert.ToString(d[k2])));
            }

            return formData;
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



            AddDeadLineBtn.afTextBox1.Text = task.deadline;
            AddAlertBtn.afTextBox1.Text = task.alert_time;
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


        /**
         * 显示分配给我的任务
         */
        private void taskInit()
        {

            string sql;
            sql = "Select a.leader_uid, a.gid, a.to_uid, t.* from tb_assign_task a JOIN tb_task t ON a.Id = t.is_assign  where to_uid = " + uid;
            //查询数据库
            LinkedList<Dictionary<Object, Object>> data = DB.getLinkedList(sql);

            //LinkedList<Panel> taskPanels = TaskCreator.getTasks(data);
            LinkedList<TaskBox> taskBoxs = TaskCreator.getAssignTasks(data);

            //遍历task
            foreach (TaskBox task in taskBoxs)
            {
                //添加点击事件addToImportant
                addTaskBoxEvent(task);

                //添加panel 初始化样式  渲染入页面
                putTask(TaskCreator.getTaskPanel(task));
            }
        }


        private void AssignTaskInit()
        {
            assignListPanel.Controls.Clear();
            string sql;
            sql = "Select a.leader_uid, a.gid, a.to_uid, t.* from tb_assign_task a JOIN tb_task t ON a.Id = t.is_assign  WHERE leader_uid = " + uid;
            //查询数据库
            LinkedList<Dictionary<Object, Object>> data = DB.getLinkedList(sql);

            //LinkedList<Panel> taskPanels = TaskCreator.getTasks(data);
            LinkedList<TaskBox> taskBoxs = TaskCreator.getAssignTasks(data);

            //遍历task
            foreach (TaskBox task in taskBoxs)
            {
                //添加点击事件addToImportant
                addTaskBoxEvent(task);
                task.need_to_assign = true;
                task.is_assign_task = true;
                //添加panel 初始化样式  渲染入页面
                putAssignTask(TaskCreator.getTaskPanel(task));
            }
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

        private void putAssignTask(Panel taskPan)
        {
            this.assignListPanel.Controls.Add(taskPan);
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

            int assignId;

            //获取id  上传数据库

            assignId = DB.insert("INSERT INTO tb_assign_task (leader_uid, to_uid, gid ) VALUES ( " +
                                uid + ", " +
                                0 + ", " +
                                0 + " )");
            int taskid = DB.insert("INSERT INTO tb_task (uid, p_index, title, add_time, is_assign, is_important ) VALUES ( " +
                                    0 + ", " +
                                    p_index + ", N'" +
                                    title + "', " +
                                    now + ", " +
                                    assignId + ", '" +
                                    Convert.ToInt32(is_important_page) +
                                    "' )");



            TaskBox taskbox = new TaskBox();
            taskbox.is_assign = assignId;  //tb_assign_task  id
            taskbox.id = taskid;     //tb_task         id
            taskbox.is_assign_task = true;
            taskbox.need_to_assign = true;
            taskbox.uid = 0;        //才创建  还没分配人
            taskbox.to_uid = 0;     //才创建  还没分配人
            taskbox.gid = 0;        //才创建  还没分配组
            taskbox.TeskTitle = title;
            taskbox.add_time = Convert.ToUInt64(now);
            taskbox.isImportantTask = false;

            //添加点击事件
            addTaskBoxEvent(taskbox);
            //渲染进页面
            putAssignTask(TaskCreator.getTaskPanel(taskbox));
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
