using System;
using System.Drawing;
using System.Windows.Forms;

namespace KomponentyDodatkowe
{
    public partial class Window : Form
    {
        private Context Context;

        public Window()
        {
            InitializeComponent();

            Context = new Context(Canvas);

            AttachEventHandlerToMenu();
            AttachEventHandlerToCanvas();
            UpdateStatusBar();
        }

        private void AttachEventHandlerToCanvas()
        {
            Canvas.MouseMove += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
                {
                    Context.CurrentPoint = e.Location;

                    Context.Graphics.DrawLine(Context.Pencil, Context.PreviousPoint, Context.CurrentPoint);
                }

                Context.PreviousPoint = e.Location;
            };
        }

        private void AttachEventHandlerToMenu()
        {
            MenuProgramExitItem.Click += (sender, e) =>
            {
                Application.Exit();
            };
        }

        private void UpdateStatusBar()
        {
            Canvas.MouseMove += (sender, e) =>
            {
                MousePosition.Text = String.Format("x:{0} y:{1}", e.Location.X, e.Location.Y);
            };
        }
        
    }
}
