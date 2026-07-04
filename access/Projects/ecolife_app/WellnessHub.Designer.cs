#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace EcoLife_App
{
    partial class WellnessHub
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            btnSetGoal = new Button(); // NEW
            lblRemaining = new Label(); // NEW
            lblTotalScore = new Label();
            lblWelcome = new Label();

            btnOpenMenu = new Button();
            lblCurrentActivity = new Label();
            grpInputs = new GroupBox();

            lblM1 = new Label(); txtM1 = new TextBox();
            lblM2 = new Label(); txtM2 = new TextBox();
            lblM3 = new Label(); txtM3 = new TextBox();
            btnCalculate = new Button();

            pnlHeader.SuspendLayout();
            grpInputs.SuspendLayout();
            SuspendLayout();

            // WellnessHub
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(grpInputs);
            Controls.Add(lblCurrentActivity);
            Controls.Add(btnOpenMenu);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.75F);
            Name = "WellnessHub";
            Size = new Size(500, 460);

            // pnlHeader
            pnlHeader.BackColor = Color.FromArgb(245, 245, 245);
            pnlHeader.Controls.Add(btnSetGoal);
            pnlHeader.Controls.Add(lblRemaining);
            pnlHeader.Controls.Add(lblTotalScore);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Size = new Size(500, 100);

            // lblWelcome
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Light", 16F);
            lblWelcome.Location = new Point(20, 10);
            lblWelcome.Text = "Hello, Member!";

            // btnSetGoal (NEW BUTTON)
            btnSetGoal.BackColor = Color.Gray;
            btnSetGoal.FlatStyle = FlatStyle.Flat;
            btnSetGoal.ForeColor = Color.White;
            btnSetGoal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSetGoal.Location = new Point(380, 15);
            btnSetGoal.Size = new Size(100, 30);
            btnSetGoal.Text = "SET GOAL";
            btnSetGoal.UseVisualStyleBackColor = false;
            btnSetGoal.Click += BtnSetGoal_Click;

            // lblTotalScore
            lblTotalScore.AutoSize = true;
            lblTotalScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalScore.ForeColor = Color.FromArgb(46, 204, 113);
            lblTotalScore.Location = new Point(20, 50);
            lblTotalScore.Text = "Current: 0 pts";

            // lblRemaining (NEW LABEL)
            lblRemaining.AutoSize = true;
            lblRemaining.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRemaining.ForeColor = Color.Orange;
            lblRemaining.Location = new Point(200, 50);
            lblRemaining.Text = "Remaining: 0 pts";

            // btnOpenMenu
            btnOpenMenu.BackColor = Color.FromArgb(46, 204, 113);
            btnOpenMenu.FlatStyle = FlatStyle.Flat;
            btnOpenMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenMenu.ForeColor = Color.White;
            btnOpenMenu.Location = new Point(150, 120);
            btnOpenMenu.Size = new Size(200, 50);
            btnOpenMenu.Text = "SELECT ACTIVITY";
            btnOpenMenu.UseVisualStyleBackColor = false;
            btnOpenMenu.Click += BtnOpenMenu_Click;

            // lblCurrentActivity
            lblCurrentActivity.AutoSize = false;
            lblCurrentActivity.Size = new Size(500, 30);
            lblCurrentActivity.TextAlign = ContentAlignment.MiddleCenter;
            lblCurrentActivity.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblCurrentActivity.ForeColor = Color.Gray;
            lblCurrentActivity.Location = new Point(0, 180);
            lblCurrentActivity.Text = "No activity selected";

            // grpInputs
            grpInputs.Controls.Add(btnCalculate);
            grpInputs.Controls.Add(txtM3); grpInputs.Controls.Add(lblM3);
            grpInputs.Controls.Add(txtM2); grpInputs.Controls.Add(lblM2);
            grpInputs.Controls.Add(txtM1); grpInputs.Controls.Add(lblM1);
            grpInputs.Location = new Point(25, 210);
            grpInputs.Size = new Size(450, 240);
            grpInputs.Text = "Metrics";
            grpInputs.Visible = false;

            // Metrics Position
            lblM1.AutoSize = true; lblM1.Location = new Point(20, 35); lblM1.Text = "Metric 1";
            txtM1.Location = new Point(20, 60); txtM1.Size = new Size(120, 25);

            lblM2.AutoSize = true; lblM2.Location = new Point(160, 35); lblM2.Text = "Metric 2";
            txtM2.Location = new Point(160, 60); txtM2.Size = new Size(120, 25);

            lblM3.AutoSize = true; lblM3.Location = new Point(300, 35); lblM3.Text = "Metric 3";
            txtM3.Location = new Point(300, 60); txtM3.Size = new Size(120, 25);

            // Calculate Button
            btnCalculate.BackColor = Color.FromArgb(52, 152, 219);
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCalculate.Location = new Point(125, 150);
            btnCalculate.Size = new Size(200, 45);
            btnCalculate.Text = "LOG DATA";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += BtnCalculate_Click;

            pnlHeader.ResumeLayout(false); pnlHeader.PerformLayout();
            grpInputs.ResumeLayout(false); grpInputs.PerformLayout();
            ResumeLayout(false); PerformLayout();
        }

        private Panel pnlHeader;
        private Label lblWelcome;
        private Label lblTotalScore;
        private Label lblRemaining;
        private Button btnSetGoal;
        private Button btnOpenMenu;
        private Label lblCurrentActivity;
        private GroupBox grpInputs;
        private Label lblM1; private TextBox txtM1;
        private Label lblM2; private TextBox txtM2;
        private Label lblM3; private TextBox txtM3;
        private Button btnCalculate;
    }
}