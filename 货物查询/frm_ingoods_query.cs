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
    public partial class frm_ingoods_query : Form
    {
        public frm_ingoods_query()
        {
            InitializeComponent();
        }

        public void reload()
        {
            string sqlstr = "select IGID as 序号,Gname as 商品名称,SUname as 仓库名称,Gstyle as 规格,Gunit as 单位,INcount as 数量,Gprice as 单价,Gsum as 总价,INtime as 编辑日期,INpeople as 经手人,INremarks as 备注 from tb_ingoods  where Gname like '%" + txt_Gname.Text + "%' and SUname like '%" + txt_Sname.Text + "%'";
            //MessageBox.Show(sqlstr);

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, sql.getconnstr());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgview.DataSource = dt;
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_ingoods_query_Load(object sender, EventArgs e)
        {
            reload();
        }
    }
}