namespace SUPER_SHOP
{
    partial class Home
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
            this.home_admin_createAccount_pnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.proceed_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logIn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.loginPassword_txt = new System.Windows.Forms.TextBox();
            this.loginUserName_txt = new System.Windows.Forms.TextBox();
            this.homeCrossPanel = new System.Windows.Forms.Panel();
            this.home_admin_createAccount_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // home_admin_createAccount_pnl
            // 
            this.home_admin_createAccount_pnl.BackColor = System.Drawing.Color.White;
            this.home_admin_createAccount_pnl.Controls.Add(this.panel1);
            this.home_admin_createAccount_pnl.Controls.Add(this.label5);
            this.home_admin_createAccount_pnl.Controls.Add(this.label6);
            this.home_admin_createAccount_pnl.Controls.Add(this.groupBox1);
            this.home_admin_createAccount_pnl.Controls.Add(this.homeCrossPanel);
            this.home_admin_createAccount_pnl.Location = new System.Drawing.Point(0, 0);
            this.home_admin_createAccount_pnl.Name = "home_admin_createAccount_pnl";
            this.home_admin_createAccount_pnl.Size = new System.Drawing.Size(1131, 648);
            this.home_admin_createAccount_pnl.TabIndex = 72;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(18, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 79);
            this.panel1.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(300, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(495, 37);
            this.label7.TabIndex = 1;
            this.label7.Text = "Super Shop Management System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 619);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 74;
            this.label5.Text = "NB.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(49, 619);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "10% Discount Will Be Applicable For Our Registered Members.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.proceed_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.logIn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.loginPassword_txt);
            this.groupBox1.Controls.Add(this.loginUserName_txt);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(18, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1094, 270);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // proceed_btn
            // 
            this.proceed_btn.BackColor = System.Drawing.Color.Transparent;
            this.proceed_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.proceed_btn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceed_btn.ForeColor = System.Drawing.Color.Black;
            this.proceed_btn.Location = new System.Drawing.Point(601, 169);
            this.proceed_btn.Name = "proceed_btn";
            this.proceed_btn.Size = new System.Drawing.Size(192, 26);
            this.proceed_btn.TabIndex = 3;
            this.proceed_btn.Text = "Proceed Anyway";
            this.proceed_btn.UseVisualStyleBackColor = false;
            this.proceed_btn.Click += new System.EventHandler(this.proceed_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(305, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "  User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(305, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "  User Name :";
            // 
            // logIn
            // 
            this.logIn.BackColor = System.Drawing.Color.Transparent;
            this.logIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logIn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn.ForeColor = System.Drawing.Color.Black;
            this.logIn.Location = new System.Drawing.Point(466, 169);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(127, 26);
            this.logIn.TabIndex = 2;
            this.logIn.Text = "Log in";
            this.logIn.UseVisualStyleBackColor = false;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(305, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "  Password :";
            // 
            // loginPassword_txt
            // 
            this.loginPassword_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginPassword_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPassword_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPassword_txt.Location = new System.Drawing.Point(466, 118);
            this.loginPassword_txt.Name = "loginPassword_txt";
            this.loginPassword_txt.PasswordChar = '*';
            this.loginPassword_txt.Size = new System.Drawing.Size(327, 26);
            this.loginPassword_txt.TabIndex = 1;
            // 
            // loginUserName_txt
            // 
            this.loginUserName_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginUserName_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginUserName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUserName_txt.Location = new System.Drawing.Point(466, 79);
            this.loginUserName_txt.Name = "loginUserName_txt";
            this.loginUserName_txt.Size = new System.Drawing.Size(327, 26);
            this.loginUserName_txt.TabIndex = 0;
            // 
            // homeCrossPanel
            // 
            this.homeCrossPanel.BackColor = System.Drawing.Color.White;
            this.homeCrossPanel.BackgroundImage = global::SUPER_SHOP.Properties.Resources.delete_button1;
            this.homeCrossPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeCrossPanel.ForeColor = System.Drawing.Color.DarkRed;
            this.homeCrossPanel.Location = new System.Drawing.Point(1101, 0);
            this.homeCrossPanel.Name = "homeCrossPanel";
            this.homeCrossPanel.Size = new System.Drawing.Size(30, 30);
            this.homeCrossPanel.TabIndex = 70;
            this.homeCrossPanel.Click += new System.EventHandler(this.homeCrossPanel_Click);
            this.homeCrossPanel.MouseLeave += new System.EventHandler(this.homeCrossPanel_MouseLeave);
            this.homeCrossPanel.MouseHover += new System.EventHandler(this.homeCrossPanel_MouseHover);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 648);
            this.Controls.Add(this.home_admin_createAccount_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.home_admin_createAccount_pnl.ResumeLayout(false);
            this.home_admin_createAccount_pnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel home_admin_createAccount_pnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button proceed_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginPassword_txt;
        private System.Windows.Forms.TextBox loginUserName_txt;
        private System.Windows.Forms.Panel homeCrossPanel;
    }
}

