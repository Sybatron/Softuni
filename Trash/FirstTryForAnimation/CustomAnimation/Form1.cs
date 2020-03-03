using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using CustomAnimation.Classes;

namespace CustomAnimation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            
            var shop = new Shop(new Point(200, 100), new Size(500, 300), new SolidBrush(Color.SaddleBrown), ref g);
            #region Windows
            shop.addWindow(new Window(50, new SolidBrush(Color.Aqua)));
            shop.windows[0].position =
               new Point(shop.original.X + 50, shop.original.Y + 50);

            shop.addWindow(new Window(50, new SolidBrush(Color.Aqua)));
            shop.windows[1].position =
               new Point(shop.original.X + shop.original.Width - 50 * 2, shop.original.Y + 50);
            g.FillRectangle(shop.windows[0].brush, new Rectangle(shop.windows[0].position, shop.windows[0].size));
            g.FillRectangle(shop.windows[1].brush, new Rectangle(shop.windows[1].position, shop.windows[1].size));

            #endregion
        }


    }
}
