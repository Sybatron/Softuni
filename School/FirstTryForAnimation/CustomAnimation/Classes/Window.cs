using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CustomAnimation.Classes
{
    public class Window
    {
        private Size size;
        private Point position = new Point(0, 0);

        public Size Size { get => size; set => size = value; }
        public Point Position { get => position; set => position = value; }
        public SolidBrush Brush { get; set; }

        public Window(int side, SolidBrush brush)
        {
            size = new Size(side, side);
            this.Brush = brush;
        }

    }
}
