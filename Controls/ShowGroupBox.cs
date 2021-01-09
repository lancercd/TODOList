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
    public partial class ShowGroupBox : UserControl
    {
        public int id;
        private string team_name;
        private int num_count;
        private ulong add_time;
        public int ugid;
        private bool is_leader;

        public string teamName
        {
            get { return team_name; }
            set { team_name = value; TeamNameLabel.Text = value; }
        }

        public int numCount
        {
            get { return num_count; }
            set { num_count = value; NumCountLabel.Text = num_count + "人"; }
        }

        public ulong addTime
        {
            get { return add_time; }
            set { add_time = value; addTimeLabel.Text = Convert.ToString(value); }
        }

        public bool isLeader


        {
            get { return is_leader; }
            set 
            {
                is_leader = value;
                if (is_leader) TeamNameLabel.BackColor = Utils.getColorFromRGB(231, 76, 60);
                else TeamNameLabel.BackColor = Utils.getColorFromRGB(238, 149, 149);
            }
        }




        public ShowGroupBox()
        {
            InitializeComponent();
        }




        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public event EventHandler ShowGroupBoxClick;

        private void onShowGroupBoxClick(object sender, EventArgs e)
        {
            ShowGroupBoxClick?.Invoke(this, e);
        }
    }
}
