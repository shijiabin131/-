namespace 物流管理系统
{
    partial class frm_outgoods
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_query = new System.Windows.Forms.Button();
            this.txt_Sname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Gname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_GID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_INremarks = new System.Windows.Forms.TextBox();
            this.txt_INpeople = new System.Windows.Forms.TextBox();
            this.dtp_intime = new System.Windows.Forms.DateTimePicker();
            this.txt_Gsum = new System.Windows.Forms.TextBox();
            this.txt_Gprice = new System.Windows.Forms.TextBox();
            this.txt_INcount = new System.Windows.Forms.TextBox();
            this.txt_Gunit = new System.Windows.Forms.TextBox();
            this.txt_Gstyle = new System.Windows.Forms.TextBox();
            this.txt_IGname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgview = new System.Windows.Forms.DataGridView();
            this.txt_OSname = new System.Windows.Forms.TextBox();
            this.lable4 = new System.Windows.Forms.Label();
            this.txt_Ounit = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_query);
            this.groupBox3.Controls.Add(this.txt_Sname);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_Gname);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(455, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 186);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询";
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(55, 117);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(146, 53);
            this.btn_query.TabIndex = 4;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // txt_Sname
            // 
            this.txt_Sname.Location = new System.Drawing.Point(98, 71);
            this.txt_Sname.Name = "txt_Sname";
            this.txt_Sname.Size = new System.Drawing.Size(122, 21);
            this.txt_Sname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "仓库名称：";
            // 
            // txt_Gname
            // 
            this.txt_Gname.Location = new System.Drawing.Point(98, 35);
            this.txt_Gname.Name = "txt_Gname";
            this.txt_Gname.Size = new System.Drawing.Size(122, 21);
            this.txt_Gname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "货物名称：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Ounit);
            this.groupBox2.Controls.Add(this.lable4);
            this.groupBox2.Controls.Add(this.txt_OSname);
            this.groupBox2.Controls.Add(this.txt_GID);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.txt_INremarks);
            this.groupBox2.Controls.Add(this.txt_INpeople);
            this.groupBox2.Controls.Add(this.dtp_intime);
            this.groupBox2.Controls.Add(this.txt_Gsum);
            this.groupBox2.Controls.Add(this.txt_Gprice);
            this.groupBox2.Controls.Add(this.txt_INcount);
            this.groupBox2.Controls.Add(this.txt_Gunit);
            this.groupBox2.Controls.Add(this.txt_Gstyle);
            this.groupBox2.Controls.Add(this.txt_IGname);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 207);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出库信息";
            // 
            // txt_GID
            // 
            this.txt_GID.Location = new System.Drawing.Point(587, 28);
            this.txt_GID.Name = "txt_GID";
            this.txt_GID.ReadOnly = true;
            this.txt_GID.Size = new System.Drawing.Size(73, 21);
            this.txt_GID.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(551, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 23;
            this.label14.Text = "序号：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_close);
            this.groupBox4.Controls.Add(this.btn_add);
            this.groupBox4.Location = new System.Drawing.Point(564, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(114, 121);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "操作";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(21, 71);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 36);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "取消";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(21, 24);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 33);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "出库";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_INremarks
            // 
            this.txt_INremarks.Location = new System.Drawing.Point(358, 135);
            this.txt_INremarks.Multiline = true;
            this.txt_INremarks.Name = "txt_INremarks";
            this.txt_INremarks.Size = new System.Drawing.Size(182, 48);
            this.txt_INremarks.TabIndex = 21;
            // 
            // txt_INpeople
            // 
            this.txt_INpeople.Location = new System.Drawing.Point(358, 81);
            this.txt_INpeople.Name = "txt_INpeople";
            this.txt_INpeople.Size = new System.Drawing.Size(100, 21);
            this.txt_INpeople.TabIndex = 20;
            // 
            // dtp_intime
            // 
            this.dtp_intime.Location = new System.Drawing.Point(358, 108);
            this.dtp_intime.Name = "dtp_intime";
            this.dtp_intime.Size = new System.Drawing.Size(182, 21);
            this.dtp_intime.TabIndex = 19;
            // 
            // txt_Gsum
            // 
            this.txt_Gsum.Location = new System.Drawing.Point(358, 55);
            this.txt_Gsum.Name = "txt_Gsum";
            this.txt_Gsum.ReadOnly = true;
            this.txt_Gsum.Size = new System.Drawing.Size(100, 21);
            this.txt_Gsum.TabIndex = 18;
            // 
            // txt_Gprice
            // 
            this.txt_Gprice.Location = new System.Drawing.Point(358, 28);
            this.txt_Gprice.Name = "txt_Gprice";
            this.txt_Gprice.ReadOnly = true;
            this.txt_Gprice.Size = new System.Drawing.Size(100, 21);
            this.txt_Gprice.TabIndex = 17;
            // 
            // txt_INcount
            // 
            this.txt_INcount.Location = new System.Drawing.Point(116, 137);
            this.txt_INcount.Name = "txt_INcount";
            this.txt_INcount.Size = new System.Drawing.Size(100, 21);
            this.txt_INcount.TabIndex = 16;
            this.txt_INcount.TextChanged += new System.EventHandler(this.txt_INcount_TextChanged);
            this.txt_INcount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_INcount_KeyPress);
            // 
            // txt_Gunit
            // 
            this.txt_Gunit.Location = new System.Drawing.Point(116, 110);
            this.txt_Gunit.Name = "txt_Gunit";
            this.txt_Gunit.ReadOnly = true;
            this.txt_Gunit.Size = new System.Drawing.Size(100, 21);
            this.txt_Gunit.TabIndex = 15;
            // 
            // txt_Gstyle
            // 
            this.txt_Gstyle.Location = new System.Drawing.Point(116, 83);
            this.txt_Gstyle.Name = "txt_Gstyle";
            this.txt_Gstyle.ReadOnly = true;
            this.txt_Gstyle.Size = new System.Drawing.Size(100, 21);
            this.txt_Gstyle.TabIndex = 14;
            // 
            // txt_IGname
            // 
            this.txt_IGname.Location = new System.Drawing.Point(116, 29);
            this.txt_IGname.Name = "txt_IGname";
            this.txt_IGname.ReadOnly = true;
            this.txt_IGname.Size = new System.Drawing.Size(100, 21);
            this.txt_IGname.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(311, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "备注：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(299, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "经收人：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "出库日期：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(311, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "总价：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "单价：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "进货数量：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "货物单位：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "货物规格：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "仓库名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "货品名称：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgview);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 186);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "货品信息";
            // 
            // dgview
            // 
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.Location = new System.Drawing.Point(16, 20);
            this.dgview.Name = "dgview";
            this.dgview.RowTemplate.Height = 23;
            this.dgview.Size = new System.Drawing.Size(406, 150);
            this.dgview.TabIndex = 1;
            this.dgview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_CellClick);
            // 
            // txt_OSname
            // 
            this.txt_OSname.Location = new System.Drawing.Point(116, 56);
            this.txt_OSname.Name = "txt_OSname";
            this.txt_OSname.ReadOnly = true;
            this.txt_OSname.Size = new System.Drawing.Size(100, 21);
            this.txt_OSname.TabIndex = 9;
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Location = new System.Drawing.Point(38, 167);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(65, 12);
            this.lable4.TabIndex = 25;
            this.lable4.Text = "出库单位：";
            // 
            // txt_Ounit
            // 
            this.txt_Ounit.Location = new System.Drawing.Point(116, 164);
            this.txt_Ounit.Name = "txt_Ounit";
            this.txt_Ounit.Size = new System.Drawing.Size(100, 21);
            this.txt_Ounit.TabIndex = 26;
            // 
            // frm_outgoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 426);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_outgoods";
            this.Text = "出库操作";
            this.Load += new System.EventHandler(this.frm_outgoods_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.TextBox txt_Sname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Gname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_GID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_INremarks;
        private System.Windows.Forms.TextBox txt_INpeople;
        private System.Windows.Forms.DateTimePicker dtp_intime;
        private System.Windows.Forms.TextBox txt_Gsum;
        private System.Windows.Forms.TextBox txt_Gprice;
        private System.Windows.Forms.TextBox txt_INcount;
        private System.Windows.Forms.TextBox txt_Gunit;
        private System.Windows.Forms.TextBox txt_Gstyle;
        private System.Windows.Forms.TextBox txt_IGname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgview;
        private System.Windows.Forms.TextBox txt_OSname;
        private System.Windows.Forms.TextBox txt_Ounit;
        private System.Windows.Forms.Label lable4;
    }
}