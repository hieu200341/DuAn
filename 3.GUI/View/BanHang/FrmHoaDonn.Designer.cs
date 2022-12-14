namespace _3.GUI.View.BanHang
{
    partial class FrmHoaDonn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDonn));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_timk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtgv_hoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_CTHD = new System.Windows.Forms.DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbt_ghiChu = new System.Windows.Forms.TextBox();
            this.dtp_ngay = new System.Windows.Forms.DateTimePicker();
            this.tbt_tongTien = new System.Windows.Forms.TextBox();
            this.tbt_SDT = new System.Windows.Forms.TextBox();
            this.tbt_maNV = new System.Windows.Forms.TextBox();
            this.tbt_MaHD = new System.Windows.Forms.TextBox();
            this.rb_ChuaThanhToan = new System.Windows.Forms.RadioButton();
            this.rb_daThanhToan = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CTHD)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_timk);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dtgv_hoaDon);
            this.groupBox1.Location = new System.Drawing.Point(28, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1110, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // btn_timk
            // 
            this.btn_timk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_timk.Image = ((System.Drawing.Image)(resources.GetObject("btn_timk.Image")));
            this.btn_timk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timk.Location = new System.Drawing.Point(997, 15);
            this.btn_timk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_timk.Name = "btn_timk";
            this.btn_timk.Size = new System.Drawing.Size(97, 31);
            this.btn_timk.TabIndex = 18;
            this.btn_timk.Text = "Tìm kiếm";
            this.btn_timk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timk.UseVisualStyleBackColor = false;
            this.btn_timk.Click += new System.EventHandler(this.btn_timk_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(696, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Tìm kiếm";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtgv_hoaDon
            // 
            this.dtgv_hoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_hoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtgv_hoaDon.Location = new System.Drawing.Point(1, 56);
            this.dtgv_hoaDon.Name = "dtgv_hoaDon";
            this.dtgv_hoaDon.RowHeadersWidth = 51;
            this.dtgv_hoaDon.RowTemplate.Height = 29;
            this.dtgv_hoaDon.Size = new System.Drawing.Size(1109, 236);
            this.dtgv_hoaDon.TabIndex = 0;
            this.dtgv_hoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_hoaDon_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SĐT - Khách hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 170;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tổng tiền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày bán";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ghi chú";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Trạng thái";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_CTHD);
            this.groupBox2.Location = new System.Drawing.Point(28, 526);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1110, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // dtgv_CTHD
            // 
            this.dtgv_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_CTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dtgv_CTHD.Location = new System.Drawing.Point(0, 23);
            this.dtgv_CTHD.Name = "dtgv_CTHD";
            this.dtgv_CTHD.RowHeadersWidth = 51;
            this.dtgv_CTHD.RowTemplate.Height = 29;
            this.dtgv_CTHD.Size = new System.Drawing.Size(1110, 165);
            this.dtgv_CTHD.TabIndex = 0;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Mã hóa đơn";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mã sản phẩm";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Tên sản phẩm";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 150;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Số lượng";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Đơn giá";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(888, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 210);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(27, 95);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(202, 45);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbt_ghiChu);
            this.groupBox4.Controls.Add(this.dtp_ngay);
            this.groupBox4.Controls.Add(this.tbt_tongTien);
            this.groupBox4.Controls.Add(this.tbt_SDT);
            this.groupBox4.Controls.Add(this.tbt_maNV);
            this.groupBox4.Controls.Add(this.tbt_MaHD);
            this.groupBox4.Controls.Add(this.rb_ChuaThanhToan);
            this.groupBox4.Controls.Add(this.rb_daThanhToan);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(28, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(831, 210);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh mục hóa đơn";
            // 
            // tbt_ghiChu
            // 
            this.tbt_ghiChu.Enabled = false;
            this.tbt_ghiChu.Location = new System.Drawing.Point(513, 124);
            this.tbt_ghiChu.Name = "tbt_ghiChu";
            this.tbt_ghiChu.Size = new System.Drawing.Size(194, 27);
            this.tbt_ghiChu.TabIndex = 21;
            // 
            // dtp_ngay
            // 
            this.dtp_ngay.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngay.Enabled = false;
            this.dtp_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngay.Location = new System.Drawing.Point(513, 82);
            this.dtp_ngay.Name = "dtp_ngay";
            this.dtp_ngay.Size = new System.Drawing.Size(194, 27);
            this.dtp_ngay.TabIndex = 20;
            // 
            // tbt_tongTien
            // 
            this.tbt_tongTien.Enabled = false;
            this.tbt_tongTien.Location = new System.Drawing.Point(513, 36);
            this.tbt_tongTien.Name = "tbt_tongTien";
            this.tbt_tongTien.Size = new System.Drawing.Size(194, 27);
            this.tbt_tongTien.TabIndex = 19;
            // 
            // tbt_SDT
            // 
            this.tbt_SDT.Enabled = false;
            this.tbt_SDT.Location = new System.Drawing.Point(195, 127);
            this.tbt_SDT.Name = "tbt_SDT";
            this.tbt_SDT.Size = new System.Drawing.Size(194, 27);
            this.tbt_SDT.TabIndex = 18;
            // 
            // tbt_maNV
            // 
            this.tbt_maNV.Enabled = false;
            this.tbt_maNV.Location = new System.Drawing.Point(195, 80);
            this.tbt_maNV.Name = "tbt_maNV";
            this.tbt_maNV.Size = new System.Drawing.Size(194, 27);
            this.tbt_maNV.TabIndex = 17;
            // 
            // tbt_MaHD
            // 
            this.tbt_MaHD.Enabled = false;
            this.tbt_MaHD.Location = new System.Drawing.Point(195, 33);
            this.tbt_MaHD.Name = "tbt_MaHD";
            this.tbt_MaHD.Size = new System.Drawing.Size(194, 27);
            this.tbt_MaHD.TabIndex = 16;
            // 
            // rb_ChuaThanhToan
            // 
            this.rb_ChuaThanhToan.AutoSize = true;
            this.rb_ChuaThanhToan.Location = new System.Drawing.Point(667, 168);
            this.rb_ChuaThanhToan.Name = "rb_ChuaThanhToan";
            this.rb_ChuaThanhToan.Size = new System.Drawing.Size(139, 24);
            this.rb_ChuaThanhToan.TabIndex = 15;
            this.rb_ChuaThanhToan.TabStop = true;
            this.rb_ChuaThanhToan.Text = "Chưa thanh toán";
            this.rb_ChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // rb_daThanhToan
            // 
            this.rb_daThanhToan.AutoSize = true;
            this.rb_daThanhToan.Location = new System.Drawing.Point(527, 170);
            this.rb_daThanhToan.Name = "rb_daThanhToan";
            this.rb_daThanhToan.Size = new System.Drawing.Size(124, 24);
            this.rb_daThanhToan.TabIndex = 14;
            this.rb_daThanhToan.TabStop = true;
            this.rb_daThanhToan.Text = "Đã thanh toán";
            this.rb_daThanhToan.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(722, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "VNĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Trạng thái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ghi chú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "SĐT - khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // FrmHoaDonn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 730);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmHoaDonn";
            this.Text = "FrmHoaDonn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CTHD)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private DataGridView dtgv_hoaDon;
        private DataGridView dtgv_CTHD;
        private Button button3;
        private Button button1;
        private GroupBox groupBox4;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton rb_ChuaThanhToan;
        private RadioButton rb_daThanhToan;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button btn_timk;
        private Button btn_xoa;
        private TextBox tbt_ghiChu;
        private DateTimePicker dtp_ngay;
        private TextBox tbt_tongTien;
        private TextBox tbt_SDT;
        private TextBox tbt_maNV;
        private TextBox tbt_MaHD;
    }
}