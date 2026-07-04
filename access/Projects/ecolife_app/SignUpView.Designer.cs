#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace EcoLife_App
{
    partial class SignUpView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();

            // Username
            lblRegUser = new Label();
            txtRegUser = new TextBox();
            pnlLine1 = new Panel();

            // Password
            lblRegPass = new Label();
            txtRegPass = new TextBox();
            pnlLine2 = new Panel();

            // Confirm Password
            lblConfirm = new Label();
            txtConfirm = new TextBox();
            pnlLine3 = new Panel();

            // Buttons
            btnRegister = new Button();
            btnBackToLogin = new Button();

            SuspendLayout();

            // 
            // SignUpView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnBackToLogin);
            Controls.Add(btnRegister);
            Controls.Add(pnlLine3);
            Controls.Add(txtConfirm);
            Controls.Add(lblConfirm);
            Controls.Add(pnlLine2);
            Controls.Add(txtRegPass);
            Controls.Add(lblRegPass);
            Controls.Add(pnlLine1);
            Controls.Add(txtRegUser);
            Controls.Add(lblRegUser);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular);
            Name = "SignUpView";
            Size = new Size(500, 460);

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(46, 204, 113);
            lblTitle.Location = new Point(40, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Join EcoLife";

            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(45, 70);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Text = "Start your wellness journey today.";

            // 
            // lblRegUser
            // 
            lblRegUser.AutoSize = true;
            lblRegUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRegUser.ForeColor = Color.DarkGray;
            lblRegUser.Location = new Point(45, 110);
            lblRegUser.Name = "lblRegUser";
            lblRegUser.Text = "Choose Username";

            // 
            // txtRegUser
            // 
            txtRegUser.BorderStyle = BorderStyle.None;
            txtRegUser.Font = new Font("Segoe UI", 12F);
            txtRegUser.Location = new Point(45, 135);
            txtRegUser.Name = "txtRegUser";
            txtRegUser.Size = new Size(350, 22);
            txtRegUser.TabIndex = 1;

            // 
            // pnlLine1
            // 
            pnlLine1.BackColor = Color.LightGray;
            pnlLine1.Location = new Point(45, 160);
            pnlLine1.Name = "pnlLine1";
            pnlLine1.Size = new Size(350, 2);

            // 
            // lblRegPass
            // 
            lblRegPass.AutoSize = true;
            lblRegPass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRegPass.ForeColor = Color.DarkGray;
            lblRegPass.Location = new Point(45, 180);
            lblRegPass.Name = "lblRegPass";
            lblRegPass.Text = "Create Password";

            // 
            // txtRegPass
            // 
            txtRegPass.BorderStyle = BorderStyle.None;
            txtRegPass.Font = new Font("Segoe UI", 12F);
            txtRegPass.Location = new Point(45, 205);
            txtRegPass.Name = "txtRegPass";
            txtRegPass.Size = new Size(350, 22);
            txtRegPass.TabIndex = 2;
            txtRegPass.UseSystemPasswordChar = true;

            // 
            // pnlLine2
            // 
            pnlLine2.BackColor = Color.LightGray;
            pnlLine2.Location = new Point(45, 230);
            pnlLine2.Name = "pnlLine2";
            pnlLine2.Size = new Size(350, 2);

            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConfirm.ForeColor = Color.DarkGray;
            lblConfirm.Location = new Point(45, 250);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Text = "Confirm Password";

            // 
            // txtConfirm
            // 
            txtConfirm.BorderStyle = BorderStyle.None;
            txtConfirm.Font = new Font("Segoe UI", 12F);
            txtConfirm.Location = new Point(45, 275);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(350, 22);
            txtConfirm.TabIndex = 3;
            txtConfirm.UseSystemPasswordChar = true;

            // 
            // pnlLine3
            // 
            pnlLine3.BackColor = Color.LightGray;
            pnlLine3.Location = new Point(45, 300);
            pnlLine3.Name = "pnlLine3";
            pnlLine3.Size = new Size(350, 2);

            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(46, 204, 113);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(45, 340);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 45);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "CREATE ACCOUNT";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += BtnRegister_Click;

            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.Transparent;
            btnBackToLogin.Cursor = Cursors.Hand;
            btnBackToLogin.FlatAppearance.BorderSize = 0;
            btnBackToLogin.FlatStyle = FlatStyle.Flat;
            btnBackToLogin.Font = new Font("Segoe UI", 10F);
            btnBackToLogin.ForeColor = Color.Gray;
            btnBackToLogin.Location = new Point(210, 340);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(150, 45);
            btnBackToLogin.TabIndex = 5;
            btnBackToLogin.Text = "Cancel";
            btnBackToLogin.TextAlign = ContentAlignment.MiddleLeft;
            btnBackToLogin.UseVisualStyleBackColor = false;
            btnBackToLogin.Click += BtnBackToLogin_Click;

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblRegUser;
        private TextBox txtRegUser;
        private Panel pnlLine1;
        private Label lblRegPass;
        private TextBox txtRegPass;
        private Panel pnlLine2;
        private Label lblConfirm;
        private TextBox txtConfirm;
        private Panel pnlLine3;
        private Button btnRegister;
        private Button btnBackToLogin;
    }
}