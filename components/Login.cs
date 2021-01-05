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
            else
            {
                string strconn;
                strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TODO.mdf;Integrated Security=True";
                
                string strSQL;
                strSQL = "Select * from tb_user where username=N'" + textBox1.Text + "' and pwd=N'" + textBox2.Text + "'";  //精确查询，加上N确保select汉字

                SqlDataReader dr = DB.getData(strSQL);
                if (dr.Read())
                {
                    PassVar.Uid = Convert.ToInt32(dr.GetValue(0));
                    Form1 f1 = new Form1();
                    f1.Show();
                    //this.Close();
                    //MessageBox.Show("登录成功！");
                }
                else
                {
                    MessageBox.Show("用户名或密码不正确！");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            Register fre = new Register();
            fre.Show();
            this.Close();
        }
    }
}
