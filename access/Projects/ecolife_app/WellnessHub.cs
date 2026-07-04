using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EcoLife_App
{
    public partial class WellnessHub : UserControl
    {
        private List<string> _availableActivities = new List<string>
        {
            "Recycling", "Cycling", "Planting", "Zero Waste", "Save Water"
        };

        private string _currentActivity = "";
        private double _totalScore = 0;
        private double _dailyGoal = 0;

        public WellnessHub()
        {
            InitializeComponent();
            LoadUserData();
            Button btnLogout = new Button()
            {
                Text = "Log Out",
                Size = new Size(100, 30),
                BackColor = Color.IndianRed, 
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            btnLogout.FlatAppearance.BorderSize = 0;
          
            btnLogout.Location = new Point(380, 45);

     
            btnLogout.Click += (s, e) =>
            {
                EcoDataStore.CurrentMember = "";
                AuthHost.Instance.LoadView(new SignInView()); 
            };

            this.Controls.Add(btnLogout);
            btnLogout.BringToFront();
        }

        private void LoadUserData()
        {
            lblWelcome.Text = $"Welcome, {EcoDataStore.CurrentMember}!";


            _totalScore = EcoDataStore.GetTotalImpact();
            _dailyGoal = EcoDataStore.GetUserGoal();

            UpdateScoreDisplay();
        }

        private void UpdateScoreDisplay()
        {
            lblTotalScore.Text = $"Current: {Math.Round(_totalScore)}";

            if (_dailyGoal > 0)
            {
                double remaining = _dailyGoal - _totalScore;
                if (remaining <= 0)
                {
                    lblRemaining.Text = "GOAL ACHIEVED! 🎉";
                    lblRemaining.ForeColor = Color.SeaGreen;
                }
                else
                {
                    lblRemaining.Text = $"Remaining: {Math.Round(remaining)}";
                    lblRemaining.ForeColor = Color.Orange;
                }
                btnSetGoal.Text = $"Goal: {_dailyGoal}";
            }
            else
            {
                lblRemaining.Text = "Set a goal first!";
                lblRemaining.ForeColor = Color.Gray;
            }
        }

        // --- SET GOAL LOGIC (Input Dialog) ---
        private void BtnSetGoal_Click(object sender, EventArgs e)
        {
           
            Form inputForm = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Set Daily Target",
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false
            };
            Label lbl = new Label() { Left = 20, Top = 20, Text = "Enter Target Impact Points:" };
            TextBox txt = new TextBox() { Left = 20, Top = 50, Width = 240 };
            Button btnOk = new Button() { Text = "Save", Left = 180, Top = 80, Width = 80, DialogResult = DialogResult.OK };

            inputForm.Controls.Add(lbl);
            inputForm.Controls.Add(txt);
            inputForm.Controls.Add(btnOk);
            inputForm.AcceptButton = btnOk;

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                if (double.TryParse(txt.Text, out double newGoal) && newGoal > 0)
                {
                    _dailyGoal = newGoal;
                    EcoDataStore.SetUserGoal(_dailyGoal); // DB 
                    UpdateScoreDisplay(); // UI Update
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }
        }

 
        private void BtnOpenMenu_Click(object sender, EventArgs e)
        {
            var popup = new ActivityPopup(_availableActivities);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                _currentActivity = popup.SelectedActivity;
                SetupMetricsUI(_currentActivity);
            }
        }
        private void SetupMetricsUI(string activity)
        {
            lblCurrentActivity.Text = $"Selected: {activity}";
            grpInputs.Visible = true;
            txtM1.Clear(); txtM2.Clear(); txtM3.Clear();

            switch (activity)
            {
                case "Recycling": SetLabels("Weight (kg)", "Material Type", "Bins Filled"); break;
                case "Cycling": SetLabels("Distance (km)", "Time (min)", "Avg Speed (km/h)"); break;
                case "Planting": SetLabels("Trees Planted", "Soil Used (kg)", "Hours Spent"); break;
                case "Zero Waste": SetLabels("Plastic Saved (g)", "Meals Cooked", "Cost Saved ($)"); break;
                case "Save Water": SetLabels("Shower Time (min)", "Buckets Saved", "Leaks Fixed"); break;
            }
        }

        private void SetLabels(string m1, string m2, string m3)
        {
            lblM1.Text = m1; lblM2.Text = m2; lblM3.Text = m3;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtM1.Text) ||
                string.IsNullOrWhiteSpace(txtM2.Text) ||
                string.IsNullOrWhiteSpace(txtM3.Text))
            {
                MessageBox.Show("Please fill in all 3 metrics.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double val1 = double.TryParse(txtM1.Text, out double v1) ? v1 : 0;
            double val2 = double.TryParse(txtM2.Text, out double v2) ? v2 : 0;

            double points = 0;
            switch (_currentActivity)
            {
                case "Recycling": points = val1 * 5 + val2; break;
                case "Cycling": points = val1 * 10; break;
                case "Planting": points = val1 * 50; break;
                case "Zero Waste": points = val1 * 2; break;
                case "Save Water": points = val1 * 3; break;
            }

            EcoDataStore.LogEcoAction(_currentActivity, points);

            _totalScore += points;
            UpdateScoreDisplay(); // Score Increase ,remaing decrease

            MessageBox.Show($"Activity Logged! +{points} Points", "Success");

            _availableActivities.Remove(_currentActivity);
            grpInputs.Visible = false;
            lblCurrentActivity.Text = "Activity Completed!";
            _currentActivity = "";
        }
    }
}