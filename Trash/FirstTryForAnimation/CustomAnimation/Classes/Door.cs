using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CustomAnimation
{
    public class Door
    {
        public Size size;
        public Point position = new Point(0, 0);
        public SolidBrush brush;

        public Door(Size inputSize, SolidBrush inputBrush)
        {
            size = inputSize;
            brush = inputBrush;
        }
    }
}
