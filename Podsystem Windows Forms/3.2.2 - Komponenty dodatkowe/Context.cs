using System;
using System.Drawing;
using System.Windows.Forms;

namespace KomponentyDodatkowe
{
    class Context
    {
        public Graphics Graphics
        {
            get;
            set;
        }

        public Pen Pencil
        {
            get;
            set;
        }

        public Point PreviousPoint
        {
            get;
            set;
        }

        public Point CurrentPoint
        {
            get;
            set;
        }

        public Context(PictureBox canvas)
        {
            Initialize(canvas);
        }

        private void Initialize(PictureBox canvas)
        {
            Graphics = canvas.CreateGraphics();
            Pencil = new Pen(Color.Black);
        }
    }
}
