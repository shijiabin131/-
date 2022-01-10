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
    public partial class frm_outgoods : Form
    {
        public frm_outgoods()
        {
            InitializeComponent();
        }
        public void reload()
        {
            string sqlstr = "select GID as 序号,Gname as 商品名称,Sname as 仓库名称,Gstyle as 规格,Gunit as 单位,Gcount as 数量,Gprice as 单价,Gsum as 总价,Gcordon as 警戒线,Geditime as 编辑日期,Gremarks as 备注 from tb_goods  where Gname like '%" + txt_Gname.Text + "%' and Sname like '%" + txt_Sname.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, sql.getconnstr());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgview.DataSource = dt;
        }

        private void frm_outgoods_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void dgview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_GID.Text = dgview[0, dgview.CurrentCell.RowIndex].Value.ToString();
            txt_IGname.Text = dgview[1, dgview.CurrentCell.RowIndex].Value.ToString();
            txt_OSname.Text = dgview[2, dgview.CurrentCell.RowIndex].Value.ToString();
            txt_Gstyle.Text = dgview[3, dgview.CurrentCell.RowIndex].Value.ToString();
            txt_Gunit.Text = dgview[4, dgview.CurrentCell.RowIndex].Value.ToString();
            //数量 txt_GID.Text = dgview[5, dgview.CurrentCell.RowIndex].Value.ToString();
            txt_Gprice.Text = dgview[6, dgview.CurrentCell.RowIndex].Value.ToString();
            //警戒线txt_Gsum.Text = dgview[7, dgview.CurrentCell.RowIndex].Value.ToString();
            //编辑txt_GID.Text = dgview[8, dgview.CurrentCell.RowIndex].Value.ToString();
            //dtp_intime.Value = Convert.ToDateTime(dgview[9, dgview.CurrentCell.RowIndex].Value.ToString());
            //txt_GID.Text = dgview[9, dgview.CurrentCell.RowIndex].Value.ToString();
            //txt_GID.Text = dgview[10, dgview.CurrentCell.RowIndex].Value.ToString();
            txt_Gsum.Text = "0";
            
            if (txt_INcount.Text != ""){
            txt_Gsum.Text = Convert.ToString(Convert.ToDouble(txt_INcount.Text) * Convert.ToDouble(txt_Gprice.Text));
            }
        }

        private void txt_INcount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_INcount_TextChanged(object sender, EventArgs e)
        {
            if (txt_Gsum.Text == "")
            {
                MessageBox.Show("请选择需要出库的商品!");
                return;
            }
            txt_Gsum.Text = Convert.ToString(Convert.ToDouble(txt_INcount.Text) * Convert.ToDouble(txt_Gprice.Text));
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_INcount.Text =="" || txt_INpeople.Text =="" || txt_INremarks.Text=="" || txt_Ounit.Text==""){
                MessageBox.Show("请填写完整信息!");
            }
            if (txt_Gsum.Text == "0")
            {
                MessageBox.Show("请填写完整信息!");
                return;
            }
            sql conn = new sql();
            string sqlstr = "insert into tb_outgoods(Gname,SUname,Gstyle,Gunit,OUTcount,OUTprice,OUTsum,OUTtime,OUTunit,OUTpeople,OUTremarks) values('" + txt_IGname.Text
                + "','" + txt_Sname.Text + "','" + txt_Gstyle.Text + "','" + txt_Gunit.Text + "'," + txt_INcount.Text + "," + txt_Gprice.Text + "," + txt_Gsum.Text + ",'"
                + dtp_intime.Value.ToString() + "','" +txt_Ounit.Text +"','" + txt_INpeople.Text + "','" + txt_INremarks.Text + "')";
            //txt_INremarks.Text = sqlstr;
            if (conn.ExecuteSql(sqlstr))
            {
                MessageBox.Show("出库成功!");
                string sqlstr2 = "update tb_goods set Gcount=Gcount-" + txt_INcount.Text + ",Gsum=(Gcount-" + txt_INcount.Text + ")*Gprice,Geditime=getdate() where GID=" + txt_GID.Text;
                //txt_INremarks.Text = sqlstr2;
                conn.ExecuteSql(sqlstr2);
                this.reload();
                //向货物表中更新数据
            }
            else
            {
                MessageBox.Show("出库失败!");
            }
        }
    }
}