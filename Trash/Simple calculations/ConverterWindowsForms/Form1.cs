using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            currencyBox.Text = "USD";
        }

        public void NumericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            converCurrency();
        }

        private void currencyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            converCurrency();
        }

        void converCurrency()
        {
            var value = double.Parse(NumericUpDownAmount.Value.ToString());

            switch (currencyBox.Text)
            {
                case "USD":
                    value = value / 1.79549;
                    break;
                case "EUR":
                    value = value / 1.95583;
                    break;
                case "GBP":
                    value = value / 2.53405;
                    break;
                default:
                    break;
            }

            resultLabel.Text = NumericUpDownAmount.Value.ToString() + " BGN = " + Math.Round(value, 2).ToString() +
                               " " + currencyBox.Text;
        }

    }
}
