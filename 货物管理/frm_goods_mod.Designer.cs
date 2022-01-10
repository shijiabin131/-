namespace 物流管理系统
{
    partial class frm_goods_mod
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
            this.cmb_Sname = new System.Windows.Forms.ComboBox();
            this.dtp_Geditime = new System.Windows.Forms.DateTimePicker();
            this.txt_Gremarks = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Gcordon = new System.Windows.Forms.TextBox();
            this.txt_Gsum = new System.Windows.Forms.TextBox();
            this.txt_Gprice = new System.Windows.Forms.TextBox();
            this.txt_Gcount = new System.Windows.Forms.TextBox();
            this.txt_Gunit = new System.Windows.Forms.TextBox();
            this.txt_Gsytle = new System.Windows.Forms.TextBox();
            this.txt_Gname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_GID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(332, 447);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "取消";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(251, 447);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "修改";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_GID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmb_Sname);
            this.groupBox1.Controls.Add(this.dtp_Geditime);
            this.groupBox1.Controls.Add(this.txt_Gremarks);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_Gcordon);
            this.groupBox1.Controls.Add(this.txt_Gsum);
            this.groupBox1.Controls.Add(this.txt_Gprice);
            this.groupBox1.Controls.Add(this.txt_Gcount);
            this.groupBox1.Controls.Add(this.txt_Gunit);
            this.groupBox1.Controls.Add(this.txt_Gsytle);
            this.groupBox1.Controls.Add(this.txt_Gname);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 419);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "货物信息";
            // 
            // cmb_Sname
            // 
            this.cmb_Sname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Sname.FormattingEnabled = true;
            this.cmb_Sname.Location = new System.Drawing.Point(114, 89);
            this.cmb_Sname.Name = "cmb_Sname";
            this.cmb_Sname.Size = new System.Drawing.Size(146, 20);
            this.cmb_Sname.TabIndex = 1;
            // 
            // dtp_Geditime
            // 
            this.dtp_Geditime.CustomFormat = "";
            this.dtp_Geditime.Location = new System.Drawing.Point(114, 278);
            this.dtp_Geditime.Name = "dtp_Geditime";
            this.dtp_Geditime.Size = new System.Drawing.Size(200, 21);
            this.dtp_Geditime.TabIndex = 8;
            // 
            // txt_Gremarks
            // 
            this.txt_Gremarks.Location = new System.Drawing.Point(114, 304);
            this.txt_Gremarks.Multiline = true;
            this.txt_Gremarks.Name = "txt_Gremarks";
            this.txt_Gremarks.Size = new System.Drawing.Size(261, 84);
            this.txt_Gremarks.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "备注：";
            // 
            // txt_Gcordon
            // 
            this.txt_Gcordon.Location = new System.Drawing.Point(114, 251);
            this.txt_Gcordon.Name = "txt_Gcordon";
            this.txt_Gcordon.Size = new System.Drawing.Size(146, 21);
            this.txt_Gcordon.TabIndex = 7;
            // 
            // txt_Gsum
            // 
            this.txt_Gsum.Location = new System.Drawing.Point(114, 224);
            this.txt_Gsum.Name = "txt_Gsum";
            this.txt_Gsum.Size = new System.Drawing.Size(146, 21);
            this.txt_Gsum.TabIndex = 6;
            // 
            // txt_Gprice
            // 
            this.txt_Gprice.Location = new System.Drawing.Point(114, 197);
            this.txt_Gprice.Name = "txt_Gprice";
            this.txt_Gprice.Size = new System.Drawing.Size(146, 21);
            this.txt_Gprice.TabIndex = 5;
            // 
            // txt_Gcount
            // 
            this.txt_Gcount.Location = new System.Drawing.Point(114, 170);
            this.txt_Gcount.Name = "txt_Gcount";
            this.txt_Gcount.Size = new System.Drawing.Size(146, 21);
            this.txt_Gcount.TabIndex = 4;
            // 
            // txt_Gunit
            // 
            this.txt_Gunit.Location = new System.Drawing.Point(114, 143);
            this.txt_Gunit.Name = "txt_Gunit";
            this.txt_Gunit.Size = new System.Drawing.Size(146, 21);
            this.txt_Gunit.TabIndex = 3;
            // 
            // txt_Gsytle
            // 
            this.txt_Gsytle.Location = new System.Drawing.Point(114, 116);
            this.txt_Gsytle.Name = "txt_Gsytle";
            this.txt_Gsytle.Size = new System.Drawing.Size(146, 21);
            this.txt_Gsytle.TabIndex = 2;
            // 
            // txt_Gname
            // 
            this.txt_Gname.Location = new System.Drawing.Point(114, 65);
            this.txt_Gname.Name = "txt_Gname";
            this.txt_Gname.Size = new System.Drawing.Size(146, 21);
            this.txt_Gname.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "编辑日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "警戒线：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "总价：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "单价：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "数量：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "单位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "规格：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "仓库名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "货物名称：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "序号:";
            // 
            // txt_GID
            // 
            this.txt_GID.Location = new System.Drawing.Point(114, 38);
            this.txt_GID.Name = "txt_GID";
            this.txt_GID.ReadOnly = true;
            this.txt_GID.Size = new System.Drawing.Size(146, 21);
            this.txt_GID.TabIndex = 15;
            // 
            // frm_goods_mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 482);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_goods_mod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改商品";
            this.Load += new System.EventHandler(this.frm_goods_mod_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_GID;
        public System.Windows.Forms.ComboBox cmb_Sname;
        public System.Windows.Forms.DateTimePicker dtp_Geditime;
        public System.Windows.Forms.TextBox txt_Gremarks;
        public System.Windows.Forms.TextBox txt_Gcordon;
        public System.Windows.Forms.TextBox txt_Gsum;
        public System.Windows.Forms.TextBox txt_Gprice;
        public System.Windows.Forms.TextBox txt_Gcount;
        public System.Windows.Forms.TextBox txt_Gunit;
        public System.Windows.Forms.TextBox txt_Gsytle;
        public System.Windows.Forms.TextBox txt_Gname;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_ok;
    }
}