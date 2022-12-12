namespace _3.GUI.View
{
    partial class FrmNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNV));
            this.label5 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.rd_khd = new System.Windows.Forms.RadioButton();
            this.rd_hd = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_cv = new System.Windows.Forms.ComboBox();
            this.btn_xoahoadon = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_hoadon = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(199, 254);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(177, 27);
            this.tb_email.TabIndex = 22;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(199, 195);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(177, 27);
            this.tb_sdt.TabIndex = 20;
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(199, 74);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(177, 27);
            this.tb_ten.TabIndex = 19;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(199, 137);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(177, 27);
            this.tb_diachi.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Trạng thái";
            // 
            // dtg_show
            // 
            this.dtg_show.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtg_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dtg_show.Location = new System.Drawing.Point(519, 30);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.RowHeadersWidth = 51;
            this.dtg_show.RowTemplate.Height = 29;
            this.dtg_show.Size = new System.Drawing.Size(919, 385);
            this.dtg_show.TabIndex = 24;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mật khẩu";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Trạng thái";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Chức vụ";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "SDT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên nhân viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tb_matkhau);
            this.panel1.Controls.Add(this.rd_khd);
            this.panel1.Controls.Add(this.rd_hd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbb_cv);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.tb_sdt);
            this.panel1.Controls.Add(this.tb_ten);
            this.panel1.Controls.Add(this.tb_diachi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(86, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 519);
            this.panel1.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Mật khẩu";
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(199, 314);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(177, 27);
            this.tb_matkhau.TabIndex = 42;
            // 
            // rd_khd
            // 
            this.rd_khd.AutoSize = true;
            this.rd_khd.Location = new System.Drawing.Point(250, 379);
            this.rd_khd.Name = "rd_khd";
            this.rd_khd.Size = new System.Drawing.Size(146, 24);
            this.rd_khd.TabIndex = 37;
            this.rd_khd.TabStop = true;
            this.rd_khd.Text = "Không hoạt động";
            this.rd_khd.UseVisualStyleBackColor = true;
            // 
            // rd_hd
            // 
            this.rd_hd.AutoSize = true;
            this.rd_hd.Location = new System.Drawing.Point(132, 379);
            this.rd_hd.Name = "rd_hd";
            this.rd_hd.Size = new System.Drawing.Size(102, 24);
            this.rd_hd.TabIndex = 36;
            this.rd_hd.TabStop = true;
            this.rd_hd.Text = "Hoạt động";
            this.rd_hd.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Chức vụ";
            // 
            // cbb_cv
            // 
            this.cbb_cv.FormattingEnabled = true;
            this.cbb_cv.Location = new System.Drawing.Point(201, 429);
            this.cbb_cv.Name = "cbb_cv";
            this.cbb_cv.Size = new System.Drawing.Size(177, 28);
            this.cbb_cv.TabIndex = 34;
            // 
            // btn_xoahoadon
            // 
            this.btn_xoahoadon.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoahoadon.Image")));
            this.btn_xoahoadon.Location = new System.Drawing.Point(774, 486);
            this.btn_xoahoadon.Name = "btn_xoahoadon";
            this.btn_xoahoadon.Size = new System.Drawing.Size(137, 63);
            this.btn_xoahoadon.TabIndex = 32;
            this.btn_xoahoadon.Text = "Làm mới ";
            this.btn_xoahoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoahoadon.UseVisualStyleBackColor = true;
            this.btn_xoahoadon.Click += new System.EventHandler(this.btn_xoahoadon_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = global::_3.GUI.Properties.Resources.icons8_edit_32;
            this.btn_sua.Location = new System.Drawing.Point(956, 486);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(139, 63);
            this.btn_sua.TabIndex = 31;
            this.btn_sua.Text = "Sửa nhân viên";
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.Image = global::_3.GUI.Properties.Resources.icons8_add_new_32;
            this.btn_hoadon.Location = new System.Drawing.Point(564, 486);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Size = new System.Drawing.Size(156, 63);
            this.btn_hoadon.TabIndex = 30;
            this.btn_hoadon.Text = "Thêm nhân viên";
            this.btn_hoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_hoadon.UseVisualStyleBackColor = true;
            this.btn_hoadon.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Image = ((System.Drawing.Image)(resources.GetObject("btn_tim.Image")));
            this.btn_tim.Location = new System.Drawing.Point(1119, 486);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(114, 63);
            this.btn_tim.TabIndex = 33;
            this.btn_tim.Text = "Thoát";
            this.btn_tim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1490, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 579);
            this.Controls.Add(this.btn_xoahoadon);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_hoadon);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.dtg_show);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmNV";
            this.Text = "FrmNV";
            this.Load += new System.EventHandler(this.FrmNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label5;
        private TextBox tb_email;
        private TextBox tb_sdt;
        private TextBox tb_ten;
        private TextBox tb_diachi;
        private Label label4;
        private DataGridView dtg_show;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button btn_xoahoadon;
        private Button btn_sua;
        private Button btn_hoadon;
        private Button btn_tim;
        private Label label6;
        private ComboBox cbb_cv;
        private RadioButton rd_khd;
        private RadioButton rd_hd;
        private Label label9;
        private TextBox tb_matkhau;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private MenuStrip menuStrip1;
    }
}