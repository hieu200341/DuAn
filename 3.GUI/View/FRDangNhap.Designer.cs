namespace _3.GUI.View
{
    partial class FRDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRDangNhap));
            this.button1 = new System.Windows.Forms.Button();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_buy = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(136, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(118, 227);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.ShortcutsEnabled = false;
            this.tb_pass.Size = new System.Drawing.Size(251, 27);
            this.tb_pass.TabIndex = 3;
            this.tb_pass.Text = "Password";
            this.tb_pass.Enter += new System.EventHandler(this.textBox2_Enter);
            this.tb_pass.Leave += new System.EventHandler(this.tb_pass_Leave);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(172, 533);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(160, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot your password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(99, 270);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Remember Me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 74);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(209, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "My Account";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(240, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "OR";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::_3.GUI.Properties.Resources.icons8_facebook_48;
            this.panel2.Location = new System.Drawing.Point(150, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(48, 48);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(229, 418);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(48, 48);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(312, 418);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(48, 48);
            this.panel4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "No account yet ?";
            // 
            // btn_buy
            // 
            this.btn_buy.FlatAppearance.BorderSize = 0;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_buy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buy.Location = new System.Drawing.Point(276, 482);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_buy.Size = new System.Drawing.Size(84, 31);
            this.btn_buy.TabIndex = 10;
            this.btn_buy.Text = "SignUp";
            this.btn_buy.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::_3.GUI.Properties.Resources.icons8_user_50;
            this.panel5.Location = new System.Drawing.Point(43, 131);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 50);
            this.panel5.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Location = new System.Drawing.Point(43, 204);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(50, 50);
            this.panel6.TabIndex = 12;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(118, 145);
            this.tb_user.Name = "tb_user";
            this.tb_user.ShortcutsEnabled = false;
            this.tb_user.Size = new System.Drawing.Size(251, 27);
            this.tb_user.TabIndex = 13;
            this.tb_user.Text = "Username";
            this.tb_user.Enter += new System.EventHandler(this.tb_user_Enter_1);
            this.tb_user.Leave += new System.EventHandler(this.tb_user_Leave_1);
            // 
            // FRDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 570);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.button1);
            this.Name = "FRDangNhap";
            this.Text = "Sign in";
            this.Load += new System.EventHandler(this.FRDangNhap_Load);
            this.Leave += new System.EventHandler(this.FRDangNhap_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox tb_pass;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label5;
        private Button btn_buy;
        private Panel panel5;
        private Panel panel6;
        private TextBox tb_user;
    }
}