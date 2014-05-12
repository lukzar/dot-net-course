using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PodsystemGDI
{
    public abstract class Hand
    {
        protected PointF Center;
        protected int Units;

        public Color Color
        {
            get;
            set;
        }

        public float Width
        {
            get;
            set;
        }

        public int Radius
        {
            get;
            set;
        }

        public Hand(PointF center)
        {
            Center = center;
        }

        public abstract void Transform(DateTime dateTime);

        protected double ToRadian(double unit)
        {
            return unit * Math.PI / 30.0 - Math.PI / 2.0;
        }

        public void Draw(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.DrawLine(
                new Pen(Color, Width),
                Center,
                new PointF(
                    Center.X + Radius * (float) Math.Cos(ToRadian(Units)),
                    Center.Y + Radius * (float) Math.Sin(ToRadian(Units))
                )
            );
        }
    }
}
