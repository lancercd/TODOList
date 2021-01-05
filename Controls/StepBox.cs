using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOList.Controls
{
    public partial class StepBox : UserControl
    {
        
        public int id;
        public int task_id;
        public int sort;
        private string detail;
        private bool is_corrent;
        private bool is_accomplish;

        

        public string title
        {
            get { return detail; }
            set { detail = value; afTextBox1.Text = value; }
        }

        public bool isFinish
        {
            get { return is_accomplish; }
            set 
            {
                is_accomplish = value;
                //图标切换
                if (value) stepLeftIcon.Image = Properties.Resources.finished;
                else stepLeftIcon.Image = Properties.Resources.unfinished;
            }
        }

        public bool isCorrent
        {
            get { return is_corrent; }
            set { is_corrent = value; }
        }
        public StepBox()
        {
            InitializeComponent();
            stepRightIcon.Visible = false;
        }




        private void onMouseHoverStepBox(object sender, EventArgs e)
        {
            stepRightIcon.Visible = true;
        }

        private void onMouseLeaveStepBox(object sender, EventArgs e)
        {
            stepRightIcon.Visible = false;
        }



        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public event EventHandler StepLeftIconClick;


        private void onStepLeftIconClick(object sender, EventArgs e)
        {
            isFinish = !isFinish;
            StepLeftIconClick?.Invoke(this, e);
        }

        private void onMouseHoverStepBox(object sender, MouseEventArgs e)
        {
            stepRightIcon.Visible = true;
        }
    }
}
