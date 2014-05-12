using System;
using System.Drawing;

namespace PodsystemGDI
{
    public class HourHand : Hand
    {
        public HourHand(PointF center)
            : base(center) { }

        public override void Transform(DateTime dateTime)
        {
            Units = (dateTime.Hour % 12) * 5 + (dateTime.Minute % 60) / 12;
        }
    }
}
