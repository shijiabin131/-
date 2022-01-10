using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 物流管理系统
{
    public partial class frm_stores_add : Form
    {
                public frm_stores frmstores;
        public frm_stores_add(frm_stores frm)
        {
            InitializeComponent();
            frmstores=frm;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_Sname.Text=="" || txt_Speople.Text=="" || 
                txt_Sremarks.Text=="" || txt_Stel.Text=="" || Txt_Sunit.Text=="")
            {
                MessageBox.Show("请填写完整资料!");
                return;
            }
            sql conn = new sql();
            string sqlstr = "insert into tb_stores(Sname,Speople,Stel,Sunit,Sremarks) values('"+txt_Sname.Text+"','"+txt_Speople.Text+"','"+txt_Stel.Text+"','"+Txt_Sunit.Text+"','"+txt_Sremarks.Text+"')";
            if (conn.ExecuteSql(sqlstr))
            {
                MessageBox.Show("添加成功!");
                frmstores.reload();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_stores_add_Load(object sender, EventArgs e)
        {

        }
    }
}