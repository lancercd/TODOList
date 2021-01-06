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
using System.IO;
using TODOList.utils;

namespace TODOList
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strconn;
            strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TODO.mdf;Integrated Security=True";
           
            string strSQL;
            strSQL = "select count(*) from tb_user where username =N'" + textBox1.Text + "'";                
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd1 = new SqlCommand(strSQL, conn);
            conn.Open();
            int tt = Convert.ToInt32(cmd1.ExecuteScalar());
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("用户名不能为空！");
            }           
            else if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("密码不能为空！");
            }
            else if (textBox3.Text.Length != textBox2.Text.Length)
            {
                MessageBox.Show("密码不一致！");
            }
            else if (strfullfilename=="")
            {
                MessageBox.Show("请选择您的头像！");
            }
            else//ExecuteScalar
            {
                 if (tt > 0)
                {
                    conn.Close();
                    MessageBox.Show("用户名已经存在！");
                }
                else
                {
                    string strfn_destination;   //strfn_destination是文件拷贝后的完整路径       
                    string strDBfilename; //放入数据库后文件的名称，just文件名，不包括路径
                                          //放入数据库中文件的名字就是 学生学号.jpg，这样保证没有重名，而且和学生学号对应起来，也方便查找等
                    strfn_destination = Application.StartupPath + "\\images\\" + textBox1.Text + ".jpg";
                    strDBfilename = textBox1.Text + ".jpg";
                    //复制文件
                    File.Copy(strfullfilename, strfn_destination);
                    //添加包含图片文件名的记录到数据库中                    
                    //conn.Open();
                    string strSQL1 = "insert into tb_user values('" + textBox1.Text + "',N'" + textBox2.Text + " ',N'" + strDBfilename + "',N'" + textBox4.Text + " ')";
                    int num = DB.getEffNum(strSQL1);

                    if (num > 0)
                    {
                        Form1.MainFrame.openChildForm(new Login());
                        this.Close();
                        MessageBox.Show("注册成功!");
                    }
                    else
                    {
                        MessageBox.Show("注册失败!");
                    }

                }               
            }
        }

        string strfullfilename = ""; //需要添加的图片文件的全名，包括路径
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "图片文件(*.jpg)|*.jpg|图片文件(*.gif)|*.gif|所有文件(*.*)|*.*";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strfullfilename = openFileDialog1.FileName;
                if (strfullfilename != "")
                {
                    pictureBox1.Image = Image.FromFile(strfullfilename);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if(Form1.MainFrame != null)
            {
                Form1.MainFrame.openChildForm(new Login());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            textBox3.UseSystemPasswordChar = false;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(232, 232, 232);
        }
    }
}
