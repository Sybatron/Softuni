using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMe
{
    public partial class Form1 : Form
    {
        CongratulationsForm CongratsHelper = new CongratulationsForm();
        public List<Button> buttons = new List<Button>();

        public Form1()
        {
            InitializeComponent();
        }

        public void CatchMeButton_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = ClientSize.Width - CatchMeButton.ClientSize.Width;
            var maxHeight = ClientSize.Height - CatchMeButton.ClientSize.Height;
            CatchMeButton.Location = new Point(rand.Next(maxWidth), rand.Next(maxHeight));

            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Location = new Point(rand.Next(maxWidth), rand.Next(maxHeight));
            }
        }

        private void CatchMeButton_Click(object sender, EventArgs e)
        {
            Final();
        }

        void Final()
        {
            CongratsHelper.Show();
            CongratsHelper.Location = CatchMeButton.Location;
        }

        private void buttonSpawner_Tick(object sender, EventArgs e)
        {
            Button newButton = new Button();
            buttons.Add(newButton);
            this.Controls.Add(newButton);
            Random rand = new Random();
            newButton.BackColor = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255), rand.Next(255));
            var maxWidth = ClientSize.Width - newButton.ClientSize.Width;
            var maxHeight = ClientSize.Height - newButton.ClientSize.Height;
            newButton.Location = new Point(rand.Next(maxWidth), rand.Next(maxHeight));
        }
    }
}
