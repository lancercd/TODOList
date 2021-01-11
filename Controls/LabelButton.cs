using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TODOList.utils;

namespace TODOList.Controls
{
    public partial class LabelButton : UserControl
    {
        public int id;
        private bool is_select = false;
        public bool action = false;
        public string selectedText = "";
        public string unselectedText = "";
        public bool isSelect
        {
            get { return is_select; }
            set 
            {
                
                is_select = value;
                if (action)
                {
                    if (is_select)
                    {
                        this.afLabelBox1.Text = selectedText;
                        this.BackColor = Utils.getColorFromRGB(231, 76, 60);
                    }
                    else
                    {
                        this.afLabelBox1.Text = unselectedText;
                        this.BackColor = Utils.getColorFromRGB(52, 152, 219);
                    }
                }
            }
        }


        public LabelButton()
        {
            InitializeComponent();
            this.BackColor = Utils.getColorFromRGB(52, 152, 219);
            //this.afLabelBox1.edit.ForeColor = Color.White;
            //this.afLabelBox1.edit.Font = new System.Drawing.Font("黑体", 16F);
        }



        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public event EventHandler LabelBtnClick;

        private void onLabelBtnClick(object sender, EventArgs e)
        {
            if (action) isSelect = !isSelect;
            LabelBtnClick?.Invoke(this, e);
        }



        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                return afLabelBox1.Text;
            }
            set
            {
                afLabelBox1.Text = value;
            }
        }


    }
}
