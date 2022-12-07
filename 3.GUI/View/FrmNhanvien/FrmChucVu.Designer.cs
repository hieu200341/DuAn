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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChucVu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_tencv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_tencv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(112, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 242);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chức vụ";
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
            this.btn_thoat.Image = global::_3.GUI.Properties.Resources.icons8_esc_30;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(176, 104);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(138, 50);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamMoi.Image")));
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.Location = new System.Drawing.Point(21, 104);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(138, 50);
            this.btn_lamMoi.TabIndex = 2;
            this.btn_lamMoi.Text = "   Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtg_show);
            this.groupBox3.Location = new System.Drawing.Point(115, 370);
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
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_lamMoi);
            this.groupBox2.Location = new System.Drawing.Point(566, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 242);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::_3.GUI.Properties.Resources.icons8_edit_32;
            this.btn_Sua.Location = new System.Drawing.Point(175, 35);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(139, 63);
            this.btn_Sua.TabIndex = 39;
            this.btn_Sua.Text = "Sửa chức vụ";
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::_3.GUI.Properties.Resources.icons8_add_new_32;
            this.btn_Them.Location = new System.Drawing.Point(14, 35);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(145, 57);
            this.btn_Them.TabIndex = 38;
            this.btn_Them.Text = "Thêm chức vụ";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // FrmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 767);
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
        private TextBox tb_tencv;
        private Label label2;
        private Button btn_thoat;
        private Button btn_lamMoi;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private DataGridView dtg_show;
        private Button btn_Them;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btn_Sua;
    }
}