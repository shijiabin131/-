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
    public partial class frm_login : Form
    {
        bool log = false;
        frm_main frmmain;
        public frm_login(frm_main frm)
        {
            InitializeComponent();
            frmmain = frm;
        }
        private void frm_login_Load(object sender, EventArgs e)
        {
            sql sql = new sql();
            SqlCommand cmd = sql.CreateSqlCommand();
            cmd.CommandText = "select * from tb_users";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()){
                cmb_user.Items.Add(reader["UserName"].ToString());
            }
            cmb_user.SelectedIndex = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            btn_login.Enabled = false;
            sql sql = new sql();
            if (sql.ExustsUsers(cmb_user.Text,txt_pwd.Text))
            {
                sql conn = new sql();
                string sqlstr = "select * from tb_users where UserName='"+cmb_user.Text+"'";
                SqlDataReader dr = conn.CreateSqlDataReader(sqlstr);
                dr.Read();
                if (dr[3].ToString().Trim() == "普通用户") {
                    frmmain.TSMI_USERMGR.Visible = false;
                    //frmmain.TSMI_DBOP.Visible = false;
                    common.UserRight = "普通用户";
                }else{
                    frmmain.TSMI_USERMGR.Visible = true;
                    //frmmain.TSMI_DBOP.Visible = true;
                    common.UserRight = "超级管理员";
                }
                log = true;
                common.UserName = cmb_user.Text;
                Close();
            }else{
                MessageBox.Show("用户名或密码错误!");
            }
            btn_login.Enabled = true;
        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!log) {
                Application.Exit();
            }
        }

        private void txt_pwd_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                this.btn_login_Click(this,null); 
            };
            
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_pwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}