using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 物流管理系统
{
    public partial class frm_supplyer_add : Form
    {
        frm_supplyer frm;
        public frm_supplyer_add(frm_supplyer frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(txt_SUname.Text == "" || txt_SUaddress.Text=="" || txt_SUpeople.Text=="" || txt_SUremarks.Text =="" || txt_SUtel.Text == "")
            {
                MessageBox.Show("请填写完整信息!");
                return;
            }
            sql conn = new sql();
            string sqlstr = "insert into tb_supplyer(SUname,SUpeople,SUtel,SUaddress,SUremarks) values('" + txt_SUname.Text + "','" + txt_SUpeople.Text + "','" + txt_SUtel.Text + "','" + txt_SUaddress.Text + "','" + txt_SUremarks.Text + "')";
            if (conn.ExecuteSql(sqlstr))
            {
                MessageBox.Show("添加成功!");
                frm.reload();
                Close();
            }
            else {
                MessageBox.Show("添加失败!");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_supplyer_add_Load(object sender, EventArgs e)
        {

        }
    }
}