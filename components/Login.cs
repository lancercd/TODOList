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

using TODOList.utils;


namespace TODOList
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox1.Text = Utils.initUserName;
            textBox2.Text = Utils.initPwd;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("用户名不能为空！");
            }
            else if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("用户名不能为空！");
            }
            
                
            string strSQL;
            strSQL = "Select * from tb_user where username=N'" + textBox1.Text + "' and pwd=N'" + textBox2.Text + "'";  //精确查询，加上N确保select汉字
            LinkedList<Dictionary<Object, Object>>  data = DB.getLinkedList(strSQL);
            SqlDataReader dr = DB.getData(strSQL);
            if (data.Count != 0)
            {
                Dictionary<Object, Object> user = data.First();
                //保存登录用户id
                Form1.uid = Convert.ToInt32(user["uid"]);
                PassVar.Uid = Convert.ToInt32(user["uid"]);
                if (Form1.MainFrame != null)
                {
                    Form1.MainFrame.is_login = true;
                    Form1.MainFrame.label1.Text = Convert.ToString(user["email"]);
                    Form1.MainFrame.usernameLabel.Text = Convert.ToString(user["username"]);

                    string strpath = Application.StartupPath + "\\images\\" + user["avatar"];
                    Form1.MainFrame.pictureBox1.Image = Image.FromFile(strpath);


                    Form1.MainFrame.openChildForm(new MyDay("我的一天", false, false, 0, 1));
                }
            }
            else
            {
                MessageBox.Show("用户名或密码不正确！");
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            Register fre = new Register();
            fre.Show();
           // this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(232,232,232);
        }
    }
}
