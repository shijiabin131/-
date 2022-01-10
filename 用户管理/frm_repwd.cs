using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 物流管理系统
{
    public partial class frm_repwd : Form
    {
        public frm_repwd()
        {
            InitializeComponent();
        }

        private void frm_repwd_Load(object sender, EventArgs e)
        {
            txt_name.Text = common.UserName;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //判断两次密码是否一致
            if (txt_newpwd.Text != txt_newpwd2.Text) {
                MessageBox.Show("新密码与确认密码不同!");
                return;
            }
            //查询旧密码是否正确
            sql conn =new sql();
            string sqlstr = "select * from tb_users where UserName = '"+txt_name.Text+"'";
            SqlDataReader dr = conn.CreateSqlDataReader(sqlstr);
            dr.Read();
            if (txt_oldpwd.Text != dr[2].ToString())
            {
                MessageBox.Show("原始密码不正确，请重新填写!");
                return; 
            }
            sqlstr = "update tb_users set UserPwd = '"+txt_newpwd.Text+"' where UserName='"+txt_name.Text+"'";
            if (conn.ExecuteSql(sqlstr))
            {
                MessageBox.Show("修改成功!");
            }
            else {
                MessageBox.Show("修改失败!");
            }
            

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}