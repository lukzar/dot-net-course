using System;
using System.Windows.Forms;

namespace WlasnyFormant
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();

            ProgressBar.Width = ClientRectangle.Width;
            ProgressBar.Height = ClientRectangle.Height;

            Timer.Tick += (sender, e) =>
            {
                if (ProgressBar.Value < ProgressBar.Max)
                {
                    ProgressBar.Value++;
                }
            };

            Timer.Start();
        }
    }
}
