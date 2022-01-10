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
    public partial class frm_ingoods : Form
    {
        public frm_ingoods()
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
        
        private void frm_ingoods_Load(object sender, EventArgs e)
        {
            reload();
            //供应商
            sql conn = new sql();
            string sqlstr = "select SUname from tb_supplyer";
            SqlDataReader dr = conn.CreateSqlDataReader(sqlstr);
            while (dr.Read())
            {
                cmb_SUNAME.Items.Add(dr[0]);
            }
            cmb_SUNAME.SelectedIndex = 0;
             //仓库
            //sql conn = new sql();
            //sqlstr = "select Sname from tb_stores";
            //dr = conn.CreateSqlDataReader(sqlstr);
            //while (dr.Read())
            //{
            //    cmb_Sname.Items.Add(dr[0]);
            //}
            //cmb_Sname.SelectedIndex = 0;
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void dgview_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
        }

        private void dgview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_GID.Text = Convert.ToString(dgview[0, dgview.CurrentCell.RowIndex].Value).Trim();
            txt_IGname.Text = Convert.ToString(dgview[1, dgview.CurrentCell.RowIndex].Value).Trim();
            txt_ISnume.Text = Convert.ToString(dgview[2, dgview.CurrentCell.RowIndex].Value).Trim();
            txt_Gstyle.Text = Convert.ToString(dgview[3, dgview.CurrentCell.RowIndex].Value).Trim();
            txt_Gunit.Text = Convert.ToString(dgview[4, dgview.CurrentCell.RowIndex].Value).Trim();
            txt_Gprice.Text =  Convert.ToString(dgview[6, dgview.CurrentCell.RowIndex].Value).Trim();
            //现存总价 Convert.ToString(dgview[6, dgview.CurrentCell.RowIndex].Value).Trim();
            //警戒线 Convert.ToString(dgview[7, dgview.CurrentCell.RowIndex].Value).Trim();
            txt_Gsum.Text = "0";
            //编辑日期 Convert.ToString(dgview[8, dgview.CurrentCell.RowIndex].Value).Trim();
            //备注 Convert.ToString(dgview[9, dgview.CurrentCell.RowIndex].Value).Trim();
            if (txt_INcount.Text!="")
            {
                txt_Gsum.Text = Convert.ToString(Convert.ToDouble(txt_INcount.Text) * Convert.ToDouble(txt_Gprice.Text));
            }
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_INcount.Text =="" || txt_INpeople.Text =="" || dtp_intime.Value.ToString() =="" || txt_INremarks.Text=="")
            {
                MessageBox.Show("请填写完整信息!");
                return;
            }
            if (txt_Gsum.Text=="0")
            {
                MessageBox.Show("请填写完整信息!");
                return;
            }
            sql conn = new sql();
            string sqlstr="insert into tb_ingoods(Gname,SUname,Gstyle,Gunit,INcount,Gprice,Gsum,INtime,INpeople,INremarks) values('"+txt_IGname.Text
                +"','"+txt_ISnume.Text+"','"+txt_Gstyle.Text+"','"+txt_Gunit.Text+"',"+txt_INcount.Text+","+txt_Gprice.Text+","+txt_Gsum.Text+",'"+dtp_intime.Value.ToString()+"','"+txt_INpeople.Text+"','"+txt_INremarks.Text+"')";
            //txt_INremarks.Text = sqlstr;
            if (conn.ExecuteSql(sqlstr))
            {
                MessageBox.Show("入库成功!");
                string sqlstr2="update tb_goods set Gcount=Gcount+"+txt_INcount.Text+",Gsum=(Gcount+"+txt_INcount.Text+")*Gprice,Geditime=getdate() where GID="+txt_GID.Text;
                //txt_INremarks.Text = sqlstr2;
                conn.ExecuteSql(sqlstr2);
                this.reload();
                //向货物表中更新数据
            }else
            {
                MessageBox.Show("入库失败!");
            }
            
        }

        private void txt_INcount_TextChanged(object sender, EventArgs e)
        {
            if (txt_Gsum.Text=="")
            {
                MessageBox.Show("请选择需要进货的商品!");
                return;
            }
            txt_Gsum.Text = Convert.ToString(Convert.ToDouble(txt_INcount.Text) * Convert.ToDouble(txt_Gprice.Text));
        }

        private void txt_INcount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar<48 || e.KeyChar>57)&& e.KeyChar !=8)
            {
                e.Handled = true;
            }
        }
    }
}