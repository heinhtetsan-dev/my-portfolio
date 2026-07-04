#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace EcoLife_App
{
    partial class SignInView
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

            // User Input
            lblUser = new Label();
            txtUser = new TextBox();
            pnlLine1 = new Panel();

            // Password Input
            lblPass = new Label();
            txtPass = new TextBox();
            pnlLine2 = new Panel();

            // Buttons
            btnSignIn = new Button();
            btnGoToSignUp = new Button();

            SuspendLayout();

            // 
            // SignInView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnGoToSignUp);
            Controls.Add(btnSignIn);
            Controls.Add(pnlLine2);
            Controls.Add(txtPass);
            Controls.Add(lblPass);
            Controls.Add(pnlLine1);
            Controls.Add(txtUser);
            Controls.Add(lblUser);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular);
            Name = "SignInView";
            Size = new Size(500, 460);

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(46, 204, 113); // Theme Green
            lblTitle.Location = new Point(40, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Welcome Back";

            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(45, 80);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Text = "Enter your credentials to access your eco-dashboard.";

            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUser.ForeColor = Color.DarkGray;
            lblUser.Location = new Point(45, 130);
            lblUser.Name = "lblUser";
            lblUser.Text = "Username";

            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Segoe UI", 12F);
            txtUser.Location = new Point(45, 155);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(350, 22);
            txtUser.TabIndex = 1;

            // 
            // pnlLine1
            // 
            pnlLine1.BackColor = Color.LightGray;
            pnlLine1.Location = new Point(45, 180);
            pnlLine1.Name = "pnlLine1";
            pnlLine1.Size = new Size(350, 2);

            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPass.ForeColor = Color.DarkGray;
            lblPass.Location = new Point(45, 210);
            lblPass.Name = "lblPass";
            lblPass.Text = "Password";

            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Segoe UI", 12F);
            txtPass.Location = new Point(45, 235);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(350, 22);
            txtPass.TabIndex = 2;
            txtPass.UseSystemPasswordChar = true;

            // 
            // pnlLine2
            // 
            pnlLine2.BackColor = Color.LightGray;
            pnlLine2.Location = new Point(45, 260);
            pnlLine2.Name = "pnlLine2";
            pnlLine2.Size = new Size(350, 2);

            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(46, 204, 113); // Theme Green
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(45, 300);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(150, 45);
            btnSignIn.TabIndex = 3;
            btnSignIn.Text = "SIGN IN";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += BtnSignIn_Click;

            // 
            // btnGoToSignUp
            // 
            btnGoToSignUp.BackColor = Color.Transparent;
            btnGoToSignUp.Cursor = Cursors.Hand;
            btnGoToSignUp.FlatAppearance.BorderSize = 0;
            btnGoToSignUp.FlatStyle = FlatStyle.Flat;
            btnGoToSignUp.Font = new Font("Segoe UI", 10F);
            btnGoToSignUp.ForeColor = Color.Gray;
            btnGoToSignUp.Location = new Point(200, 300);
            btnGoToSignUp.Name = "btnGoToSignUp";
            btnGoToSignUp.Size = new Size(200, 45);
            btnGoToSignUp.TabIndex = 4;
            btnGoToSignUp.Text = "No account? Create one";
            btnGoToSignUp.TextAlign = ContentAlignment.MiddleLeft;
            btnGoToSignUp.UseVisualStyleBackColor = false;
            btnGoToSignUp.Click += BtnGoToSignUp_Click;

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblUser;
        private TextBox txtUser;
        private Panel pnlLine1;
        private Label lblPass;
        private TextBox txtPass;
        private Panel pnlLine2;
        private Button btnSignIn;
        private Button btnGoToSignUp;
    }
}