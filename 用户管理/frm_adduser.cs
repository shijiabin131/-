using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 物流管理系统
{
    public partial class frm_adduser : Form
    {
        public frm_adduser()
        {
            InitializeComponent();
        }

        private void frm_adduser_Load(object sender, EventArgs e)
        {
            cmb_right.SelectedIndex = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" && txt_pwd.Text=="")
            {
                MessageBox.Show("用户名或密码不能为空!");
                return;
            }
            sql conn = new sql();
            if (conn.ExustsUsers(txt_name.Text)){
                MessageBox.Show("用户已经存在,请另选自已用户名!");
                return;
            }
            string str = "insert into tb_users(UserName,UserPwd,UserRight) values('"+txt_name.Text+"','"+txt_pwd.Text+"','"+cmb_right.Text+"')";
            if (conn.ExecuteSql(str))
            {
                MessageBox.Show("用户添加成功!");
                Close();
            }else
            {
                MessageBox.Show("用户添加失败!");
            }

        }
    }
}