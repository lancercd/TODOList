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

        public bool is_other_btn = false;

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

                if (!is_other_btn)
                {
                    if (value) stepLeftIcon.Image = Properties.Resources.finished;
                    else stepLeftIcon.Image = Properties.Resources.unfinished;
                }
                //图标切换
                
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


        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image Image {
            get { return stepLeftIcon.Image; }
            set { stepLeftIcon.Image = value; }

        
        }



        private void onMouseHoverStepBox(object sender, EventArgs e)
        {
            if (!is_other_btn)
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
            if (!is_other_btn) isFinish = !isFinish;
            StepLeftIconClick?.Invoke(this, e);
        }

        private void onMouseHoverStepBox(object sender, MouseEventArgs e)
        {
            if (!is_other_btn)
                stepRightIcon.Visible = true;
        }


        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public event EventHandler EnterPressEvent;

        private void onEnterPressEvent(object sender, EventArgs e)
        {
            EnterPressEvent?.Invoke(this, e);
        }
    }
}
