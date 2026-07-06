using System;
using System.Drawing;
using System.Windows.Forms;

namespace EcoLife_App
{
    public partial class SignInView : UserControl
    {
        private int _failedAttempts = 0;
        private bool _isDragging = false;
        private Point _dragStartPoint;

        public SignInView()
        {
            InitializeComponent();
            AssignDrag(this);
            AssignDrag(lblTitle);
            AssignDrag(lblSubtitle);
        }

        private void AssignDrag(Control c)
        {
            c.MouseDown += (s, e) => {
                if (e.Button == MouseButtons.Left) { _isDragging = true; _dragStartPoint = e.Location; }
            };
            c.MouseMove += (s, e) => {
                if (_isDragging && this.ParentForm != null)
                {
                    this.ParentForm.Location = new Point(this.ParentForm.Location.X + (e.X - _dragStartPoint.X),
                                                         this.ParentForm.Location.Y + (e.Y - _dragStartPoint.Y));
                }
            };
            c.MouseUp += (s, e) => { _isDragging = false; };
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (_failedAttempts >= 3) { MessageBox.Show("Locked due to too many failed attempts."); return; }

            string u = txtUser.Text.Trim();
            string p = txtPass.Text;

            if (EcoDataStore.ValidateUser(u, p))
            {
                EcoDataStore.CurrentMember = u;
                AuthHost.Instance.LoadView(new WellnessHub());
            }
            else
            {
                _failedAttempts++;
                MessageBox.Show($"Login Failed. Attempts left: {3 - _failedAttempts}");
            }
        }

        private void BtnGoToSignUp_Click(object sender, EventArgs e) => AuthHost.Instance.LoadView(new SignUpView());
    }
}