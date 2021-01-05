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
    public partial class addTaskBox : UserControl
    {
   
        public addTaskBox()
        {
            InitializeComponent();
            addTaskInputBox.Visible = false;
            addTaskInputBox.BackColor = Color.Transparent;
            addTaskBoxLabel.BackColor = Color.Transparent;
            //addTaskInputBox.LostFocus += new EventHandler(TextBoxLostFoucs);
            //addTaskInputBox.LostFocus += new EventHandler(onAddTaskBoxBlur);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void onAddTaskBoxFocus(object sender, EventArgs e)
        {
            //MessageBox.Show("聚焦");
            showAddBoxInput();
            
            
        }

        private void onAddTaskBoxBlur(object sender, EventArgs e)
        {
            //MessageBox.Show("失去焦点");
            showAddBoxLabel();
            
        }


        public void showAddBoxLabel()
        {
            addTaskInputBox.Text = "";
            hideControl(addTaskInputBox);
            showControl(addTaskBoxLabel);



        }

        public void showAddBoxInput()
        {
            addTaskInputBox.Text = "";
            hideControl(addTaskBoxLabel);
            //addTaskInputBox.Location = new System.Drawing.Point(262, 50);
            
            showControl(addTaskInputBox);
            
        }

        private void showControl(Control com)
        {
            com.Dock = DockStyle.Fill;
            com.Visible = true;
            com.Size = new Size(300, 50);
        }

        private void hideControl(Control com)
        {
            com.Dock = DockStyle.None;
            com.Visible = false;
            com.Size = new Size(0, 0);
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public event EventHandler SubmitEvent;




        private void onEnterPress(object sender, EventArgs e)
        {
            SubmitEvent?.Invoke(this, e);
        }


        public override string Text
        {
            get
            {
                return addTaskInputBox.Text;
            }
            set
            {
                addTaskInputBox.Text = value;
            }
        }

    }
}
