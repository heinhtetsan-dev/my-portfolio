#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace EcoLife_App
{
    partial class AuthHost
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
        
            pnlBrand = new Panel();
            lblSlogan = new Label();
            lblBrandTitle = new Label();

      
            pnlContainer = new Panel();

            // Window Controls
            btnCloseApp = new Button();

            pnlBrand.SuspendLayout();
            SuspendLayout();

            // 
            // AuthHost (Main Window)
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500); // Wide Screen Style
            Controls.Add(btnCloseApp);
            Controls.Add(pnlContainer);
            Controls.Add(pnlBrand);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthHost";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EcoLife Authentication";

            // 
            // pnlBrand (Left Side - Green)
            // 
            pnlBrand.BackColor = Color.FromArgb(46, 204, 113); // Emerald Green
            pnlBrand.Controls.Add(lblSlogan);
            pnlBrand.Controls.Add(lblBrandTitle);
            pnlBrand.Dock = DockStyle.Left;
            pnlBrand.Size = new Size(300, 500);

            // 
            // lblBrandTitle
            // 
            lblBrandTitle.AutoSize = true;
            lblBrandTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblBrandTitle.ForeColor = Color.White;
            lblBrandTitle.Location = new Point(40, 150);
            lblBrandTitle.Text = "EcoLife";

            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.Font = new Font("Segoe UI Light", 14F);
            lblSlogan.ForeColor = Color.FromArgb(230, 250, 240);
            lblSlogan.Location = new Point(45, 200);
            lblSlogan.Text = "Live Healthy.\nLive Green.";

            // 
            // pnlContainer (Right Side - Holder)
            // 
            pnlContainer.Location = new Point(300, 40); // Top bar chyan htar thi
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(500, 460);
            pnlContainer.TabIndex = 1;

            // 
            // btnCloseApp (Top Right X)
            // 
            btnCloseApp.FlatAppearance.BorderSize = 0;
            btnCloseApp.FlatStyle = FlatStyle.Flat;
            btnCloseApp.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnCloseApp.ForeColor = Color.Gray;
            btnCloseApp.Location = new Point(760, 5);
            btnCloseApp.Name = "btnCloseApp";
            btnCloseApp.Size = new Size(35, 30);
            btnCloseApp.Text = "✕";
            btnCloseApp.Cursor = Cursors.Hand;
            btnCloseApp.Click += BtnCloseApp_Click;

            pnlBrand.ResumeLayout(false);
            pnlBrand.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlBrand;
        private Panel pnlContainer;
        private Label lblBrandTitle;
        private Label lblSlogan;
        private Button btnCloseApp;
    }
}