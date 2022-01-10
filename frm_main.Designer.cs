namespace 物流管理系统
{
    partial class frm_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.TSMI_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_GOODSIN = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_GOODSOUT = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_QG = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_QI = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_QO = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_C = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_GM = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_STORES = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SUPPLYER = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MODPWD = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_USERMGR = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ADDUSER = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MODUSER = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DELUSER = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_RELOGIN = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_EDIT = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.st_time1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_1,
            this.TSMI_2,
            this.TSMI_3,
            this.TSMI_4});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(891, 25);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // TSMI_1
            // 
            this.TSMI_1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_GOODSIN,
            this.TSMI_GOODSOUT});
            this.TSMI_1.Name = "TSMI_1";
            this.TSMI_1.Size = new System.Drawing.Size(83, 21);
            this.TSMI_1.Text = "货物管理(&T)";
            // 
            // TSMI_GOODSIN
            // 
            this.TSMI_GOODSIN.Name = "TSMI_GOODSIN";
            this.TSMI_GOODSIN.Size = new System.Drawing.Size(142, 22);
            this.TSMI_GOODSIN.Text = "入库操作(&I)";
            this.TSMI_GOODSIN.Click += new System.EventHandler(this.TSMI_GOODSIN_Click);
            // 
            // TSMI_GOODSOUT
            // 
            this.TSMI_GOODSOUT.Name = "TSMI_GOODSOUT";
            this.TSMI_GOODSOUT.Size = new System.Drawing.Size(142, 22);
            this.TSMI_GOODSOUT.Text = "出库操作(&O)";
            this.TSMI_GOODSOUT.Click += new System.EventHandler(this.TSMI_GOODSOUT_Click);
            // 
            // TSMI_2
            // 
            this.TSMI_2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_QG,
            this.TSMI_QI,
            this.TSMI_QO,
            this.TSMI_C});
            this.TSMI_2.Name = "TSMI_2";
            this.TSMI_2.Size = new System.Drawing.Size(86, 21);
            this.TSMI_2.Text = "货物查询(&Q)";
            // 
            // TSMI_QG
            // 
            this.TSMI_QG.Name = "TSMI_QG";
            this.TSMI_QG.Size = new System.Drawing.Size(164, 22);
            this.TSMI_QG.Text = "物流查询(&S)";
            this.TSMI_QG.Click += new System.EventHandler(this.TSMI_QG_Click);
            // 
            // TSMI_QI
            // 
            this.TSMI_QI.Name = "TSMI_QI";
            this.TSMI_QI.Size = new System.Drawing.Size(164, 22);
            this.TSMI_QI.Text = "入库查询(&I)";
            this.TSMI_QI.Click += new System.EventHandler(this.TSMI_QI_Click);
            // 
            // TSMI_QO
            // 
            this.TSMI_QO.Name = "TSMI_QO";
            this.TSMI_QO.Size = new System.Drawing.Size(164, 22);
            this.TSMI_QO.Text = "出库查询(&O)";
            this.TSMI_QO.Click += new System.EventHandler(this.TSMI_QO_Click);
            // 
            // TSMI_C
            // 
            this.TSMI_C.Name = "TSMI_C";
            this.TSMI_C.Size = new System.Drawing.Size(164, 22);
            this.TSMI_C.Text = "物流警报查询(&C)";
            this.TSMI_C.Click += new System.EventHandler(this.TSMI_C_Click);
            // 
            // TSMI_3
            // 
            this.TSMI_3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_GM,
            this.TSMI_STORES,
            this.TSMI_SUPPLYER});
            this.TSMI_3.Name = "TSMI_3";
            this.TSMI_3.Size = new System.Drawing.Size(83, 21);
            this.TSMI_3.Text = "档案管理(&T)";
            // 
            // TSMI_GM
            // 
            this.TSMI_GM.Name = "TSMI_GM";
            this.TSMI_GM.Size = new System.Drawing.Size(153, 22);
            this.TSMI_GM.Text = "货物管理(&G)";
            this.TSMI_GM.Click += new System.EventHandler(this.TSMI_GM_Click);
            // 
            // TSMI_STORES
            // 
            this.TSMI_STORES.Name = "TSMI_STORES";
            this.TSMI_STORES.Size = new System.Drawing.Size(153, 22);
            this.TSMI_STORES.Text = "仓库管理(&S)";
            this.TSMI_STORES.Click += new System.EventHandler(this.TSMI_STORES_Click);
            // 
            // TSMI_SUPPLYER
            // 
            this.TSMI_SUPPLYER.Name = "TSMI_SUPPLYER";
            this.TSMI_SUPPLYER.Size = new System.Drawing.Size(153, 22);
            this.TSMI_SUPPLYER.Text = "供应商管理(&U)";
            this.TSMI_SUPPLYER.Click += new System.EventHandler(this.TSMI_SUPPLYER_Click);
            // 
            // TSMI_4
            // 
            this.TSMI_4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_MODPWD,
            this.TSMI_USERMGR,
            this.toolStripMenuItem2,
            this.TSMI_RELOGIN,
            this.TSMI_EDIT});
            this.TSMI_4.Name = "TSMI_4";
            this.TSMI_4.Size = new System.Drawing.Size(83, 21);
            this.TSMI_4.Text = "系统设置(&S)";
            // 
            // TSMI_MODPWD
            // 
            this.TSMI_MODPWD.Name = "TSMI_MODPWD";
            this.TSMI_MODPWD.Size = new System.Drawing.Size(153, 22);
            this.TSMI_MODPWD.Text = "修改密码(&M)";
            this.TSMI_MODPWD.Click += new System.EventHandler(this.TSMI_MODPWD_Click);
            // 
            // TSMI_USERMGR
            // 
            this.TSMI_USERMGR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ADDUSER,
            this.TSMI_MODUSER,
            this.TSMI_DELUSER});
            this.TSMI_USERMGR.Name = "TSMI_USERMGR";
            this.TSMI_USERMGR.Size = new System.Drawing.Size(153, 22);
            this.TSMI_USERMGR.Text = "用户管理(&G)";
            // 
            // TSMI_ADDUSER
            // 
            this.TSMI_ADDUSER.Name = "TSMI_ADDUSER";
            this.TSMI_ADDUSER.Size = new System.Drawing.Size(144, 22);
            this.TSMI_ADDUSER.Text = "添加用户(&A)";
            this.TSMI_ADDUSER.Click += new System.EventHandler(this.TSMI_ADDUSER_Click);
            // 
            // TSMI_MODUSER
            // 
            this.TSMI_MODUSER.Name = "TSMI_MODUSER";
            this.TSMI_MODUSER.Size = new System.Drawing.Size(144, 22);
            this.TSMI_MODUSER.Text = "修改用户(&M)";
            this.TSMI_MODUSER.Click += new System.EventHandler(this.TSMI_MOD_Click);
            // 
            // TSMI_DELUSER
            // 
            this.TSMI_DELUSER.Name = "TSMI_DELUSER";
            this.TSMI_DELUSER.Size = new System.Drawing.Size(144, 22);
            this.TSMI_DELUSER.Text = "删除用户(&D)";
            this.TSMI_DELUSER.Click += new System.EventHandler(this.TSMI_DELUSER_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 6);
            // 
            // TSMI_RELOGIN
            // 
            this.TSMI_RELOGIN.Name = "TSMI_RELOGIN";
            this.TSMI_RELOGIN.Size = new System.Drawing.Size(153, 22);
            this.TSMI_RELOGIN.Text = "重新登陆(&R)";
            this.TSMI_RELOGIN.Click += new System.EventHandler(this.TSMI_RELOGIN_Click);
            // 
            // TSMI_EDIT
            // 
            this.TSMI_EDIT.Name = "TSMI_EDIT";
            this.TSMI_EDIT.Size = new System.Drawing.Size(153, 22);
            this.TSMI_EDIT.Text = "退出系统(&E)";
            this.TSMI_EDIT.Click += new System.EventHandler(this.TSMI_EDIT_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.st_time1});
            this.status.Location = new System.Drawing.Point(0, 591);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(891, 22);
            this.status.TabIndex = 3;
            this.status.Text = "statusStrip1";
            // 
            // st_time1
            // 
            this.st_time1.AutoSize = false;
            this.st_time1.Name = "st_time1";
            this.st_time1.Size = new System.Drawing.Size(120, 17);
            // 
            // tools
            // 
            this.tools.Location = new System.Drawing.Point(0, 25);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(891, 25);
            this.tools.TabIndex = 4;
            this.tools.Text = "toolStrip1";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 613);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物流管理系统";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem TSMI_4;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel st_time1;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ADDUSER;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MODUSER;
        private System.Windows.Forms.ToolStripMenuItem TSMI_1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_GOODSIN;
        private System.Windows.Forms.ToolStripMenuItem TSMI_GOODSOUT;
        private System.Windows.Forms.ToolStripMenuItem TSMI_2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_QG;
        private System.Windows.Forms.ToolStripMenuItem TSMI_QI;
        private System.Windows.Forms.ToolStripMenuItem TSMI_QO;
        private System.Windows.Forms.ToolStripMenuItem TSMI_3;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SUPPLYER;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_RELOGIN;
        private System.Windows.Forms.ToolStripMenuItem TSMI_EDIT;
        private System.Windows.Forms.ToolStripMenuItem TSMI_GM;
        private System.Windows.Forms.ToolStripMenuItem TSMI_STORES;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MODPWD;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DELUSER;
        public System.Windows.Forms.ToolStripMenuItem TSMI_USERMGR;
        private System.Windows.Forms.ToolStripMenuItem TSMI_C;
    }
}

