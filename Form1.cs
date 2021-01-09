using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using TODOList.utils;
using TODOList.Controls;



namespace TODOList
{
    public partial class Form1 : Form
    {
        public static Form1 MainFrame = null;

        public static int uid = 1;

        public Form1()
        {
            InitializeComponent();
            customizeDesing();
            MainFrame = this;
        }


        private void customizeDesing()
        {
            //panelMediaSubmenu.Visible = false;
            //panelPlaylistSubMenu.Visible = false;
            //panel2.Visible = false;
            //panel3.Visible = false;


        }





        private void btnMedia_Click(object sender, EventArgs e)
        {
            openChildForm(new MyDay("我的一天", false, false, 0, 1));
        }








        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new MyDay("重要任务", false, true, 0, 2));
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new TeamView("用户组", false, false, 0, 3));
            //openChildForm(new RandomRollCall());
            //Login flo = new Login();
            //flo.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //openChildForm(new RandomQuestion());
        }



        private void isLogin()
        {
            string strconn;
            strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TODO.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string strSQL;
            strSQL = "Select * from tb_user where uid= '" + PassVar.Uid + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = strSQL;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string strpath;
                strpath = Application.StartupPath + "\\images\\" + dr["avatar"] + "";
                pictureBox1.Image = Image.FromFile(strpath);
                usernameLabel.Text = dr["username"].ToString();
                label1.Text = dr["email"].ToString();

            }
            else
            {
                openChildForm(new Register());
            }
            dr.Close();
            cmd.Dispose();
        }

        private LinkedList<Dictionary<Object, Object>> getListing()
        {
            LinkedList<Dictionary<Object, Object>> data = DB.getLinkedList(string.Format("SELECT * FROM tb_listing WHERE uid = {0}", uid));



            return data;
        }


        private void createAddListingBtn()
        {
            StepBox cListingBtn = new StepBox();
            cListingBtn.is_other_btn = true;
            cListingBtn.afTextBox1.Text = "添加清单";
            cListingBtn.Image = Properties.Resources.adding;
            cListingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            cListingBtn.Location = new System.Drawing.Point(0, 0);
            cListingBtn.Size = new System.Drawing.Size(266, 50);
            cListingBtn.EnterPressEvent += new EventHandler(onCreateAddListingBtn);
            ListingPanel.Controls.Add(cListingBtn);
        }
        private void onCreateAddListingBtn(object sender, EventArgs e)
        {
            StepBox cListingBtn = sender as StepBox;
            string title = cListingBtn.afTextBox1.Text;
            if (title == "") return;
            int id = DB.insert("INSERT INTO tb_listing (uid, title) VALUES ( " +
                                    uid + ", N'" +
                                    title + "' )");

            show_listing();
        }


        public void show_listing()
        {
            ListingPanel.Controls.Clear();
            createAddListingBtn();

            LinkedList<Dictionary<Object, Object>> data = getListing();
            if (data.Count == 0) return;
            //string sql = "SELECT count(*) FROM tb_listing";

            add_listing_addBtn(data);

        }


        private void add_listing_addBtn(LinkedList<Dictionary<Object, Object>> data)
        {
            

            foreach (Dictionary<Object, Object> btn in data){
                IconBtn iconBtn = new IconBtn();
                iconBtn.id = Convert.ToInt32(btn["Id"]);
                iconBtn.Text = Convert.ToString(btn["title"]);

                initListingBtnStyle(iconBtn);



                ListingPanel.Controls.Add(iconBtn);
            }


            //b.Click += add_listing_Click;
            //ListingPanel.Controls.Add(b);
        }

        private void initListingBtnStyle(IconBtn btn)
        {

            btn.is_other_btn = true;
            btn.IconBtnClickEvent += new EventHandler(onListingBtnClick);
            btn.Dock = System.Windows.Forms.DockStyle.Top;
            btn.Size = new System.Drawing.Size(280, 50);
            btn.Image = Properties.Resources.listingBtnDefault;
        }




        /**
         * 任务清单按点击  创建新窗口
         */
        private void onListingBtnClick(object sender, EventArgs e)
        {
            IconBtn iconBtn = sender as IconBtn;
            int listing_id = iconBtn.id;
            
            openChildForm(new MyDay(iconBtn.Text, true, false, listing_id, 0));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isLogin();
            //show_listing();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            openChildForm(new MyDay("分配的任务", false, false, 0, 4));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new MyDay("全部任务", false, false, 0, 5));
        }
    }
    
}
