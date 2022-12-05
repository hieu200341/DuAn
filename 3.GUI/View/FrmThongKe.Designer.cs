namespace _3.GUI.View
{
    partial class FrmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbb_nam = new System.Windows.Forms.ComboBox();
            this.cbb_thang = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_ngay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgv_show = new System.Windows.Forms.DataGridView();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb_khachhang = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_chuathanhtoan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_tonghd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_doanhthu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clean = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_show)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_sdt);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(785, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(432, 105);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Theo khách hàng";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(198, 45);
            this.tb_sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(196, 27);
            this.tb_sdt.TabIndex = 6;
            this.tb_sdt.TextChanged += new System.EventHandler(this.tb_sdt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số điện thoại khách hàng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cbb_nam);
            this.groupBox3.Controls.Add(this.cbb_thang);
            this.groupBox3.Location = new System.Drawing.Point(336, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 105);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Theo tháng, năm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(231, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Năm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tháng";
            // 
            // cbb_nam
            // 
            this.cbb_nam.FormattingEnabled = true;
            this.cbb_nam.Location = new System.Drawing.Point(275, 45);
            this.cbb_nam.Name = "cbb_nam";
            this.cbb_nam.Size = new System.Drawing.Size(151, 28);
            this.cbb_nam.TabIndex = 1;
            this.cbb_nam.TextChanged += new System.EventHandler(this.cbb_nam_TextChanged);
            // 
            // cbb_thang
            // 
            this.cbb_thang.FormattingEnabled = true;
            this.cbb_thang.Location = new System.Drawing.Point(72, 45);
            this.cbb_thang.Name = "cbb_thang";
            this.cbb_thang.Size = new System.Drawing.Size(151, 28);
            this.cbb_thang.TabIndex = 0;
            this.cbb_thang.TextChanged += new System.EventHandler(this.cbb_thang_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_ngay);
            this.groupBox2.Location = new System.Drawing.Point(29, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 105);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Theo ngày";
            // 
            // dtp_ngay
            // 
            this.dtp_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngay.Location = new System.Drawing.Point(26, 44);
            this.dtp_ngay.Name = "dtp_ngay";
            this.dtp_ngay.Size = new System.Drawing.Size(250, 27);
            this.dtp_ngay.TabIndex = 0;
            this.dtp_ngay.ValueChanged += new System.EventHandler(this.dtp_ngay_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clean);
            this.groupBox1.Controls.Add(this.dtgv_show);
            this.groupBox1.Controls.Add(this.tb_timkiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 296);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1229, 415);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hàng hóa";
            // 
            // dtgv_show
            // 
            this.dtgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_show.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv_show.Location = new System.Drawing.Point(3, 103);
            this.dtgv_show.Name = "dtgv_show";
            this.dtgv_show.RowHeadersWidth = 51;
            this.dtgv_show.RowTemplate.Height = 29;
            this.dtgv_show.Size = new System.Drawing.Size(1223, 308);
            this.dtgv_show.TabIndex = 5;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(96, 52);
            this.tb_timkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(254, 27);
            this.tb_timkiem.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel5.Controls.Add(this.lb_khachhang);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(925, 45);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 133);
            this.panel5.TabIndex = 7;
            // 
            // lb_khachhang
            // 
            this.lb_khachhang.AutoSize = true;
            this.lb_khachhang.Location = new System.Drawing.Point(41, 76);
            this.lb_khachhang.Name = "lb_khachhang";
            this.lb_khachhang.Size = new System.Drawing.Size(17, 20);
            this.lb_khachhang.TabIndex = 4;
            this.lb_khachhang.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng khách hàng";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel4.Controls.Add(this.lb_chuathanhtoan);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(630, 45);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 133);
            this.panel4.TabIndex = 8;
            // 
            // lb_chuathanhtoan
            // 
            this.lb_chuathanhtoan.AutoSize = true;
            this.lb_chuathanhtoan.Location = new System.Drawing.Point(42, 76);
            this.lb_chuathanhtoan.Name = "lb_chuathanhtoan";
            this.lb_chuathanhtoan.Size = new System.Drawing.Size(17, 20);
            this.lb_chuathanhtoan.TabIndex = 3;
            this.lb_chuathanhtoan.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số đơn chưa thanh toán";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel3.Controls.Add(this.lb_tonghd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(338, 45);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 133);
            this.panel3.TabIndex = 9;
            // 
            // lb_tonghd
            // 
            this.lb_tonghd.AutoSize = true;
            this.lb_tonghd.Location = new System.Drawing.Point(39, 76);
            this.lb_tonghd.Name = "lb_tonghd";
            this.lb_tonghd.Size = new System.Drawing.Size(17, 20);
            this.lb_tonghd.TabIndex = 2;
            this.lb_tonghd.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số hóa đơn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lb_doanhthu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(29, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 133);
            this.panel2.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "VNĐ";
            // 
            // lb_doanhthu
            // 
            this.lb_doanhthu.AutoSize = true;
            this.lb_doanhthu.Location = new System.Drawing.Point(41, 76);
            this.lb_doanhthu.Name = "lb_doanhthu";
            this.lb_doanhthu.Size = new System.Drawing.Size(17, 20);
            this.lb_doanhthu.TabIndex = 1;
            this.lb_doanhthu.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doanh thu";
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(1085, 38);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(94, 29);
            this.btn_clean.TabIndex = 6;
            this.btn_clean.Text = "CLean";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 711);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FrmThongKe";
            this.Text = "FrmSanPham";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_show)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox4;
        private TextBox tb_sdt;
        private Label label7;
        private GroupBox groupBox3;
        private Label label12;
        private Label label11;
        private ComboBox cbb_nam;
        private ComboBox cbb_thang;
        private GroupBox groupBox2;
        private DateTimePicker dtp_ngay;
        private GroupBox groupBox1;
        private DataGridView dtgv_show;
        private TextBox tb_timkiem;
        private Label label1;
        private Panel panel5;
        private Label lb_khachhang;
        private Label label5;
        private Panel panel4;
        private Label lb_chuathanhtoan;
        private Label label4;
        private Panel panel3;
        private Label lb_tonghd;
        private Label label3;
        private Panel panel2;
        private Label label10;
        private Label lb_doanhthu;
        private Label label2;
        private Button btn_clean;
    }
}