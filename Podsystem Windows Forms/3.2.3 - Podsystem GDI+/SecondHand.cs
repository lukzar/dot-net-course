using System;
using System.Drawing;

namespace PodsystemGDI
{
    public class SecondHand : Hand
    {
        public SecondHand(PointF center) 
            : base(center) { }

        public override void Transform(DateTime dateTime)
        {
            Units = dateTime.Second % 60;
        }
    }
}
