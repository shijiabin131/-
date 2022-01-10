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
    public partial class frm_stores : Form
    {
        public frm_stores()
        {
            InitializeComponent();
        }

        public void reload()
        {
            string sqlstr = "select SID as 序号,Sname as 仓库名称,Speople as 负责人,Stel as 联系电话,Sunit as 所属单位,Sremarks as 备注 from tb_stores";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, sql.getconnstr());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgview.DataSource = dt;
        }

        private void frm_stores_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_stores_add frm = new frm_stores_add(this);
            frm.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgview.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认是否删除?", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string sqlstr = "delete tb_stores where SID=" + dgview.SelectedRows[0].Cells[0].Value.ToString();
                    sql conn = new sql();
                    if (conn.ExecuteSql(sqlstr))
                    {
                        MessageBox.Show("删除成功!");
                        this.reload();
                    }
                    else
                    {
                        MessageBox.Show("删除失败!");
                    }
                }
            }
            else {
                MessageBox.Show("请选择一条记录!");
            }
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            if (dgview.SelectedRows.Count > 0)
            {
                frm_stores_mod frm = new frm_stores_mod(this);
                frm.txt_sid.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                frm.txt_Sname.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                frm.txt_Speople.Text = dgview.SelectedRows[0].Cells[2].Value.ToString();
                frm.txt_Stel.Text = dgview.SelectedRows[0].Cells[3].Value.ToString();
                frm.Txt_Sunit.Text = dgview.SelectedRows[0].Cells[4].Value.ToString();
                frm.txt_Sremarks.Text = dgview.SelectedRows[0].Cells[5].Value.ToString();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择一条记录!");
            }
        }
    }
}