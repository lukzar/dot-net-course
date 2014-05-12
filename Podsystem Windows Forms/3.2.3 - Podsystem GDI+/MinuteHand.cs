using System;
using System.Drawing;

namespace PodsystemGDI
{
    public class MinuteHand : Hand
    {
        public MinuteHand(PointF center)
            : base(center) { }

        public override void Transform(DateTime dateTime)
        {
            Units = dateTime.Minute % 60;
        }
    }
}
