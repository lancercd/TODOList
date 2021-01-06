using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOList.components
{
    public partial class AfTextBox : UserControl
    {
        public int id;

        public AfTextBox()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            
            edit.LostFocus += new EventHandler(onTextBoxLostFoucs);
            edit.GotFocus += new EventHandler(onTextBoxGotFoucs);
        }


        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            //获取子控件
            if (this.Controls.Count == 0) return;
            Control c = this.Controls[0];

            //父窗口参数
            Padding p = this.Padding;
            int x = 0, y = 0;
            int w = this.Width, h = this.Height;
            w -= (p.Left + p.Right);
            x += p.Left;

            //计算文本框的高度, 使其显示在中间
            int h2 = c.PreferredSize.Height;
            if (h2 > h) h2 = h;
            y = (h - h2) / 2;
            c.Location = new Point(x, y);
            c.Size = new Size(w, h2);
        }


        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                return edit.Text;
            }
            set
            {
                edit.Text = value;
            }
        }


        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override Font Font 
        {

            get => edit.Font; set => edit.Font = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override Color BackColor 
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                //edit.BackColor = Color.Transparent;
                //edit.BackColor = value;
                base.BackColor = Color.Transparent;
                //base.BackColor = value;
            }
        }



        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public event EventHandler TextBoxLostFoucs;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public event EventHandler TextBoxGotFoucs;


        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public event EventHandler EnterPress;



        private void onTextBoxLostFoucs(object sender, EventArgs e)
        {

            TextBoxLostFoucs?.Invoke(this, e);
        }


        private void onTextBoxGotFoucs(object sender, EventArgs e)
        {
            TextBoxGotFoucs?.Invoke(this, e);
        }


        private void onEnterPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(ch == '\r')
            {
                EnterPress?.Invoke(this, e);
            }
        }
    }
}
