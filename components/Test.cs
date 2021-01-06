using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOList.components
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            AfLabelBox label = new AfLabelBox();
            label.BackColor = System.Drawing.Color.Transparent;
            label.Location = new System.Drawing.Point(159, 319);
            label.Name = "afTextBox1";
            label.Size = new System.Drawing.Size(479, 98);
            this.Controls.Add(label);

            //afTextBox1.edit.PlaceHolderStr = "okkkk";
        }

        private void placeholderTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
