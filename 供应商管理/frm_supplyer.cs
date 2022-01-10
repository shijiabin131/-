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
    public partial class frm_supplyer : Form
    {
        public frm_supplyer()
        {
            InitializeComponent();
        }

        public void reload()
        {
            string sqlstr = "select SUID as 序号,SUname as 供应商名称,SUpeople as 负责人,SUtel as 联系电话,SUaddress as 详细地址,SUremarks as 备注 from tb_supplyer where SUname like '%" + txt_SUname.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, sql.getconnstr());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgview.DataSource = dt;
        }
        private void btn_query_Click(object sender, EventArgs e)
        {
            this.reload();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_supplyer_add frm = new frm_supplyer_add(this);
            frm.ShowDialog();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            if (dgview.SelectedRows.Count>0)
            {
                frm_supplyer_mod frm = new frm_supplyer_mod(this);
                frm.txt_SUID.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                frm.txt_SUname.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                frm.txt_SUpeople.Text = dgview.SelectedRows[0].Cells[2].Value.ToString();
                frm.txt_SUtel.Text = dgview.SelectedRows[0].Cells[3].Value.ToString();
                frm.txt_SUaddress.Text = dgview.SelectedRows[0].Cells[4].Value.ToString();
                frm.txt_SUremarks.Text = dgview.SelectedRows[0].Cells[5].Value.ToString();
                frm.ShowDialog();

            }else
            {
                MessageBox.Show("请选择一个记录!");
            }

            
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dgview.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("确认是否删除?","提示信息",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
                {
                    sql conn = new sql();
                    string sqlstr="delete tb_supplyer where SUID="+dgview.SelectedRows[0].Cells[0].Value.ToString();
                    if(conn.ExecuteSql(sqlstr)){
                        MessageBox.Show("删除成功!");
                        this.reload();
                    }else
                    {
                        MessageBox.Show("删除失败!");
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个记录!");
            }

        }
    }
}