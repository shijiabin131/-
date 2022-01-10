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
    public partial class frm_cordon_query : Form
    {
        public frm_cordon_query()
        {
            InitializeComponent();
        }
        public void reload()
        {
            string sqlstr = "select GID as 序号,Gname as 商品名称,Sname as 仓库名称,Gstyle as 规格,Gunit as 单位,Gcount as 数量,Gprice as 单价,Gsum as 总价,Gcordon as 警戒线,Geditime as 编辑日期,Gremarks as 备注 from tb_goods  where Gcount<Gcordon";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, sql.getconnstr());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgview.DataSource = dt;
        }

        private void frm_cordon_query_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void btn_ref_Click(object sender, EventArgs e)
        {
            reload();
        }
    }
}