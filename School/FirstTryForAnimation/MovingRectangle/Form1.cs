using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var freq = 100;
            var g = e.Graphics;
            var rect = new Rectangle(50, 50, 100, 50);
            var brush=new SolidBrush(Color.Black);

            for (int i = 0; i < 1000; i++)
            {
                g.FillRectangle(brush, rect);
                System.Threading.Thread.Sleep(freq);
                g.Clear(this.BackColor);
                rect.X += 10;
                if (rect.X >= ClientSize.Width)
                {
                    rect.X = 0;
                }
            }

        }
    }
}
