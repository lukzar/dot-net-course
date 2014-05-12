using System;
using System.Drawing;
using System.Windows.Forms;

namespace PodsystemGDI
{
    public partial class Clock : Form
    {
        private HourHand HourHand;
        private MinuteHand MinuteHand;
        private SecondHand SecondHand;

        private ClockFace ClockFace;

        public Clock()
        {
            InitializeComponent();
            InitializeClock();
        }

        private void InitializeClock()
        {
            PointF Center = new PointF(ClientRectangle.Width / 2, ClientRectangle.Height / 2);

            HourHand = new HourHand(Center) 
            { 
                Radius = 75,
                Width = 4,
                Color = Color.Black
            };
            MinuteHand = new MinuteHand(Center)
            {
                Radius = 100,
                Width = 4,
                Color = Color.Black
            };
            SecondHand = new SecondHand(Center)
            {
                Radius = 100,
                Width = 2,
                Color = Color.Red
            };

            ClockFace = new ClockFace(Center) 
            { 
                Radius = 130,
                Color = Color.Black,
                Font = new Font("Verdana", 15)
            };

            Paint += PaintClock;
            Timer.Tick += (sender, e) => Tick();

            Tick();

            Timer.Start();
        }

        private void PaintClock(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            ClockFace.Draw(g);

            HourHand.Draw(g);
            MinuteHand.Draw(g);
            SecondHand.Draw(g);
        }

        private void Tick()
        {
            SecondHand.Transform(DateTime.Now);
            HourHand.Transform(DateTime.Now);
            MinuteHand.Transform(DateTime.Now);

            Invalidate();
        }
    }
}
