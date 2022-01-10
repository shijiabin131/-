namespace 物流管理系统
{
    partial class frm_supplyer_mod
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_SUID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SUremarks = new System.Windows.Forms.TextBox();
            this.txt_SUaddress = new System.Windows.Forms.TextBox();
            this.txt_SUtel = new System.Windows.Forms.TextBox();
            this.txt_SUpeople = new System.Windows.Forms.TextBox();
            this.txt_SUname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(241, 294);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "取消";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(160, 294);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "修改";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_SUID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_SUremarks);
            this.groupBox1.Controls.Add(this.txt_SUaddress);
            this.groupBox1.Controls.Add(this.txt_SUtel);
            this.groupBox1.Controls.Add(this.txt_SUpeople);
            this.groupBox1.Controls.Add(this.txt_SUname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 266);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "供应商信息";
            // 
            // txt_SUID
            // 
            this.txt_SUID.Location = new System.Drawing.Point(122, 36);
            this.txt_SUID.Name = "txt_SUID";
            this.txt_SUID.ReadOnly = true;
            this.txt_SUID.Size = new System.Drawing.Size(154, 21);
            this.txt_SUID.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "序号：";
            // 
            // txt_SUremarks
            // 
            this.txt_SUremarks.Location = new System.Drawing.Point(122, 171);
            this.txt_SUremarks.Multiline = true;
            this.txt_SUremarks.Name = "txt_SUremarks";
            this.txt_SUremarks.Size = new System.Drawing.Size(154, 68);
            this.txt_SUremarks.TabIndex = 9;
            // 
            // txt_SUaddress
            // 
            this.txt_SUaddress.Location = new System.Drawing.Point(122, 144);
            this.txt_SUaddress.Name = "txt_SUaddress";
            this.txt_SUaddress.Size = new System.Drawing.Size(154, 21);
            this.txt_SUaddress.TabIndex = 8;
            // 
            // txt_SUtel
            // 
            this.txt_SUtel.Location = new System.Drawing.Point(122, 117);
            this.txt_SUtel.Name = "txt_SUtel";
            this.txt_SUtel.Size = new System.Drawing.Size(154, 21);
            this.txt_SUtel.TabIndex = 7;
            // 
            // txt_SUpeople
            // 
            this.txt_SUpeople.Location = new System.Drawing.Point(122, 90);
            this.txt_SUpeople.Name = "txt_SUpeople";
            this.txt_SUpeople.Size = new System.Drawing.Size(154, 21);
            this.txt_SUpeople.TabIndex = 6;
            // 
            // txt_SUname
            // 
            this.txt_SUname.Location = new System.Drawing.Point(122, 63);
            this.txt_SUname.Name = "txt_SUname";
            this.txt_SUname.Size = new System.Drawing.Size(154, 21);
            this.txt_SUname.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "备注：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "详细地址：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "联系电话：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "负责人：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "供应商名称：";
            // 
            // frm_supplyer_mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 333);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_supplyer_mod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改供应商";
            this.Load += new System.EventHandler(this.frm_supplyer_mod_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_SUID;
        public System.Windows.Forms.TextBox txt_SUremarks;
        public System.Windows.Forms.TextBox txt_SUaddress;
        public System.Windows.Forms.TextBox txt_SUtel;
        public System.Windows.Forms.TextBox txt_SUpeople;
        public System.Windows.Forms.TextBox txt_SUname;
    }
}