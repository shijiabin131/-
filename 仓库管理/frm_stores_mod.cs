using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 物流管理系统
{
    public partial class frm_stores_mod : Form
    {
        frm_stores frm;
        public frm_stores_mod(object frm)
        {
            InitializeComponent();
            this.frm = (frm_stores)frm;
        }

        private void frm_stores_mod_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            sql conn = new sql();
            string sqlstr = "update tb_stores set Sname='"+txt_Sname.Text+"',Speople='"+txt_Speople.Text+"',Stel='"+txt_Stel.Text+"',Sunit='"+Txt_Sunit.Text+"',Sremarks='"+txt_Sremarks.Text+"' where SID="+txt_sid.Text;
            if (conn.ExecuteSql(sqlstr))
            {
                MessageBox.Show("修改成功!");
                frm.reload();
                Close();
                
            }
            else {
                MessageBox.Show("修改失败!");
            }
        }
    }
}