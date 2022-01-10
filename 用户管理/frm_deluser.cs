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
    public partial class frm_deluser : Form
    {
        public frm_deluser()
        {
            InitializeComponent();
        }

        private void frm_deluser_Load(object sender, EventArgs e)
        {
            lst_users.Items.Clear();
            sql conn = new sql();
            string sqlstr="select * from tb_users";
            SqlDataReader dr = conn.CreateSqlDataReader(sqlstr);
            while(dr.Read())
            {
                lst_users.Items.Add(dr[1]);
            }
            
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            sql conn = new sql();
            string sqlstr = "delete tb_users where UserName='"+lst_users.SelectedItem.ToString()+"'";
            if (conn.ExecuteSql(sqlstr))
            {
                MessageBox.Show("删除成功!");
                this.frm_deluser_Load(null, null);
            }else{
                MessageBox.Show("删除失败!");

            }

        }
    }
}