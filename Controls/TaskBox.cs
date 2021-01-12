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
using TODOList.utils;

namespace TODOList.components
{
    public partial class TaskBox : UserControl
    {

        public int id;
        public int uid;
        private string title;
        public ulong deadLine = 0;
        public ulong alertTime = 0;
        public ulong add_time;
        private string detail;
        public int listing_id;
        public int is_assign;
        private bool is_important;


        public int leader_id = 0;
        public int to_uid = 0;
        public int gid = 0;



        //是否需要分配   自己创建的任务 rightSide panel中出现分配下拉框
        public bool need_to_assign = false;




        public bool is_assign_task = false;


        public string deadline
        {
            get 
            {
                return (deadLine == 0)? "" : TimeUtil.getDate(deadLine);
            }
            set
            {
                deadLine = Convert.ToUInt64((value == "") ? "0" : value);
                //ulong now = Convert.ToUInt64(TimeUtil.GetNow());
                //if (deadLine != 0 && alertTime != 0)
                //{
                //    if (alertTime < now && now <= deadLine) BackColor = Utils.getColorFromRGB(243, 156, 18);
                //}
                //if (deadLine != 0 && now > deadLine) BackColor = Utils.getColorFromRGB(231, 76, 60);

            }
        }

        public string alert_time
        {
            get
            {
                return (alertTime == 0) ? "" : TimeUtil.getDate(alertTime);
            }
            set
            {
                
                alertTime = Convert.ToUInt64((value == "")? "0":value);
                //ulong now = Convert.ToUInt64(TimeUtil.GetNow());
                //if (deadLine != 0 && alertTime != 0)
                //{
                //    if (alertTime < now && now <= deadLine)
                //    {
                //        BackColor = Utils.getColorFromRGB(243, 156, 18);
                //    }
                //}
                //if (deadLine != 0 && now > deadLine)
                //{
                    
                //    BackColor = Utils.getColorFromRGB(231, 76, 60);
                //}

            }
        }



        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool isImportantTask
        {
            get { return is_important; }
            set
            {
                is_important = value;
                if (value) RightIcon.Image = Properties.Resources.start_fill;
                else RightIcon.Image = (Image)Properties.Resources.start_empty;
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
            get { return title; }
            set {
                title = value; 
                TaskTitleLabel.Text = value;
            }
        }

        //任务副标题
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Describe
        {
            get { return detail; }
            set { detail = value; DescribeText.Text = value;}
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
                return title;
            }
            set
            {
                TaskTitleLabel.Text = value;
                title = value;
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

        //点击五角星触发事件   添加或取消 [任务.重要]
        public event EventHandler addToImportant;

        //点击任务触发该事件   打开右侧侧边栏
        public event EventHandler ClickTaskBoxEvent;

        private void addToImportantIconClick(object sender, EventArgs e)
        {

            isImportantTask = !isImportantTask;
            addToImportant?.Invoke(this, e);
            //if (addToImportant != null)
            //{
            //    isImportantTask = !isImportantTask;
            //    addToImportant.Invoke(this, e);
            //}
        }

        protected void onTaskClick(object sender, EventArgs e)
        {
            ClickTaskBoxEvent?.Invoke(this, e);
        }















        private void TaskBoxTest_Load(object sender, EventArgs e)
        {
            //System.Drawing.Drawing2D.GraphicsPath FormPath;
            //FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            //Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            //FormPath = GetRoundedRectPath(rect, radius);
            //this.Region = new Region(FormPath);
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


        private void OnMouseHoverTaskBox(object sender, EventArgs e)
        {
            //MessageBox.Show("hover");
            //BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void OnMouseLeaveTaskBox(object sender, EventArgs e)
        {
            //BackColor = System.Drawing.SystemColors.ControlLightLight;
        }
    }
}
