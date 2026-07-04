using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EcoLife_App
{
    public partial class SignUpView : UserControl
    {
        private bool _isDragging = false;
        private Point _dragStartPoint;

        public SignUpView()
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

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegUser.Text)) { MessageBox.Show("Username required"); return; }
            if (txtRegPass.Text.Length != 12) { MessageBox.Show("Password must be 12 chars"); return; }
            if (txtRegPass.Text != txtConfirm.Text) { MessageBox.Show("Passwords do not match"); return; }

            EcoDataStore.CreateAccount(txtRegUser.Text.Trim(), txtRegPass.Text);
            MessageBox.Show("Account Created!");
            AuthHost.Instance.LoadView(new SignInView());
        }

        private void BtnBackToLogin_Click(object sender, EventArgs e) => AuthHost.Instance.LoadView(new SignInView());
    }
}