namespace _3.GUI.View.BanHang
{
    partial class FrmHoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtn_Chuatt = new System.Windows.Forms.RadioButton();
            this.rbtn_dathanhtoan = new System.Windows.Forms.RadioButton();
            this.dtp_ntt = new System.Windows.Forms.DateTimePicker();
            this.dtp_nb = new System.Windows.Forms.DateTimePicker();
            this.cmb_TenKH = new System.Windows.Forms.ComboBox();
            this.cmb_TenNV = new System.Windows.Forms.ComboBox();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgrid_hoadon = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_Chuatt);
            this.panel1.Controls.Add(this.rbtn_dathanhtoan);
            this.panel1.Controls.Add(this.dtp_ntt);
            this.panel1.Controls.Add(this.dtp_nb);
            this.panel1.Controls.Add(this.cmb_TenKH);
            this.panel1.Controls.Add(this.cmb_TenNV);
            this.panel1.Controls.Add(this.txt_MaHD);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 519);
            this.panel1.TabIndex = 29;
            // 
            // rbtn_Chuatt
            // 
            this.rbtn_Chuatt.AutoSize = true;
            this.rbtn_Chuatt.Location = new System.Drawing.Point(256, 373);
            this.rbtn_Chuatt.Name = "rbtn_Chuatt";
            this.rbtn_Chuatt.Size = new System.Drawing.Size(139, 24);
            this.rbtn_Chuatt.TabIndex = 31;
            this.rbtn_Chuatt.TabStop = true;
            this.rbtn_Chuatt.Text = "Chưa thanh toán";
            this.rbtn_Chuatt.UseVisualStyleBackColor = true;
            // 
            // rbtn_dathanhtoan
            // 
            this.rbtn_dathanhtoan.AutoSize = true;
            this.rbtn_dathanhtoan.Location = new System.Drawing.Point(126, 373);
            this.rbtn_dathanhtoan.Name = "rbtn_dathanhtoan";
            this.rbtn_dathanhtoan.Size = new System.Drawing.Size(124, 24);
            this.rbtn_dathanhtoan.TabIndex = 30;
            this.rbtn_dathanhtoan.TabStop = true;
            this.rbtn_dathanhtoan.Text = "Đã thanh toán";
            this.rbtn_dathanhtoan.UseVisualStyleBackColor = true;
            // 
            // dtp_ntt
            // 
            this.dtp_ntt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ntt.Location = new System.Drawing.Point(172, 302);
            this.dtp_ntt.Name = "dtp_ntt";
            this.dtp_ntt.Size = new System.Drawing.Size(125, 27);
            this.dtp_ntt.TabIndex = 29;
            // 
            // dtp_nb
            // 
            this.dtp_nb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nb.Location = new System.Drawing.Point(172, 237);
            this.dtp_nb.Name = "dtp_nb";
            this.dtp_nb.Size = new System.Drawing.Size(125, 27);
            this.dtp_nb.TabIndex = 28;
            // 
            // cmb_TenKH
            // 
            this.cmb_TenKH.FormattingEnabled = true;
            this.cmb_TenKH.Location = new System.Drawing.Point(172, 164);
            this.cmb_TenKH.Name = "cmb_TenKH";
            this.cmb_TenKH.Size = new System.Drawing.Size(204, 28);
            this.cmb_TenKH.TabIndex = 27;
            // 
            // cmb_TenNV
            // 
            this.cmb_TenNV.FormattingEnabled = true;
            this.cmb_TenNV.Location = new System.Drawing.Point(172, 89);
            this.cmb_TenNV.Name = "cmb_TenNV";
            this.cmb_TenNV.Size = new System.Drawing.Size(204, 28);
            this.cmb_TenNV.TabIndex = 26;
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(172, 20);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(204, 27);
            this.txt_MaHD.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mã Hóa Đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ngày thanh toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ngày bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên nhân viên";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = global::_3.GUI.Properties.Resources.icons8_trash_32;
            this.btn_xoa.Location = new System.Drawing.Point(662, 493);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(137, 63);
            this.btn_xoa.TabIndex = 27;
            this.btn_xoa.Text = "Xóa hóa đơn";
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = global::_3.GUI.Properties.Resources.icons8_edit_32;
            this.btn_sua.Location = new System.Drawing.Point(838, 493);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(139, 63);
            this.btn_sua.TabIndex = 26;
            this.btn_sua.Text = "Sửa hóa đơn";
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = global::_3.GUI.Properties.Resources.icons8_add_new_32;
            this.btn_them.Location = new System.Drawing.Point(459, 493);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(156, 63);
            this.btn_them.TabIndex = 25;
            this.btn_them.Text = "Thêm hóa đơn";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgrid_hoadon
            // 
            this.dgrid_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_hoadon.Location = new System.Drawing.Point(459, 37);
            this.dgrid_hoadon.Name = "dgrid_hoadon";
            this.dgrid_hoadon.RowHeadersWidth = 51;
            this.dgrid_hoadon.RowTemplate.Height = 29;
            this.dgrid_hoadon.Size = new System.Drawing.Size(669, 385);
            this.dgrid_hoadon.TabIndex = 24;
            this.dgrid_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_hoadon_CellClick);
            // 
            // button2
            // 
            this.button2.Image = global::_3.GUI.Properties.Resources.icons8_search_32;
            this.button2.Location = new System.Drawing.Point(1014, 493);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 63);
            this.button2.TabIndex = 30;
            this.button2.Text = "Tìm hóa đơn";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(459, 448);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.PlaceholderText = "Tìm Kiếm";
            this.txt_timkiem.Size = new System.Drawing.Size(669, 27);
            this.txt_timkiem.TabIndex = 28;
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgrid_hoadon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_timkiem);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private DataGridView dgrid_hoadon;
        private Button button2;
        private TextBox txt_timkiem;
        private RadioButton rbtn_Chuatt;
        private RadioButton rbtn_dathanhtoan;
        private DateTimePicker dtp_ntt;
        private DateTimePicker dtp_nb;
        private ComboBox cmb_TenKH;
        private ComboBox cmb_TenNV;
        private TextBox txt_MaHD;
        private Label label6;
    }
}