using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected async override void OnPaint(PaintEventArgs e)
        {
            await DoAsyncWork(e);
        }
        private async Task DoAsyncWork(PaintEventArgs e)
        {
            var task =Task.Factory.StartNew(() =>
               {
                   try
                   {
                       var g = e.Graphics;
                       Rectangle rect = new Rectangle(50, 50, 100, 50);
                       Brush brush = new SolidBrush(Color.Black);
                       int freq = 100;

                       for (int i = 0; i < 50; i++)
                       {
                           g.Clear(this.BackColor);
                           g.FillRectangle(brush, rect);

                           rect.X += 10;
                           if (rect.X >= ClientSize.Width)
                           {
                               rect.X = 0;
                           }
                           Thread.Sleep(freq);
                       }
                       base.OnPaint(new PaintEventArgs(g, base.DisplayRectangle));
                   }
                   catch (Exception ex)
                   {

                       System.Console.WriteLine(ex.Message);
                   }
                   
               });

            task.Dispose();
        }

    }
}