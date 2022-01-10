namespace 物流管理系统
{
    partial class frm_deluser
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
            this.lst_users = new System.Windows.Forms.ListBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_users
            // 
            this.lst_users.FormattingEnabled = true;
            this.lst_users.ItemHeight = 12;
            this.lst_users.Location = new System.Drawing.Point(12, 12);
            this.lst_users.Name = "lst_users";
            this.lst_users.Size = new System.Drawing.Size(120, 136);
            this.lst_users.TabIndex = 0;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(164, 12);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 1;
            this.btn_del.Text = "删除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // frm_deluser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 163);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.lst_users);
            this.Name = "frm_deluser";
            this.Text = "删除用户";
            this.Load += new System.EventHandler(this.frm_deluser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_users;
        private System.Windows.Forms.Button btn_del;
    }
}