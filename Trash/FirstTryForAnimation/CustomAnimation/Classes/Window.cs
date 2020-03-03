using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace CustomAnimation
{
    public class Window
    {
        public Size size;
        public Point position = new Point(0, 0);
        public SolidBrush brush;

        public Window(int side, SolidBrush inputBrush)
        {
            size = new Size(side, side);
            brush = inputBrush;
        }
    }
}
