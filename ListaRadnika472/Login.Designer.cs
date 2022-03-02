namespace ListaRadnika
{
    partial class Login
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblStariPassword = new System.Windows.Forms.Label();
            this.btnSnimiNoviPassword = new System.Windows.Forms.Button();
            this.txtStariPassword = new System.Windows.Forms.TextBox();
            this.lblNoviPassword = new System.Windows.Forms.Label();
            this.txtNoviPassword = new System.Windows.Forms.TextBox();
            this.lblPotvrdiNoviPassword = new System.Windows.Forms.Label();
            this.txtPotvrdiNoviPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsernamePP = new System.Windows.Forms.TextBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlPromjenaPassworda = new System.Windows.Forms.Panel();
            this.btnZelimPromijenitiPassword = new System.Windows.Forms.Button();
            this.btnRegistrujNovogKorisnika = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.pnlPromjenaPassworda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblUsername.Location = new System.Drawing.Point(95, 39);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 23);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Wheat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnLogin.Location = new System.Drawing.Point(215, 141);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 35);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtUsername.Location = new System.Drawing.Point(201, 36);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(230, 30);
            this.txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblPassword.Location = new System.Drawing.Point(102, 91);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 23);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtPassword.Location = new System.Drawing.Point(200, 89);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(230, 30);
            this.txtPassword.TabIndex = 2;
            // 
            // lblStariPassword
            // 
            this.lblStariPassword.AutoSize = true;
            this.lblStariPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblStariPassword.Location = new System.Drawing.Point(64, 69);
            this.lblStariPassword.Name = "lblStariPassword";
            this.lblStariPassword.Size = new System.Drawing.Size(119, 23);
            this.lblStariPassword.TabIndex = 3;
            this.lblStariPassword.Text = "Stari password";
            // 
            // btnSnimiNoviPassword
            // 
            this.btnSnimiNoviPassword.BackColor = System.Drawing.Color.Linen;
            this.btnSnimiNoviPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnSnimiNoviPassword.Location = new System.Drawing.Point(216, 213);
            this.btnSnimiNoviPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSnimiNoviPassword.Name = "btnSnimiNoviPassword";
            this.btnSnimiNoviPassword.Size = new System.Drawing.Size(203, 35);
            this.btnSnimiNoviPassword.TabIndex = 10;
            this.btnSnimiNoviPassword.Text = "Snimi novi password";
            this.btnSnimiNoviPassword.UseVisualStyleBackColor = false;
            this.btnSnimiNoviPassword.Click += new System.EventHandler(this.BtnSnimiNoviPassword_Click);
            // 
            // txtStariPassword
            // 
            this.txtStariPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtStariPassword.Location = new System.Drawing.Point(201, 64);
            this.txtStariPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStariPassword.Name = "txtStariPassword";
            this.txtStariPassword.PasswordChar = '*';
            this.txtStariPassword.Size = new System.Drawing.Size(231, 30);
            this.txtStariPassword.TabIndex = 7;
            // 
            // lblNoviPassword
            // 
            this.lblNoviPassword.AutoSize = true;
            this.lblNoviPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblNoviPassword.Location = new System.Drawing.Point(64, 117);
            this.lblNoviPassword.Name = "lblNoviPassword";
            this.lblNoviPassword.Size = new System.Drawing.Size(121, 23);
            this.lblNoviPassword.TabIndex = 3;
            this.lblNoviPassword.Text = "Novi password";
            // 
            // txtNoviPassword
            // 
            this.txtNoviPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtNoviPassword.Location = new System.Drawing.Point(201, 115);
            this.txtNoviPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoviPassword.Name = "txtNoviPassword";
            this.txtNoviPassword.PasswordChar = '*';
            this.txtNoviPassword.Size = new System.Drawing.Size(230, 30);
            this.txtNoviPassword.TabIndex = 8;
            // 
            // lblPotvrdiNoviPassword
            // 
            this.lblPotvrdiNoviPassword.AutoSize = true;
            this.lblPotvrdiNoviPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblPotvrdiNoviPassword.Location = new System.Drawing.Point(7, 164);
            this.lblPotvrdiNoviPassword.Name = "lblPotvrdiNoviPassword";
            this.lblPotvrdiNoviPassword.Size = new System.Drawing.Size(176, 23);
            this.lblPotvrdiNoviPassword.TabIndex = 3;
            this.lblPotvrdiNoviPassword.Text = "Potvrdi novi password";
            // 
            // txtPotvrdiNoviPassword
            // 
            this.txtPotvrdiNoviPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtPotvrdiNoviPassword.Location = new System.Drawing.Point(201, 162);
            this.txtPotvrdiNoviPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPotvrdiNoviPassword.Name = "txtPotvrdiNoviPassword";
            this.txtPotvrdiNoviPassword.PasswordChar = '*';
            this.txtPotvrdiNoviPassword.Size = new System.Drawing.Size(231, 30);
            this.txtPotvrdiNoviPassword.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txtUsernamePP
            // 
            this.txtUsernamePP.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtUsernamePP.Location = new System.Drawing.Point(201, 17);
            this.txtUsernamePP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsernamePP.Name = "txtUsernamePP";
            this.txtUsernamePP.Size = new System.Drawing.Size(231, 30);
            this.txtUsernamePP.TabIndex = 6;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Location = new System.Drawing.Point(23, 12);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(466, 221);
            this.pnlLogin.TabIndex = 8;
            // 
            // pnlPromjenaPassworda
            // 
            this.pnlPromjenaPassworda.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPromjenaPassworda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPromjenaPassworda.Controls.Add(this.txtStariPassword);
            this.pnlPromjenaPassworda.Controls.Add(this.label1);
            this.pnlPromjenaPassworda.Controls.Add(this.txtUsernamePP);
            this.pnlPromjenaPassworda.Controls.Add(this.txtPotvrdiNoviPassword);
            this.pnlPromjenaPassworda.Controls.Add(this.lblStariPassword);
            this.pnlPromjenaPassworda.Controls.Add(this.txtNoviPassword);
            this.pnlPromjenaPassworda.Controls.Add(this.btnSnimiNoviPassword);
            this.pnlPromjenaPassworda.Controls.Add(this.lblPotvrdiNoviPassword);
            this.pnlPromjenaPassworda.Controls.Add(this.lblNoviPassword);
            this.pnlPromjenaPassworda.Location = new System.Drawing.Point(23, 311);
            this.pnlPromjenaPassworda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPromjenaPassworda.Name = "pnlPromjenaPassworda";
            this.pnlPromjenaPassworda.Size = new System.Drawing.Size(466, 274);
            this.pnlPromjenaPassworda.TabIndex = 9;
            this.pnlPromjenaPassworda.Visible = false;
            // 
            // btnZelimPromijenitiPassword
            // 
            this.btnZelimPromijenitiPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZelimPromijenitiPassword.Location = new System.Drawing.Point(279, 253);
            this.btnZelimPromijenitiPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZelimPromijenitiPassword.Name = "btnZelimPromijenitiPassword";
            this.btnZelimPromijenitiPassword.Size = new System.Drawing.Size(210, 32);
            this.btnZelimPromijenitiPassword.TabIndex = 5;
            this.btnZelimPromijenitiPassword.Text = "Promijeni password";
            this.btnZelimPromijenitiPassword.UseVisualStyleBackColor = true;
            this.btnZelimPromijenitiPassword.Click += new System.EventHandler(this.BtnPromijeniPassword_Click);
            // 
            // btnRegistrujNovogKorisnika
            // 
            this.btnRegistrujNovogKorisnika.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrujNovogKorisnika.Location = new System.Drawing.Point(23, 253);
            this.btnRegistrujNovogKorisnika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrujNovogKorisnika.Name = "btnRegistrujNovogKorisnika";
            this.btnRegistrujNovogKorisnika.Size = new System.Drawing.Size(210, 32);
            this.btnRegistrujNovogKorisnika.TabIndex = 4;
            this.btnRegistrujNovogKorisnika.Text = "Registruj novog korisnika";
            this.btnRegistrujNovogKorisnika.UseVisualStyleBackColor = true;
            this.btnRegistrujNovogKorisnika.Click += new System.EventHandler(this.BtnRegistrujNovogKorisnika_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(512, 303);
            this.Controls.Add(this.btnRegistrujNovogKorisnika);
            this.Controls.Add(this.btnZelimPromijenitiPassword);
            this.Controls.Add(this.pnlPromjenaPassworda);
            this.Controls.Add(this.pnlLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlPromjenaPassworda.ResumeLayout(false);
            this.pnlPromjenaPassworda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblStariPassword;
        private System.Windows.Forms.Button btnSnimiNoviPassword;
        private System.Windows.Forms.TextBox txtStariPassword;
        private System.Windows.Forms.Label lblNoviPassword;
        private System.Windows.Forms.TextBox txtNoviPassword;
        private System.Windows.Forms.Label lblPotvrdiNoviPassword;
        private System.Windows.Forms.TextBox txtPotvrdiNoviPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsernamePP;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlPromjenaPassworda;
        private System.Windows.Forms.Button btnZelimPromijenitiPassword;
        private System.Windows.Forms.Button btnRegistrujNovogKorisnika;
    }
}