using System;
using System.Drawing;
using System.Windows.Forms;

namespace WlasnyFormant
{
    public class SmoothProgressBar : UserControl
    {
        protected Color ColorBar = Color.Blue;
        protected int Minimum = 0;
        protected int Maximum = 100;
        protected int CurrentValue = 0;

        #region Properties

        public Color Color
        {
            get
            {
                return ColorBar;
            }
            set
            {
                ColorBar = value;

                Invalidate();
            }
        }

        public int Min
        {
            get
            {
                return Minimum;
            }
            set
            {
                if (value < 0)
                {
                    Minimum = 0;
                }
                else if (value > Maximum)
                {
                    Minimum = Maximum;
                }
                else
                {
                    Minimum = value;
                }

                if (CurrentValue < Minimum)
                {
                    CurrentValue = Minimum;
                }

                Invalidate();
            }
        }

        public int Max
        {
            get
            {
                return Maximum;
            }
            set
            {
                if (value < Minimum)
                {
                    Maximum = Minimum;
                }
                else
                {
                    Maximum = value;
                }

                if (CurrentValue > Maximum)
                {
                    CurrentValue = Maximum;
                }

                Invalidate();
            }
        }

        public int Value
        {
            get
            {
                return CurrentValue;
            }
            set
            {
                int oldValue = CurrentValue;

                if (value < Minimum)
                {
                    CurrentValue = Minimum;
                }
                else if (value > Maximum)
                {
                    CurrentValue = Maximum;
                }
                else
                {
                    CurrentValue = value;
                }

                Invalidate(MakeRectangleToRepaint(oldValue, CurrentValue));
            }
        }

        #endregion

        protected Rectangle MakeRectangleToRepaint(int oldValue, int newValue)
        {
            float newPercent = (float) (newValue - Minimum) / (float) (Maximum - Minimum);
            int newWidth = (int) (ClientRectangle.Width * newPercent);

            float oldPercent = (float) (oldValue - Minimum) / (float) (Maximum - Minimum);
            int oldWidth = (int) (ClientRectangle.Width * oldPercent);

            Rectangle updateRectangle = new Rectangle();
            updateRectangle.X = newWidth > oldWidth ? oldWidth : newWidth;
            updateRectangle.Width = Math.Abs(newWidth - oldWidth);
            updateRectangle.Height = Height;

            return updateRectangle;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            float percent = (float) (CurrentValue - Minimum) / (float) (Maximum - Minimum);

            Rectangle rectangle = ClientRectangle;
            rectangle.Width = (int) (rectangle.Width * percent);

            g.FillRectangle(new SolidBrush(ColorBar), rectangle);

            g.Dispose();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SmoothProgressBar
            // 
            this.Name = "SmoothProgressBar";
            this.Size = new System.Drawing.Size(200, 50);
            this.ResumeLayout(false);
        }
    }
}
