using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TODOList.components;

namespace TODOList.utils
{
    class TaskCreator
    {
        private static int taskPanelCount = 0;
        public static LinkedList<TaskBox> getTasks(LinkedList<Dictionary<Object, Object>> data)
        {
            LinkedList<TaskBox> taskList = new LinkedList<TaskBox>();
            //LinkedList<Panel> taskList = new LinkedList<Panel>();

            foreach (Dictionary<Object, Object> ob in data)
            {
                TaskBox task = new TaskBox();

                

                //数据
                task.id = Convert.ToInt32(ob["Id"]);
                task.uid = Convert.ToInt32(ob["uid"]);
                task.TeskTitle = Convert.ToString(ob["title"]);
                task.deadline = Convert.ToString(ob["deadline"]);
                task.alert_time = Convert.ToString(ob["alert_time"]);
                task.add_time = Convert.ToUInt64(ob["add_time"]);
                task.Describe = Convert.ToString(ob["detail"]);
                task.listing_id = Convert.ToInt32(ob["listing_id"]);
                task.is_assign = Convert.ToInt32(ob["is_assign"]);
                task.isImportantTask = Convert.ToBoolean(ob["is_important"]);


                
                taskList.AddLast(task);
                //taskList.AddLast(TaskCreator.getTaskPanel(task));
            }
            return taskList;
        }

        public static LinkedList<TaskBox> getAssignTasks(LinkedList<Dictionary<Object, Object>> data)
        {
            LinkedList<TaskBox> taskList = new LinkedList<TaskBox>();

            foreach (Dictionary<Object, Object> ob in data)
            {
                TaskBox task = new TaskBox();
                //数据
                task.id = Convert.ToInt32(ob["Id"]);
                task.leader_id = Convert.ToInt32(ob["leader_uid"]);
                task.gid = Convert.ToInt32(ob["gid"]);
                task.to_uid = Convert.ToInt32(ob["to_uid"]);
                task.uid = Convert.ToInt32(ob["uid"]);
                task.TeskTitle = Convert.ToString(ob["title"]);
                task.deadline = Convert.ToString(ob["deadline"]);
                task.add_time = Convert.ToUInt64(ob["add_time"]);
                task.Describe = Convert.ToString(ob["detail"]);
                task.listing_id = Convert.ToInt32(ob["listing_id"]);
                task.is_assign = Convert.ToInt32(ob["is_assign"]);
                task.isImportantTask = Convert.ToBoolean(ob["is_important"]);

                task.is_assign_task = true;


                taskList.AddLast(task);
                //taskList.AddLast(TaskCreator.getTaskPanel(task));
            }
            return taskList;
        }

        /**
         * 初始化taskBox样式
         */
        private static void taskInitStyle(TaskBox task)
        {
            //样式
            task.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            task.BackColor = System.Drawing.SystemColors.ControlLightLight;
            task.Cursor = System.Windows.Forms.Cursors.Hand;
            task.Location = new System.Drawing.Point(30, 5);
            task.Size = new System.Drawing.Size(629, 52);


            ulong now = Convert.ToUInt64(TimeUtil.GetNow());
            if (task.deadLine != 0 && task.alertTime != 0)
            {
                if (task.alertTime < now && now <= task.deadLine)
                {
                    task.BackColor = Utils.getColorFromRGB(243, 156, 18);
                }
            }
            if (task.deadLine != 0 && now > task.deadLine)
            {

                task.BackColor = Utils.getColorFromRGB(231, 76, 60);
            }


            //task.TabIndex = 0;

        }


        /**
         * 将taskBox添加到 panel中
         */
        public static Panel getTaskPanel(TaskBox task)
        {
            
            Panel panel = new Panel();
            panel.Controls.Add(task);

            panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel.Dock = System.Windows.Forms.DockStyle.Top;
            panel.Name = getTaskPanelName();
            panel.Size = new System.Drawing.Size(689, 60);
            panel.BackColor = Color.Transparent;
            taskInitStyle(task);
            return panel;
        }




        /**
         * 获取生成panel名字 确保不重复
         */
        private static string getTaskPanelName()
        {
            ++taskPanelCount;
            return "taskPanel" + Convert.ToString(taskPanelCount);
        }
    }
}
