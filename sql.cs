using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace 物流管理系统
{
    class sql
    {
        public static string DataBaseName
        {
            get
            {
                IniFile ini = new IniFile(Application.StartupPath + @"\config.ini");
                return ini.ReadString("config", "database");
            }
        }

        public static  string getconnstr() {
            string str;
            IniFile ini = new IniFile(Application.StartupPath + @"\config.ini");
            str = "Data Source=.;User ID=sa;Password=sa;Initial Catalog=db_john;Persist Security Info=True;";
            return str;
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection(getconnstr());
            return conn;
        }

        #region 构造函数
        public sql()
        {

        }
        #endregion

        #region 创建SqlCommand对象
        public SqlCommand CreateSqlCommand()
        {
            SqlConnection conn = this.CreateConnection();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            return cmd;
        } 
        #endregion

        public SqlDataReader CreateSqlDataReader(string SqlStr)
        {
            SqlCommand cmd = this.CreateSqlCommand();
            cmd.CommandText = SqlStr;
            return cmd.ExecuteReader();
        }

        public bool ExecuteSql(string SqlStr)
        {
            SqlCommand cmd = this.CreateSqlCommand();
            try
            {

                cmd.CommandText = SqlStr;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #region 用户是否存在 ExustsUsers

        public bool ExustsUsers(String UserName)
        {
            SqlDataReader read = this.CreateSqlDataReader("select * from tb_users where UserName='" + UserName + "'");
            int count = 0;
            while (read.Read())
            {
                count++;
            }
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        public bool ExustsUsers(String UserName, String Password)
        {
            SqlDataReader read = this.CreateSqlDataReader("select * from tb_users where UserName='" + UserName + "' and UserPwd='" + Password + "'");
            int count = 0;
            while (read.Read())
            {
                count++;
            }
            if (count > 0)
            {
                return true;
            }
            return false;
        } 
        #endregion

        #region 备份数据库 BackupDatabase
        public void BackupDatabase(string path)
        {
            try
            {
                SqlCommand cmd = this.CreateSqlCommand();
                cmd.CommandText = "backup database " + DataBaseName + " to disk='" + path + "'";
                //MessageBox.Show(cmd.CommandText, "11");
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        } 
        #endregion

        #region 还原数据库 RevertDataBase
        public void RevertDataBase(string path)
        {
            try
            {
                SqlCommand cmd = this.CreateSqlCommand();
                cmd.CommandText = "use master restore database " + DataBaseName + " from disk='" + path.Trim() + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("还原成功!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        } 
        #endregion
    }
}
