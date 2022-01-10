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
    public partial class frm_moduser : Form
    {
        public frm_moduser()
        {
            InitializeComponent();
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_moduser_Load(object sender, EventArgs e)
        {
            cmb_right.SelectedIndex = 0;
            sql conn = new sql();
            string sqlstr = "select * from tb_users";
            SqlDataReader dr = conn.CreateSqlDataReader(sqlstr);
            while (dr.Read())
            {
                cmb_name.Items.Add(dr[1]);
            }
            cmb_name.SelectedIndex = 0;

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text=="")
            {
                MessageBox.Show("请填写新密码!");
            }
            sql conn = new sql();
            string sqlstr = "update tb_users set UserPwd='" + txt_pass.Text + "',UserRight='" + cmb_right.Text + "' where UserName = '"+cmb_name.Text+"'";
            if (conn.ExecuteSql(sqlstr))
            {
                MessageBox.Show("修改成功!");
            };
        }

        private void cmb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql conn = new sql();
            string strsql = "select * from tb_users where UserName='" + cmb_name.Text + "'";
            SqlDataReader dr = conn.CreateSqlDataReader(strsql);
            dr.Read();
            cmb_right.SelectedIndex = cmb_right.Items.IndexOf(dr[3].ToString().Trim());
        }
    }
}