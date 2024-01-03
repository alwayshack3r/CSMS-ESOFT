namespace CoffeeShopManagementSystem
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLoginhalf = new Panel();
            lblCSMS = new Label();
            lblTitle = new Label();
            pbLoginCafe = new PictureBox();
            pbLoginUser = new PictureBox();
            lblClose = new Label();
            lblLoginTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnLogin = new Button();
            btnClear = new Button();
            pnlLoginhalf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLoginCafe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLoginUser).BeginInit();
            SuspendLayout();
            // 
            // pnlLoginhalf
            // 
            pnlLoginhalf.BackColor = Color.FromArgb(18, 38, 32);
            pnlLoginhalf.Controls.Add(lblCSMS);
            pnlLoginhalf.Controls.Add(lblTitle);
            pnlLoginhalf.Controls.Add(pbLoginCafe);
            pnlLoginhalf.Dock = DockStyle.Left;
            pnlLoginhalf.Location = new Point(0, 0);
            pnlLoginhalf.Name = "pnlLoginhalf";
            pnlLoginhalf.Size = new Size(425, 450);
            pnlLoginhalf.TabIndex = 0;
            // 
            // lblCSMS
            // 
            lblCSMS.AutoSize = true;
            lblCSMS.Font = new Font("Bradley Hand ITC", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCSMS.ForeColor = Color.FromArgb(244, 235, 208);
            lblCSMS.Location = new Point(52, 70);
            lblCSMS.Name = "lblCSMS";
            lblCSMS.Size = new Size(313, 24);
            lblCSMS.TabIndex = 3;
            lblCSMS.Text = "Coffee Shop Management System";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cyborg Punk", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(182, 141, 64);
            lblTitle.Location = new Point(0, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(433, 50);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "ESOFT CAFETERIA";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbLoginCafe
            // 
            pbLoginCafe.Dock = DockStyle.Bottom;
            pbLoginCafe.Image = Properties.Resources.cafeteriaPic;
            pbLoginCafe.Location = new Point(0, 113);
            pbLoginCafe.Name = "pbLoginCafe";
            pbLoginCafe.Size = new Size(425, 337);
            pbLoginCafe.SizeMode = PictureBoxSizeMode.Zoom;
            pbLoginCafe.TabIndex = 1;
            pbLoginCafe.TabStop = false;
            // 
            // pbLoginUser
            // 
            pbLoginUser.Image = Properties.Resources.userlogo;
            pbLoginUser.Location = new Point(596, 68);
            pbLoginUser.Name = "pbLoginUser";
            pbLoginUser.Size = new Size(100, 104);
            pbLoginUser.SizeMode = PictureBoxSizeMode.Zoom;
            pbLoginUser.TabIndex = 1;
            pbLoginUser.TabStop = false;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.BackColor = Color.FromArgb(182, 141, 64);
            lblClose.Font = new Font("Forte", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblClose.ForeColor = Color.FromArgb(192, 0, 0);
            lblClose.Location = new Point(826, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(24, 21);
            lblClose.TabIndex = 2;
            lblClose.Text = "X";
            lblClose.Click += lblClose_Click;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Race Sport", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTitle.ForeColor = Color.FromArgb(18, 38, 32);
            lblLoginTitle.Location = new Point(596, 175);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(100, 30);
            lblLoginTitle.TabIndex = 3;
            lblLoginTitle.Text = "LOGIN";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("DS-Digital", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(18, 38, 32);
            lblUsername.Location = new Point(471, 215);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(98, 21);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(471, 239);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(331, 23);
            txtUsername.TabIndex = 5;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(471, 301);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(331, 23);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("DS-Digital", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(18, 38, 32);
            lblPassword.Location = new Point(471, 277);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(98, 21);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(244, 235, 208);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(497, 346);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(119, 33);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(244, 235, 208);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(657, 346);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(127, 33);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 141, 64);
            ClientSize = new Size(850, 450);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblLoginTitle);
            Controls.Add(lblClose);
            Controls.Add(pbLoginUser);
            Controls.Add(pnlLoginhalf);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            pnlLoginhalf.ResumeLayout(false);
            pnlLoginhalf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLoginCafe).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLoginUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLoginhalf;
        private Label lblTitle;
        private PictureBox pbLoginCafe;
        private Label lblCSMS;
        private PictureBox pbLoginUser;
        private Label lblClose;
        private Label lblLoginTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnClear;
    }
}
