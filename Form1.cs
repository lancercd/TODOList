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


namespace TODOList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();

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
            openChildForm(new MyDay());
        }








        private Form activeForm = null;
        private void openChildForm(Form childForm)
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
            openChildForm(new Ok());
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            //openChildForm(new RandomRollCall());
            //Login flo = new Login();
            //flo.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //openChildForm(new RandomQuestion());
        }

        private void add_listing_Click(object sender, EventArgs e)
        {
            AddListing fal = new AddListing();
            fal.Show();

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
                //this.Hide();
                //Login flo = new Login();
                openChildForm(new Register());
                //flo.Show();
                //MessageBox.Show("您尚未登录，请先登录！");
                //this.Close();

            }
            //openChildForm(new Login());
            dr.Close();
            cmd.Dispose();
        }


        private void show_listing()
        {
            string strconn;
            strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TODO.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string sql = "SELECT count(*) FROM tb_listing";
            //  MySqlConnection conn = new MySqlConnection(conStr);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int count = Convert.ToInt32(dt.Rows[0][0]);

            string strSQL1;
            strSQL1 = "Select * from tb_listing";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = strSQL1;
            cmd1.CommandType = CommandType.Text;
            SqlDataReader dr1;
            dr1 = cmd1.ExecuteReader();

            Button[] a = new Button[count];//创建一个新的按钮
                                           //for (int i=0;i< 3; i++)
                                           //{


            //}
            if (dr1.Read())
            {
                for (int i = 0; i < 3; i++)
                {
                    a[i] = new Button();
                    string strpath;
                    strpath = Application.StartupPath + "\\images\\" + dr1["icon"] + "";
                    a[i].Image = Image.FromFile(strpath);
                    a[i].Text = dr1["title"].ToString();
                    a[i].Width = 210;
                    a[i].Height = 40;
                    a[i].Font = new Font("微软雅黑 Light", 10.8f);
                    a[i].BackColor = Color.WhiteSmoke;
                    a[i].Location = new Point(0, i * a[i].Height);
                    panel3.Controls.Add(a[i]);//向panel中添加此按钮
                                              ////panel3.Controls.Add(a[i]);
                                              // MessageBox.Show("i");
                }
                


            }
            add_listing_addBtn();



            dr1.Close();
            cmd1.Dispose();
            conn.Close();
        }


        private void add_listing_addBtn()
        {
            Button b = new Button();
            b.Dock = DockStyle.Top;
            b.Text = "+";
            //b.Width = 210;
            b.Height = 40;
            b.Font = new Font("微软雅黑 Light", 10.8f);
            b.BackColor = Color.WhiteSmoke;
            //b.Location = new Point(0, 40 * 3);
            b.Click += add_listing_Click;
            panel3.Controls.Add(b);//向panel中添加此按钮
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isLogin();
            show_listing();




        }
    }
    
}
