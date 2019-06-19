using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        int freq = 100;
        private Thread waiter = null;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Paint(object sender, PaintEventArgs e)
        {
            await Draw(e);
        }

        private async Task Draw(PaintEventArgs old)
        {

            var task = Task.Factory.StartNew(() =>
            {
                using (Graphics g = CreateGraphics())
                {
                    var e = new PaintEventArgs(g, old.ClipRectangle);

                    try
                    {
                        Rectangle rect = new Rectangle(50, 50, 100, 50);
                        Brush brush = new SolidBrush(Color.Black);
                        for (int i = 0; i < 5; i++)
                        {
                            g.Clear(this.BackColor);
                            g.FillRectangle(brush, rect);
                            Thread.Sleep(freq);
                            rect.X += 10;
                            if (rect.X >= ClientSize.Width)
                            {
                                rect.X = 0;
                            }

                        }
                        base.OnPaint(e);
                      
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
            });
            task.Dispose();
        }
    }
}