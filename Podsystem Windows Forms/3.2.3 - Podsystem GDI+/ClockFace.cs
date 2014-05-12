using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PodsystemGDI
{
    public class ClockFace
    {
        protected const int NUM_HOURS = 12;

        protected PointF Center;

        protected StringFormat Format = new StringFormat() 
        { 
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };

        public Color Color
        {
            get;
            set;
        }

        public int Radius
        {
            get;
            set;
        }

        public Font Font
        {
            get;
            set;
        }

        public ClockFace(PointF center)
        {
            Center = center;
        }

        public void Draw(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            DrawFrame(g);
            DrawNumbers(g);
            DrawPin(g);
        }

        protected void DrawFrame(Graphics g)
        {
            g.DrawEllipse(new Pen(Color), new RectangleF(
                Center.X - Radius,
                Center.Y - Radius,
                2 * Radius,
                2 * Radius
            ));
        }

        protected void DrawNumbers(Graphics g)
        {
            float x;
            float y;

            int degree = 360 / NUM_HOURS;

            for (int i = 1; i <= NUM_HOURS; i++)
            {
                x = Math.Abs(GetCos(i * degree + 90) * (Radius - 20) - Center.X);
                y = Math.Abs(GetSin(i * degree + 90) * (Radius - 20) - Center.Y);

                g.DrawString(i.ToString(), Font, new SolidBrush(Color), x, y, Format);

            }
        }

        public void DrawPin(Graphics g)
        {
            g.FillEllipse(Brushes.Black, new RectangleF(
                Center.X - 5,
                Center.Y - 5,
                2 * 5,
                2 * 5
            ));
        }

        protected float GetSin(float degree)
        {
            return (float) Math.Sin(MathHelper.ToRadian(degree));
        }

        protected float GetCos(float degree)
        {
            return (float) Math.Cos(MathHelper.ToRadian(degree));
        }
    }
}
