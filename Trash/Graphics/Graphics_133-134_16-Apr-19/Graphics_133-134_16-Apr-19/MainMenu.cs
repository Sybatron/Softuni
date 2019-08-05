using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphics_133_134_16_Apr_19
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void newForm<T>() where T : Form, new()
        {
            T formName = new T();
            formName.Show();
            Hide();
        }

        private void B133_1_Click(object sender, EventArgs e)
        {
            newForm<P133_1>();
        }

        private void B134_2_Click(object sender, EventArgs e)
        {
            newForm<P134_2>();
        }

        private void B134_3_Click(object sender, EventArgs e)
        {
            newForm<P134_3>();
        }

        private void B134_3_2_Click(object sender, EventArgs e)
        {
            newForm<P134_3_2>();
        }

        private void B134_3_3_Click(object sender, EventArgs e)
        {
            newForm<P134_3_3>();
        }

        private void B134_4_Click(object sender, EventArgs e)
        {
            newForm<P134_4>();
        }
    }
}
