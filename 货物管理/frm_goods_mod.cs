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
    public partial class frm_goods_mod : Form
    {
        frm_goods frm;
        public frm_goods_mod(frm_goods frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void frm_goods_mod_Load(object sender, EventArgs e)
        {
            sql conn = new sql();
            string sqlstr = "select Sname from tb_stores";
            SqlDataReader dr = conn.CreateSqlDataReader(sqlstr);
            while (dr.Read())
            {
                cmb_Sname.Items.Add(dr[0]);
            }
            cmb_Sname.SelectedIndex = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_Gname.Text == "" || txt_Gcordon.Text == "" || txt_Gcount.Text == "" || txt_Gprice.Text == "" || txt_Gremarks.Text == "" || txt_Gsum.Text == "" || txt_Gunit.Text == "" || txt_Gsytle.Text == "" || cmb_Sname.Text == "" || dtp_Geditime.Value.ToString() == "")
            {

                MessageBox.Show("请填写完整信息!");
                return;
            }
            sql conn = new sql();
            string sqlstr ="update tb_goods set Gname='"+txt_Gname.Text+"',Sname='"+cmb_Sname.Text+"',Gstyle='"+txt_Gsytle.Text+"',Gunit='"+txt_Gunit.Text+"',Gcount='"+txt_Gcount.Text+"',Gprice='"+txt_Gprice.Text+"',Gsum='"+txt_Gsum.Text+"',Gcordon='"+txt_Gcordon.Text+"',Geditime='"+dtp_Geditime.Value.ToString()+"',Gremarks='"+txt_Gremarks.Text+"' where GID="+txt_GID.Text;
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