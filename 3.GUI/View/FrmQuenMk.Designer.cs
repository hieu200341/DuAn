namespace _3.GUI.View
{
    partial class FrmQuenMk
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
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.cb_check = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 73);
            this.panel1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(180, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Forgot password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(25, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(92, 98);
            this.txt_email.Name = "txt_email";
            this.txt_email.ShortcutsEnabled = false;
            this.txt_email.Size = new System.Drawing.Size(386, 27);
            this.txt_email.TabIndex = 32;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(92, 192);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(144, 31);
            this.btn_send.TabIndex = 31;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // cb_check
            // 
            this.cb_check.AutoSize = true;
            this.cb_check.Location = new System.Drawing.Point(92, 144);
            this.cb_check.Name = "cb_check";
            this.cb_check.Size = new System.Drawing.Size(256, 24);
            this.cb_check.TabIndex = 34;
            this.cb_check.Text = "Bạn có phải là người máy không ?";
            this.cb_check.UseVisualStyleBackColor = true;
            this.cb_check.CheckedChanged += new System.EventHandler(this.cb_check_CheckedChanged);
            // 
            // FrmQuenMk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 255);
            this.Controls.Add(this.cb_check);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQuenMk";
            this.Text = "c";
            this.Load += new System.EventHandler(this.FrmQuenMk_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label7;
        private TextBox txt_email;
        private Button btn_send;
        private CheckBox cb_check;
    }
}