using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Mind_Break.GAMES.Quiz
{
    public partial class WinQuiz : Form
    {
        public WinQuiz()
        {
            InitializeComponent();
            Rewardlabel.Text = File.ReadAllText(".\\TEXT\\takenMoney.txt") + "Рубли";
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
