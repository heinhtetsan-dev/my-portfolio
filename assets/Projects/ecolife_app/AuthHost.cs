using System;
using System.Drawing;
using System.Windows.Forms;

namespace EcoLife_App
{
    public partial class AuthHost : Form
    {
        public static AuthHost Instance;
        public Panel ContainerPanel => pnlContainer;

    
        private bool _isDragging = false;
        private Point _dragStartPoint;

        public AuthHost()
        {
            InitializeComponent();
            Instance = this;

            EcoDataStore.InitializeDatabase();
            LoadView(new SignInView());

       
            AssignDrag(this);
            AssignDrag(pnlBrand);
            AssignDrag(lblBrandTitle);
            AssignDrag(lblSlogan);
        }

        private void AssignDrag(Control c)
        {
            c.MouseDown += (s, e) => {
                if (e.Button == MouseButtons.Left) { _isDragging = true; _dragStartPoint = e.Location; }
            };
            c.MouseMove += (s, e) => {
                if (_isDragging)
                {
                    this.Location = new Point(this.Location.X + (e.X - _dragStartPoint.X),
                                              this.Location.Y + (e.Y - _dragStartPoint.Y));
                }
            };
            c.MouseUp += (s, e) => { _isDragging = false; };
        }

        private void BtnCloseApp_Click(object? sender, EventArgs e) => Application.Exit();

        public void LoadView(UserControl view)
        {
            pnlContainer.Controls.Clear();
            view.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(view);
        }
    }
}