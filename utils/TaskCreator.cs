using System;
using System.Collections.Generic;
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
        public static LinkedList<Panel> getTasks(LinkedList<Dictionary<Object, Object>> data)
        {
            LinkedList<Panel> taskList = new LinkedList<Panel>();
            int len = data.Count;
            foreach(Dictionary<Object, Object> ob in data)
            {
                TaskBox task = new TaskBox();

                

                //数据
                task.id = (int)ob["Id"];
                task.TeskTitle = Convert.ToString(ob["title"]);
                task.deadline = Convert.ToUInt64(ob["deadline"]);
                task.add_time = Convert.ToUInt64(ob["add_time"]);
                task.Describe = Convert.ToString(ob["detail"]);
                task.listing_id = Convert.ToInt32(ob["listing_id"]);
                task.is_assign = Convert.ToInt32(ob["is_assign"]);
                task.isImportantTask = Convert.ToBoolean(ob["is_important"]);



                taskList.AddLast(TaskCreator.getTaskPanel(task));
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
            task.TabIndex = 0;

        }


        /**
         * 将taskBox添加到 panel中
         */
        private static Panel getTaskPanel(TaskBox task)
        {
            
            Panel panel = new Panel();
            panel.Controls.Add(task);

            panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            
            panel.Dock = System.Windows.Forms.DockStyle.Top;
            //panel.Location = new System.Drawing.Point(0, 0);
            panel.Name = getTaskPanelName();
            panel.Size = new System.Drawing.Size(689, 60);

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
