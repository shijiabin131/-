using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 物流管理系统
{
    public partial class frm_supplyer_mod : Form
    {
        frm_supplyer frm;
        public frm_supplyer_mod(frm_supplyer frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_SUname.Text == "" || txt_SUaddress.Text == "" || txt_SUpeople.Text == "" || txt_SUremarks.Text == "" || txt_SUtel.Text == "")
            {
                MessageBox.Show("请填写完整信息!");
                return;
            }
            sql conn = new sql();
            string sqlstr = "update tb_supplyer set SUname='"+txt_SUname.Text+"',SUpeople='"+txt_SUpeople.Text+"',SUtel='"+txt_SUtel.Text+"',SUaddress='"+txt_SUaddress.Text+"',SUremarks='"+txt_SUremarks.Text+"' where SUID="+txt_SUID.Text;
            if (conn.ExecuteSql(sqlstr))
            {
                MessageBox.Show("修改成功!");
                frm.reload();
            }
            else {
                MessageBox.Show("修改失败!");
            }
            
        }

        private void frm_supplyer_mod_Load(object sender, EventArgs e)
        {

        }
    }
}