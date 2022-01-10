namespace 物流管理系统
{
    partial class frm_stores_mod
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
            this.txt_Sremarks = new System.Windows.Forms.TextBox();
            this.Txt_Sunit = new System.Windows.Forms.TextBox();
            this.txt_Stel = new System.Windows.Forms.TextBox();
            this.txt_Speople = new System.Windows.Forms.TextBox();
            this.txt_Sname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sid = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(205, 288);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "取消";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(119, 288);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 9;
            this.btn_ok.Text = "修改";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_sid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Sremarks);
            this.groupBox1.Controls.Add(this.Txt_Sunit);
            this.groupBox1.Controls.Add(this.txt_Stel);
            this.groupBox1.Controls.Add(this.txt_Speople);
            this.groupBox1.Controls.Add(this.txt_Sname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 259);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "仓库信息";
            // 
            // txt_Sremarks
            // 
            this.txt_Sremarks.Location = new System.Drawing.Point(107, 160);
            this.txt_Sremarks.Multiline = true;
            this.txt_Sremarks.Name = "txt_Sremarks";
            this.txt_Sremarks.Size = new System.Drawing.Size(126, 81);
            this.txt_Sremarks.TabIndex = 5;
            // 
            // Txt_Sunit
            // 
            this.Txt_Sunit.Location = new System.Drawing.Point(107, 133);
            this.Txt_Sunit.Name = "Txt_Sunit";
            this.Txt_Sunit.Size = new System.Drawing.Size(126, 21);
            this.Txt_Sunit.TabIndex = 4;
            // 
            // txt_Stel
            // 
            this.txt_Stel.Location = new System.Drawing.Point(107, 106);
            this.txt_Stel.Name = "txt_Stel";
            this.txt_Stel.Size = new System.Drawing.Size(126, 21);
            this.txt_Stel.TabIndex = 3;
            // 
            // txt_Speople
            // 
            this.txt_Speople.Location = new System.Drawing.Point(107, 79);
            this.txt_Speople.Name = "txt_Speople";
            this.txt_Speople.Size = new System.Drawing.Size(126, 21);
            this.txt_Speople.TabIndex = 2;
            // 
            // txt_Sname
            // 
            this.txt_Sname.Location = new System.Drawing.Point(107, 53);
            this.txt_Sname.Name = "txt_Sname";
            this.txt_Sname.Size = new System.Drawing.Size(126, 21);
            this.txt_Sname.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "备注：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "所属单位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "联系电话：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "负责人：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库名称：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "序号：";
            // 
            // txt_sid
            // 
            this.txt_sid.Location = new System.Drawing.Point(107, 26);
            this.txt_sid.Name = "txt_sid";
            this.txt_sid.ReadOnly = true;
            this.txt_sid.Size = new System.Drawing.Size(126, 21);
            this.txt_sid.TabIndex = 7;
            // 
            // frm_stores_mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 322);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_stores_mod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改仓库";
            this.Load += new System.EventHandler(this.frm_stores_mod_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_sid;
        public System.Windows.Forms.TextBox txt_Sremarks;
        public System.Windows.Forms.TextBox Txt_Sunit;
        public System.Windows.Forms.TextBox txt_Stel;
        public System.Windows.Forms.TextBox txt_Speople;
        public System.Windows.Forms.TextBox txt_Sname;
    }
}