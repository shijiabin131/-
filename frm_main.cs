using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 物流管理系统
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void MenuItem_about_Click(object sender, EventArgs e)
        {
            frm_about about = new frm_about();
            about.ShowDialog();
        }

        private void timer_gettime_Tick(object sender, EventArgs e)
        {
            st_time1.Text = DateTime.Now.ToString();
        }


        private void frm_main_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login(this);
            login.ShowDialog();
        }

        private void TSMI_DBBAK_Click(object sender, EventArgs e)
        {
           
         
        }

        private void TSMI_REDB_Click(object sender, EventArgs e)
        {
           
           
        }


        private void TSMI_ADDUSER_Click(object sender, EventArgs e)
        {
            frm_adduser adduser = new frm_adduser();
            adduser.MdiParent = this;
            adduser.Show();
        }

        private void TSMI_MOD_Click(object sender, EventArgs e)
        {
            frm_moduser frm = new frm_moduser();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TSMI_RELOGIN_Click(object sender, EventArgs e)
        {
            frm_login frm = new frm_login(this);
            frm.ShowDialog();

        }

        private void TSMI_EDIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TSMI_DELUSER_Click(object sender, EventArgs e)
        {
            frm_deluser frm = new frm_deluser();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TSMI_MODPWD_Click(object sender, EventArgs e)
        {
            frm_repwd frm = new frm_repwd();
            frm.MdiParent = this;
            frm.Show();

        }

        private void TSMI_STORES_Click(object sender, EventArgs e)
        {
            frm_stores frm = new frm_stores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TSMI_SUPPLYER_Click(object sender, EventArgs e)
        {
            frm_supplyer frm = new frm_supplyer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TSMI_GM_Click(object sender, EventArgs e)
        {
            frm_goods frm = new frm_goods();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TSMI_GOODSIN_Click(object sender, EventArgs e)
        {
            frm_ingoods frm = new frm_ingoods();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TSMI_QG_Click(object sender, EventArgs e)
        {
            frm_goods frm = new frm_goods();
            frm.MdiParent=this;
            frm.Show();
        }

        private void TSMI_GOODSOUT_Click(object sender, EventArgs e)
        {
            frm_outgoods frm = new frm_outgoods();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TSMI_QI_Click(object sender, EventArgs e)
        {
            frm_ingoods_query frm = new frm_ingoods_query();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TSMI_QO_Click(object sender, EventArgs e)
        {
            frm_outgoods_query frm = new frm_outgoods_query();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TSMI_C_Click(object sender, EventArgs e)
        {
            frm_cordon_query frm = new frm_cordon_query();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}