namespace _3.GUI.View.FromSanPham
{
    partial class FrmMauSac
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
            this.dtgv_Mau = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btb_CapNhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_KHD = new System.Windows.Forms.RadioButton();
            this.rb_HoatDong = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbt_TenMau = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Mau)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_Mau
            // 
            this.dtgv_Mau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Mau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgv_Mau.Location = new System.Drawing.Point(-3, 37);
            this.dtgv_Mau.Name = "dtgv_Mau";
            this.dtgv_Mau.RowHeadersWidth = 51;
            this.dtgv_Mau.RowTemplate.Height = 29;
            this.dtgv_Mau.Size = new System.Drawing.Size(789, 290);
            this.dtgv_Mau.TabIndex = 0;
            this.dtgv_Mau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Mau_CellClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã màu sắc";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên màu sắc";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tình trạng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgv_Mau);
            this.groupBox3.Location = new System.Drawing.Point(120, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(786, 330);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách màu sắc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_lamMoi);
            this.groupBox2.Controls.Add(this.btb_CapNhat);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Location = new System.Drawing.Point(571, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 242);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = global::_3.GUI.Properties.Resources.icons8_esc_301;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(176, 104);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(138, 50);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Image = global::_3.GUI.Properties.Resources.icons8_repeat_301;
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.Location = new System.Drawing.Point(21, 104);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(138, 50);
            this.btn_lamMoi.TabIndex = 2;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            // 
            // btb_CapNhat
            // 
            this.btb_CapNhat.Image = global::_3.GUI.Properties.Resources.icons8_edit_32;
            this.btb_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btb_CapNhat.Location = new System.Drawing.Point(176, 35);
            this.btb_CapNhat.Name = "btb_CapNhat";
            this.btb_CapNhat.Size = new System.Drawing.Size(138, 50);
            this.btb_CapNhat.TabIndex = 1;
            this.btb_CapNhat.Text = "Cập nhật";
            this.btb_CapNhat.UseVisualStyleBackColor = true;
            this.btb_CapNhat.Click += new System.EventHandler(this.btb_CapNhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = global::_3.GUI.Properties.Resources.icons8_add_new_32;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(21, 36);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(138, 50);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên màu sắc";
            // 
            // rb_KHD
            // 
            this.rb_KHD.AutoSize = true;
            this.rb_KHD.Location = new System.Drawing.Point(306, 159);
            this.rb_KHD.Name = "rb_KHD";
            this.rb_KHD.Size = new System.Drawing.Size(91, 24);
            this.rb_KHD.TabIndex = 6;
            this.rb_KHD.TabStop = true;
            this.rb_KHD.Text = "Hết hàng";
            this.rb_KHD.UseVisualStyleBackColor = true;
            // 
            // rb_HoatDong
            // 
            this.rb_HoatDong.AutoSize = true;
            this.rb_HoatDong.Location = new System.Drawing.Point(186, 159);
            this.rb_HoatDong.Name = "rb_HoatDong";
            this.rb_HoatDong.Size = new System.Drawing.Size(93, 24);
            this.rb_HoatDong.TabIndex = 5;
            this.rb_HoatDong.TabStop = true;
            this.rb_HoatDong.Text = "Còn hàng";
            this.rb_HoatDong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trạng thái";
            // 
            // tbt_TenMau
            // 
            this.tbt_TenMau.Location = new System.Drawing.Point(186, 101);
            this.tbt_TenMau.Name = "tbt_TenMau";
            this.tbt_TenMau.Size = new System.Drawing.Size(211, 27);
            this.tbt_TenMau.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_KHD);
            this.groupBox1.Controls.Add(this.rb_HoatDong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbt_TenMau);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(117, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 242);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin màu sắc";
            // 
            // FrmMauSac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 679);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMauSac";
            this.Text = "FrmMauSac";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Mau)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dtgv_Mau;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button btn_thoat;
        private Button btn_lamMoi;
        private Button btb_CapNhat;
        private Button btn_them;
        private Label label2;
        private RadioButton rb_KHD;
        private RadioButton rb_HoatDong;
        private Label label3;
        private TextBox tbt_TenMau;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}