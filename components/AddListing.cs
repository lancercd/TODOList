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

namespace TODOList
{
    public partial class AddListing : Form
    {
        public AddListing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strconn;
            strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TODO.mdf;Integrated Security=True";
            string strfn_destination;   //strfn_destination是文件拷贝后的完整路径       
            string strDBfilename; //放入数据库后文件的名称，just文件名，不包括路径
                                  //放入数据库中文件的名字就是 学生学号.jpg，这样保证没有重名，而且和学生学号对应起来，也方便查找等
            strfn_destination = Application.StartupPath + "\\images\\" + textBox1.Text + ".jpg";
            strDBfilename = textBox1.Text + ".jpg";
            //复制文件
            File.Copy(strfullfilename, strfn_destination);
            //添加包含图片文件名的记录到数据库中                    
            
            string strSQL1;
            strSQL1 = "insert into tb_listing values(N'" + strDBfilename + "',N'" + textBox1.Text + "')";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = strSQL1;
            cmd.CommandType = CommandType.Text;
            int aa = cmd.ExecuteNonQuery();
            if (aa > 0)
            {                
                MessageBox.Show("添加成功!");
            }
            else
            {
                MessageBox.Show("添加失败!");
            }

            cmd.Dispose();
            conn.Close();
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
    }
}
