using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Net.Http;

namespace TODOList.utils
{
    class DB : IDisposable
    {
        
        /// <summary>
        /// 受保护的数据库连接
        /// </summary>
        protected SqlConnection connection = null;
        /// <summary>
        /// 受保护的数据库连接字符串
        /// </summary>
        //protected string connString = @"(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TODO.mdf;Integrated Security=True";
        protected string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TODO.mdf;Integrated Security=True";
        public DB()
        {
            Open();
        }
        /// <summary>
        /// 构造函数，初始化数据库连接
        /// </summary>
        /// <param name="sqlConnection">数据库连接</param>
        public DB(SqlConnection sqlConnection)
        {
            this.connection = sqlConnection;
            Open();
            this.connString = sqlConnection.ConnectionString;
        }

        
        /// <summary>
        /// 构造函数，初始化数据库连接字符串
        /// </summary>
        /// <param name="strConn">数据库连接字符串</param>
        public DB(string strConn)
        {
            this.connString = strConn;
            Open();
        }
        /// <summary>
        /// 公共方法：打开数据库连接
        /// </summary>
        public void Open()
        {
            try
            {
                if (connection == null)
                {
                    connection = new SqlConnection(connString);
                }
                if (connection.State != ConnectionState.Open)
                {
                   
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        /// <summary>
        /// 公共方法：关闭数据库连接
        /// </summary>
        public void Close()
        {
            if ((connection != null) && (connection.State != ConnectionState.Closed))
            {
                connection.Close();
            }
        }
        /// <summary>
        /// 公共方法：获取数据库连接
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection()
        {
            return connection;
        }
        /// <summary>
        /// 公共方法：获取数据库连接字符串
        /// </summary>
        /// <returns></returns>
        public string GetConnString()
        {
            return connString;
        }
        /// <summary>
        /// 公共方法：释放非托管资源；实现IDisposable接口
        /// </summary>
        public void Dispose()
        {
            if (connection != null)
            {
                connection = null;
                GC.Collect();
            }
        }


        private SqlCommand attachSql(string sql)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.GetConnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            return cmd;
        }

      
        protected static SqlCommand getDB(DB db, string sql)
        {
            SqlCommand cmd = db.attachSql(sql);
            return cmd;
        }


        /// <summary>
        /// 返回dataReader
        /// </summary>
        /// <returns>int</returns>
        public static SqlDataReader getData(string sql)
        {
            DB db = new DB();
            SqlDataReader rd = DB.getDB(db, sql).ExecuteReader();
            //db.Close();
            return rd;
        }
        public static SqlDataReader getData(string sql, DB db)
        {
            SqlDataReader rd = DB.getDB(db, sql).ExecuteReader();
            //db.Close();
            return rd;
        }

        /// <summary>
        /// 受影响的行数
        /// </summary>
        /// <returns>int</returns>
        public static int getEffNum(string sql)
        {
            DB db = new DB();
            int num = DB.getDB(db, sql).ExecuteNonQuery();
            //db.Close();
            return num;
        }
        public static int getEffNum(string sql, DB db)
        {
            int num = DB.getDB(db, sql).ExecuteNonQuery();
            //db.Close();
            return num;
        }

        /// <summary>
        /// 返回第一条数据
        /// </summary>
        /// <returns>int</returns>
        public static Object getOne(string sql)
        {
            DB db = new DB();
            Object obj = DB.getDB(db, sql).ExecuteScalar();
            //db.Close();
            return obj;
        }
        public static Object getOne(string sql, DB db)
        {
            Object obj = DB.getDB(db, sql).ExecuteScalar();
            //db.Close();
            return obj;
        }


        public static LinkedList<Dictionary<Object, Object>> getLinkedList(string sql)
        {
            SqlDataReader sourse = DB.getData(sql);
            LinkedList<Dictionary<Object, Object>> data = FormData(sourse);
            sourse.Close();
            return data;
        }
        public static LinkedList<Dictionary<Object, Object>> getLinkedList(string sql, DB db)
        {
            SqlDataReader sourse = DB.getData(sql, db);
            LinkedList<Dictionary<Object, Object>> data = FormData(sourse);
            sourse.Close();
            return data;
        }


        public static int insert(string sql)
        {
            return Convert.ToInt32(DB.getOne(sql));
        }

        private static LinkedList<Dictionary<Object, Object>> FormData(SqlDataReader sourse)
        {
            LinkedList<Dictionary<Object, Object>> data = new LinkedList<Dictionary<Object, Object>>();
            int len = sourse.FieldCount;
            while (sourse.Read())
            {
                Dictionary<Object, Object> row = new Dictionary<Object, Object>();
                for (int i = 0; i < len; ++i)
                {
                    row.Add(sourse.GetName(i), sourse.GetValue(i));
                }
                data.AddLast(row);
            }
            return data;
        }

    }
}
