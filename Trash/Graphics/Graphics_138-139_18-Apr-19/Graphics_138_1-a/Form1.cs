using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphics_138_139_18_Apr_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var p = new Pen(Color.Black, 1);
            int side = 100;
            int h = 500 - (int)(side * Math.Sqrt(3) / 2);
            var trPointL = new Point(500, 500);
            var trPointR = new Point(500 + side, 500);
            var trPointT = new Point((500 * 2 + side) / 2, h);
            g.DrawLine(p, trPointL, trPointR);
            g.DrawLine(p, trPointR, trPointT);
            g.DrawLine(p, trPointT, trPointL);

            g.DrawEllipse(p, trPointL.X - side / 2, trPointL.Y - side / 2, side, side);
            g.DrawEllipse(p, trPointR.X - side / 2, trPointR.Y - side / 2, side, side);
            g.DrawEllipse(p, trPointT.X - side / 2, trPointT.Y - side / 2, side, side);

            g.DrawEllipse(p, trPointL.X - side / 2, trPointT.Y - side / 2, side * 2, side * 2);
        }
    }
}
