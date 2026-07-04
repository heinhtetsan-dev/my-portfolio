using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EcoLife_App
{
    public partial class ActivityPopup : Form
    {
        public string SelectedActivity { get; private set; } = "";
        private List<string> _availableActivities;

        private bool _isDragging = false;
        private Point _dragStartPoint;

        public ActivityPopup(List<string> activities)
        {
            InitializeComponent();
            _availableActivities = activities;

            // Form Settings
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(720, 240);
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.Padding = new Padding(10);

            // Drag Events
            this.MouseDown += (s, e) => { if (e.Button == MouseButtons.Left) { _isDragging = true; _dragStartPoint = e.Location; } };
            this.MouseMove += (s, e) => { if (_isDragging) this.Location = new Point(this.Location.X + (e.X - _dragStartPoint.X), this.Location.Y + (e.Y - _dragStartPoint.Y)); };
            this.MouseUp += (s, e) => { _isDragging = false; };

            GenerateUI();
        }

        private void GenerateUI()
        {
            Label lblTitle = new Label();
            lblTitle.Text = "Select Activity";
            lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.AutoSize = true;
            this.Controls.Add(lblTitle);

            Button btnClose = new Button()
            {
                Text = "X",
                ForeColor = Color.Gray,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(30, 30),
                Location = new Point(this.Width - 40, 10),
                Cursor = Cursors.Hand
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
            this.Controls.Add(btnClose);



            if (_availableActivities.Count == 0)
            {
                
                Label lbl = new Label()
                {
                    Text = "All Done! 🎉",
                    ForeColor = Color.SeaGreen,
                    Font = new Font("Segoe UI", 20, FontStyle.Bold),
                    AutoSize = false,
                    TextAlign = ContentAlignment.BottomCenter, 
                    Dock = DockStyle.Top,
                    Height = 120
                };
                this.Controls.Add(lbl);

          
                Button btnFinish = new Button()
                {
                    Text = "Close",
                    Size = new Size(120, 40),
                    BackColor = Color.SeaGreen,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };
                btnFinish.FlatAppearance.BorderSize = 0;

            
                btnFinish.Location = new Point((this.Width - btnFinish.Width) / 2, 140);

 
                btnFinish.Click += (s, e) => this.DialogResult = DialogResult.Cancel;

                this.Controls.Add(btnFinish);
                btnFinish.BringToFront(); 
                return;
            }

            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Location = new Point(20, 50);
            panel.Size = new Size(680, 170);
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.WrapContents = false;
            panel.AutoScroll = true;
            this.Controls.Add(panel);

            foreach (string act in _availableActivities)
            {
                Button btn = new Button();
                btn.Text = act;
                btn.Size = new Size(140, 100);
                btn.BackColor = Color.FromArgb(50, 50, 50);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;
                btn.Margin = new Padding(0, 0, 15, 0);

                // Mouse Hover Effect
                btn.MouseEnter += (s, e) => btn.BackColor = Color.SeaGreen;
                btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(50, 50, 50);

                btn.Click += (s, e) => {
                    SelectedActivity = act;
                    this.DialogResult = DialogResult.OK;
                };

                panel.Controls.Add(btn);
            }
        }
    }
}