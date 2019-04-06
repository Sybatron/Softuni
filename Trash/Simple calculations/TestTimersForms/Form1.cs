using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTimersForms
{
    public partial class Form1 : Form
    {
        public int seconds;
        public int mins;
        public int hours;
        public Form1()
        {
            InitializeComponent();
            DateLabel.Text = DateTime.Today.ToShortDateString();
            seconds = DateTime.Now.Second;
            mins = DateTime.Now.Minute;
            hours = DateTime.Now.Hour;
            this.AllowTransparency = true;
            this.TransparencyKey = Color.Black;
            this.BackColor = Color.Black;
        }

        private void ChangeTimeTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            DateLabel.Text = DateTime.Today.ToShortDateString();
            if (seconds==60)
            {
                seconds = 0;
                mins++;
            }
            if(mins==60)
            {
                mins = 0;
                hours++;
            }
            if(hours==24)
            {
                hours = 0;
            }

            TimeLabel.Text = String.Format("{0:00} : {1:00} : {2:00}",hours,mins,seconds);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seconds = DateTime.Now.Second;
            mins = DateTime.Now.Minute;
            hours = DateTime.Now.Hour;
        }
    }
}
