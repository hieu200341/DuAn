namespace _3.GUI.View
{
    partial class FrmKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKH));
            this.label5 = new System.Windows.Forms.Label();
            this.tbt_DiaChi = new System.Windows.Forms.TextBox();
            this.tbt_SDT = new System.Windows.Forms.TextBox();
            this.tbt_TenKH = new System.Windows.Forms.TextBox();
            this.dtgv_KH = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_Nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.tbt_TimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_KH)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Địa chỉ";
            // 
            // tbt_DiaChi
            // 
            this.tbt_DiaChi.Location = new System.Drawing.Point(178, 155);
            this.tbt_DiaChi.Name = "tbt_DiaChi";
            this.tbt_DiaChi.Size = new System.Drawing.Size(177, 27);
            this.tbt_DiaChi.TabIndex = 22;
            // 
            // tbt_SDT
            // 
            this.tbt_SDT.Location = new System.Drawing.Point(177, 3);
            this.tbt_SDT.Name = "tbt_SDT";
            this.tbt_SDT.Size = new System.Drawing.Size(177, 27);
            this.tbt_SDT.TabIndex = 20;
            // 
            // tbt_TenKH
            // 
            this.tbt_TenKH.Location = new System.Drawing.Point(177, 57);
            this.tbt_TenKH.Name = "tbt_TenKH";
            this.tbt_TenKH.Size = new System.Drawing.Size(177, 27);
            this.tbt_TenKH.TabIndex = 19;
            // 
            // dtgv_KH
            // 
            this.dtgv_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_KH.Location = new System.Drawing.Point(507, 31);
            this.dtgv_KH.Name = "dtgv_KH";
            this.dtgv_KH.RowHeadersWidth = 51;
            this.dtgv_KH.RowTemplate.Height = 29;
            this.dtgv_KH.Size = new System.Drawing.Size(669, 385);
            this.dtgv_KH.TabIndex = 34;
            this.dtgv_KH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_KH_CellClick);
            this.dtgv_KH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_KH_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "SDT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giới tính";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_Nu);
            this.panel1.Controls.Add(this.rb_nam);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbt_DiaChi);
            this.panel1.Controls.Add(this.tbt_SDT);
            this.panel1.Controls.Add(this.tbt_TenKH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 519);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rb_Nu
            // 
            this.rb_Nu.AutoSize = true;
            this.rb_Nu.Location = new System.Drawing.Point(286, 106);
            this.rb_Nu.Name = "rb_Nu";
            this.rb_Nu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb_Nu.Size = new System.Drawing.Size(50, 24);
            this.rb_Nu.TabIndex = 25;
            this.rb_Nu.TabStop = true;
            this.rb_Nu.Text = "Nữ";
            this.rb_Nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(178, 106);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(62, 24);
            this.rb_nam.TabIndex = 24;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1047, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 63);
            this.button1.TabIndex = 40;
            this.button1.Text = "Thoát";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoi.Image")));
            this.btn_LamMoi.Location = new System.Drawing.Point(892, 487);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(139, 63);
            this.btn_LamMoi.TabIndex = 39;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::_3.GUI.Properties.Resources.icons8_edit_32;
            this.btn_Sua.Location = new System.Drawing.Point(712, 487);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(139, 63);
            this.btn_Sua.TabIndex = 38;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::_3.GUI.Properties.Resources.icons8_add_new_32;
            this.btn_Them.Location = new System.Drawing.Point(507, 487);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(156, 63);
            this.btn_Them.TabIndex = 37;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // tbt_TimKiem
            // 
            this.tbt_TimKiem.Location = new System.Drawing.Point(507, 439);
            this.tbt_TimKiem.Name = "tbt_TimKiem";
            this.tbt_TimKiem.Size = new System.Drawing.Size(669, 27);
            this.tbt_TimKiem.TabIndex = 35;
            this.tbt_TimKiem.TextChanged += new System.EventHandler(this.tbt_TimKiem_TextChanged);
            // 
            // FrmKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 580);
            this.Controls.Add(this.tbt_TimKiem);
            this.Controls.Add(this.dtgv_KH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Name = "FrmKH";
            this.Text = "FrmKH";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_KH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label5;
        private TextBox tbt_DiaChi;
        private TextBox tbt_SDT;
        private TextBox tbt_TenKH;
        private DataGridView dtgv_KH;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private RadioButton rb_Nu;
        private RadioButton rb_nam;
        private Button button1;
        private Button btn_LamMoi;
        private Button btn_Sua;
        private Button btn_Them;
        private TextBox tbt_TimKiem;
    }
}