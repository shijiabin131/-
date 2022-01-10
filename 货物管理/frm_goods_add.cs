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
    public partial class frm_goods_add : Form
    {
        frm_goods frm;
        public frm_goods_add(frm_goods frm)
        {
            InitializeComponent();
             this.frm = frm;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(txt_Gname.Text=="" || txt_Gcordon.Text=="" || txt_Gcount.Text=="" || txt_Gprice.Text=="" || txt_Gremarks.Text=="" || txt_Gsum.Text=="" || txt_Gunit.Text=="" || txt_Gsytle.Text=="" || cmb_Sname.Text  =="" || dtp_Geditime.Value.ToString()==""){

                MessageBox.Show("请填写完整信息!");
                return;
            }
            sql conn = new sql();
            string sqlstr = "insert into tb_goods(Gname,Sname,Gstyle,Gunit,Gcount,Gprice,Gsum,Gcordon,Geditime,Gremarks) "+
            "values('"+txt_Gname.Text+"','"+cmb_Sname.Text+"','"+txt_Gsytle.Text+"','"+txt_Gunit.Text+"','"+txt_Gcount.Text+"','"+txt_Gprice.Text+"','"+txt_Gsum.Text+"','"+txt_Gcordon.Text+"','"+dtp_Geditime.Value.ToString()+"','"+txt_Gremarks.Text+"')";
            if (conn.ExecuteSql(sqlstr))
            {
                MessageBox.Show("添加成功!");
                frm.reload();
                Close();
            }
            else
            {
                MessageBox.Show("添加失败!");
            }
        }

        private void frm_goods_add_Load(object sender, EventArgs e)
        {
            sql conn = new sql();
            string sqlstr = "select Sname from tb_stores";
            SqlDataReader dr =  conn.CreateSqlDataReader(sqlstr);
            while (dr.Read()) {
                cmb_Sname.Items.Add(dr[0]);
            }
            cmb_Sname.SelectedIndex = 0;
        }
    }
}