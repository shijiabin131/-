namespace 物流管理系统
{
    partial class frm_goods_add
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(411, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "货物信息";
            // 
            // cmb_Sname
            // 
            this.cmb_Sname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Sname.FormattingEnabled = true;
            this.cmb_Sname.Location = new System.Drawing.Point(105, 53);
            this.cmb_Sname.Name = "cmb_Sname";
            this.cmb_Sname.Size = new System.Drawing.Size(146, 20);
            this.cmb_Sname.TabIndex = 2;
            // 
            // dtp_Geditime
            // 
            this.dtp_Geditime.CustomFormat = "";
            this.dtp_Geditime.Location = new System.Drawing.Point(105, 242);
            this.dtp_Geditime.Name = "dtp_Geditime";
            this.dtp_Geditime.Size = new System.Drawing.Size(200, 21);
            this.dtp_Geditime.TabIndex = 9;
            this.dtp_Geditime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_Gremarks
            // 
            this.txt_Gremarks.Location = new System.Drawing.Point(105, 268);
            this.txt_Gremarks.Multiline = true;
            this.txt_Gremarks.Name = "txt_Gremarks";
            this.txt_Gremarks.Size = new System.Drawing.Size(261, 84);
            this.txt_Gremarks.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "备注：";
            // 
            // txt_Gcordon
            // 
            this.txt_Gcordon.Location = new System.Drawing.Point(105, 215);
            this.txt_Gcordon.Name = "txt_Gcordon";
            this.txt_Gcordon.Size = new System.Drawing.Size(146, 21);
            this.txt_Gcordon.TabIndex = 8;
            // 
            // txt_Gsum
            // 
            this.txt_Gsum.Location = new System.Drawing.Point(105, 188);
            this.txt_Gsum.Name = "txt_Gsum";
            this.txt_Gsum.Size = new System.Drawing.Size(146, 21);
            this.txt_Gsum.TabIndex = 7;
            // 
            // txt_Gprice
            // 
            this.txt_Gprice.Location = new System.Drawing.Point(105, 161);
            this.txt_Gprice.Name = "txt_Gprice";
            this.txt_Gprice.Size = new System.Drawing.Size(146, 21);
            this.txt_Gprice.TabIndex = 6;
            // 
            // txt_Gcount
            // 
            this.txt_Gcount.Location = new System.Drawing.Point(105, 134);
            this.txt_Gcount.Name = "txt_Gcount";
            this.txt_Gcount.Size = new System.Drawing.Size(146, 21);
            this.txt_Gcount.TabIndex = 5;
            // 
            // txt_Gunit
            // 
            this.txt_Gunit.Location = new System.Drawing.Point(105, 107);
            this.txt_Gunit.Name = "txt_Gunit";
            this.txt_Gunit.Size = new System.Drawing.Size(146, 21);
            this.txt_Gunit.TabIndex = 4;
            // 
            // txt_Gsytle
            // 
            this.txt_Gsytle.Location = new System.Drawing.Point(105, 80);
            this.txt_Gsytle.Name = "txt_Gsytle";
            this.txt_Gsytle.Size = new System.Drawing.Size(146, 21);
            this.txt_Gsytle.TabIndex = 3;
            // 
            // txt_Gname
            // 
            this.txt_Gname.Location = new System.Drawing.Point(105, 29);
            this.txt_Gname.Name = "txt_Gname";
            this.txt_Gname.Size = new System.Drawing.Size(146, 21);
            this.txt_Gname.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "编辑日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "警戒线：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "总价：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "单价：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "数量：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "单位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "规格：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "仓库名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "货物名称：";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(251, 396);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 11;
            this.btn_ok.Text = "添加";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(332, 396);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 12;
            this.btn_close.Text = "取消";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frm_goods_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 434);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_goods_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加货物";
            this.Load += new System.EventHandler(this.frm_goods_add_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Gremarks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Gcordon;
        private System.Windows.Forms.TextBox txt_Gsum;
        private System.Windows.Forms.TextBox txt_Gprice;
        private System.Windows.Forms.TextBox txt_Gcount;
        private System.Windows.Forms.TextBox txt_Gunit;
        private System.Windows.Forms.TextBox txt_Gsytle;
        private System.Windows.Forms.TextBox txt_Gname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cmb_Sname;
        private System.Windows.Forms.DateTimePicker dtp_Geditime;
    }
}