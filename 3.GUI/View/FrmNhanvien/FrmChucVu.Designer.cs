namespace _3.GUI.View.FrmNhanvien
{
    partial class FrmChucVu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_KHD = new System.Windows.Forms.RadioButton();
            this.rb_HoatDong = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tencv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btb_CapNhat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_KHD);
            this.groupBox1.Controls.Add(this.rb_HoatDong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_tencv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(112, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 242);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chức vụ";
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
            // tb_tencv
            // 
            this.tb_tencv.Location = new System.Drawing.Point(186, 101);
            this.tb_tencv.Name = "tb_tencv";
            this.tb_tencv.Size = new System.Drawing.Size(211, 27);
            this.tb_tencv.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chức vụ";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(176, 104);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(138, 50);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Location = new System.Drawing.Point(21, 104);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(138, 50);
            this.btn_lamMoi.TabIndex = 2;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            // 
            // btb_CapNhat
            // 
            this.btb_CapNhat.Location = new System.Drawing.Point(176, 35);
            this.btb_CapNhat.Name = "btb_CapNhat";
            this.btb_CapNhat.Size = new System.Drawing.Size(138, 50);
            this.btb_CapNhat.TabIndex = 1;
            this.btb_CapNhat.Text = "Cập nhật";
            this.btb_CapNhat.UseVisualStyleBackColor = true;
            this.btb_CapNhat.Click += new System.EventHandler(this.btb_CapNhat_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtg_show);
            this.groupBox3.Location = new System.Drawing.Point(115, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(786, 330);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách màu sắc";
            // 
            // dtg_show
            // 
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(3, 23);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.RowHeadersWidth = 51;
            this.dtg_show.RowTemplate.Height = 29;
            this.dtg_show.Size = new System.Drawing.Size(777, 301);
            this.dtg_show.TabIndex = 0;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dtg_show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_lamMoi);
            this.groupBox2.Controls.Add(this.btb_CapNhat);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Location = new System.Drawing.Point(566, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 242);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(21, 36);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(138, 50);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // FrmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 637);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmChucVu";
            this.Text = "FrmChucVu";
            this.Load += new System.EventHandler(this.FrmChucVu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rb_KHD;
        private RadioButton rb_HoatDong;
        private Label label3;
        private TextBox tb_tencv;
        private Label label2;
        private Button btn_thoat;
        private Button btn_lamMoi;
        private Button btb_CapNhat;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button btn_them;
        private DataGridView dtg_show;
    }
}