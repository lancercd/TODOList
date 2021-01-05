using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TODOList.utils;

namespace TODOList
{
    public partial class MyDay : Form
    {
        public int uid = 1;
        public MyDay()
        {
            InitializeComponent();

            taskInit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            active_right_side_Penal();
            
        }


        /**
         * 打开右侧窗口
         */
        private void active_right_side_Penal()
        {
            if (RightSidePanel.Size.Width != 0) { 
                RightSidePanel.Size = new Size(0, RightSidePanel.Size.Height);
            }
            else
            {
                RightSidePanel.Size = new Size(266, RightSidePanel.Size.Height);
            }
            //RightSidePanel.Size.Width = 0
        }

        private void showTaskList()
        {
            taskListPanel.Controls.Add(new Button());
        }

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
            LinkedList<Dictionary<Object, Object>> data = DB.getLinkedList("Select * from tb_task where uid = " + uid + " and listing_id = 0");
            //childFormTitle.Text = data.ToString();
            Console.Write(data);

            LinkedList<Panel> taskPanels = TaskCreator.getTasks(data);
            foreach(Panel pan in taskPanels)
            {
                this.taskListPanel.Controls.Add(pan);
            }
        }
    }
}
