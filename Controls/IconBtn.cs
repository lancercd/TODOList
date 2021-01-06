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
    public partial class IconBtn : UserControl
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
            set { detail = value; afLabelBox1.Text = value; }
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


        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image Image
        {
            get { return stepLeftIcon.Image; }
            set { stepLeftIcon.Image = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Text
        {
            get { return afLabelBox1.Text; }
            set { afLabelBox1.Text = value; }
        }

        public bool isCorrent
        {
            get { return is_corrent; }
            set { is_corrent = value; }
        }
        public IconBtn()
        {
            InitializeComponent();
        }




        private void onMouseHoverIconBtn(object sender, EventArgs e)
        {
        }

        private void onMouseLeaveIconBtn(object sender, EventArgs e)
        {
        }



        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public event EventHandler StepLeftIconClick;


        private void onStepLeftIconClick(object sender, EventArgs e)
        {
            isFinish = !isFinish;
            StepLeftIconClick?.Invoke(this, e);
        }

        private void onMouseHoverIconBtn(object sender, MouseEventArgs e)
        {
        }
    }
}
