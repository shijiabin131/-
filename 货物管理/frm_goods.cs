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
    public partial class frm_goods : Form
    {
        public frm_goods()
        {
            InitializeComponent();
        }

        public void reload(){
            string sqlstr = "select GID as 序号,Gname as 商品名称,Sname as 仓库名称,Gstyle as 规格,Gunit as 单位,Gcount as 数量,Gprice as 单价,Gsum as 总价,Gcordon as 警戒线,Geditime as 编辑日期,Gremarks as 备注 from tb_goods  where Gname like '%" + txt_Gname.Text + "%' and Sname like '%" + txt_Sname.Text + "%'";
            //MessageBox.Show(sqlstr);

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
            frm_goods_add frm = new frm_goods_add(this);
            frm.ShowDialog();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            if (dgview.SelectedRows.Count > 0)
            {
                frm_goods_mod frm = new frm_goods_mod(this);
                frm.txt_GID.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                frm.txt_Gname.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                frm.cmb_Sname.Text = dgview.SelectedRows[0].Cells[2].Value.ToString();
                frm.txt_Gsytle.Text = dgview.SelectedRows[0].Cells[3].Value.ToString();
                frm.txt_Gunit.Text = dgview.SelectedRows[0].Cells[4].Value.ToString();
                frm.txt_Gcount.Text = dgview.SelectedRows[0].Cells[5].Value.ToString();
                frm.txt_Gprice.Text = dgview.SelectedRows[0].Cells[6].Value.ToString();
                frm.txt_Gsum.Text = dgview.SelectedRows[0].Cells[7].Value.ToString();
                frm.txt_Gcordon.Text = dgview.SelectedRows[0].Cells[8].Value.ToString();
                //MessageBox.Show(dgview.SelectedRows[0].Cells[8].Value.ToString());
                frm.dtp_Geditime.Value =Convert.ToDateTime(dgview.SelectedRows[0].Cells[9].Value.ToString());
                frm.txt_Gremarks.Text = dgview.SelectedRows[0].Cells[10].Value.ToString();
                frm.ShowDialog();
            }
            else {
                MessageBox.Show("请选择一条记录!");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dgview.SelectedRows.Count > 0) {
                if (MessageBox.Show("确认是否删除?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    sql conn = new sql();
                    string sqlstr = "delete tb_goods where GID=" + dgview.SelectedRows[0].Cells[0].Value.ToString();
                    if (conn.ExecuteSql(sqlstr))
                    {
                        MessageBox.Show("删除成功!");
                        this.reload();
                    }
                    else {
                        MessageBox.Show("删除失败!");
                    }
                }



            } else {
                MessageBox.Show("请选择一条记录!");
            };
        }
    }
}