namespace _3.GUI.View
{
    partial class FrmDangKy
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
            this.tb_user = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_buy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_pass2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_emailorphone = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(206, 147);
            this.tb_user.Name = "tb_user";
            this.tb_user.PlaceholderText = "Username";
            this.tb_user.Size = new System.Drawing.Size(251, 27);
            this.tb_user.TabIndex = 14;
            this.tb_user.TextChanged += new System.EventHandler(this.tb_user_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "CREATE ACCOUNT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_buy
            // 
            this.btn_buy.FlatAppearance.BorderSize = 0;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_buy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buy.Location = new System.Drawing.Point(375, 545);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_buy.Size = new System.Drawing.Size(84, 31);
            this.btn_buy.TabIndex = 24;
            this.btn_buy.Text = "Login";
            this.btn_buy.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 550);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Already have a account";
            // 
            // tb_pass2
            // 
            this.tb_pass2.Location = new System.Drawing.Point(206, 358);
            this.tb_pass2.Name = "tb_pass2";
            this.tb_pass2.PasswordChar = '*';
            this.tb_pass2.PlaceholderText = "Confirm Password";
            this.tb_pass2.ShortcutsEnabled = false;
            this.tb_pass2.Size = new System.Drawing.Size(251, 27);
            this.tb_pass2.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 73);
            this.panel1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(180, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Create Account";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(206, 289);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.PlaceholderText = "Password";
            this.textBox2.Size = new System.Drawing.Size(253, 27);
            this.textBox2.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::_3.GUI.Properties.Resources.icons8_lock_50;
            this.panel2.Location = new System.Drawing.Point(122, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 50);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::_3.GUI.Properties.Resources.icons8_mail_50;
            this.panel3.Location = new System.Drawing.Point(122, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 50);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::_3.GUI.Properties.Resources.icons8_user_501;
            this.panel4.Location = new System.Drawing.Point(122, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 50);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::_3.GUI.Properties.Resources.icons8_lock_50;
            this.panel5.Location = new System.Drawing.Point(122, 335);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 50);
            this.panel5.TabIndex = 32;
            // 
            // tb_emailorphone
            // 
            this.tb_emailorphone.Location = new System.Drawing.Point(206, 219);
            this.tb_emailorphone.Name = "tb_emailorphone";
            this.tb_emailorphone.PlaceholderText = "Email or Phone";
            this.tb_emailorphone.Size = new System.Drawing.Size(251, 27);
            this.tb_emailorphone.TabIndex = 0;
            // 
            // FrmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 627);
            this.Controls.Add(this.tb_emailorphone);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_pass2);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.label5);
            this.Name = "FrmDangKy";
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tb_user;
        private Button button1;
        private Button btn_buy;
        private Label label5;
        private TextBox tb_pass2;
        private Panel panel1;
        private Label label3;
        private TextBox textBox2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TextBox tb_emailorphone;
    }
}