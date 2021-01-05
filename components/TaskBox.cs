using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TODOList.components
{
    public partial class TaskBox : UserControl
    {
        private bool isImportantTask;



        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool isImpTask
        {
            get
            {
                return isImportantTask;
            }
            set
            {
                isImportantTask = value;
                if (value)
                {
                    RightIcon.Image = Properties.Resources.start_fill;
                }
                else
                {
                    RightIcon.Image = (Image)Properties.Resources.start_empty;
                }
            }
        }



        //圆角度数
        [Browsable(false)]  //不显示在属性面板
        public static int radius = 20;


        //任务标题
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TeskTitle
        {
            get
            {
                return TaskTitle.Text;
            }
            set
            {
                TaskTitle.Text = value;
            }
        }

        //任务副标题
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Describe
        {
            get
            {
                return DescribeText.Text;
            }
            set
            {
                DescribeText.Text = value;
            }
        }

  

        public TaskBox()
        {
            InitializeComponent();
        }


        

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                return TeskTitle;
            }
            set
            {
                TeskTitle = value;
            }
        }

        //[Browsable(true)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        //public override Color BackColor
        //{
        //    get
        //    {
        //        return base.BackColor;
        //    }
        //    set
        //    {
        //        base.BackColor = value;
        //    }
        //}

        public event EventHandler addToImportant;


        private void addToImportantIconClick(object sender, EventArgs e)
        {

            addToImportant?.Invoke(this, e);
            //if(addToImportant != null)
            //{
            //    addToImportant.Invoke(this, e);
            //}
        }












        private void TaskBoxTest_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, radius);
            this.Region = new Region(FormPath);
        }

        /// <summary>
        /// <param name="rect">窗体大小</param>
        /// <param name="radius">圆角大小</param>
        /// <returns></returns>
        /// /// </summary>
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();

            path.AddArc(arcRect, 180, 90);//左上角

            arcRect.X = rect.Right - diameter;//右上角
            path.AddArc(arcRect, 270, 90);

            arcRect.Y = rect.Bottom - diameter;// 右下角
            path.AddArc(arcRect, 0, 90);

            arcRect.X = rect.Left;// 左下角
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();
            return path;
        }

        
    }
}
