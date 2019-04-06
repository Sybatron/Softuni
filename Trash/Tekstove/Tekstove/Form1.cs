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
            countSav.Text = "0";
            countDum.Text = "0";
        }

        private void doIt_Click(object sender, EventArgs e)
        {
            if (input.Text.Length > 0)
            {
                if (radioUpper.Checked)
                {
                    string TheOutput = input.Text;
                    TheOutput = TheOutput.ToUpper();
                    output.Text = TheOutput;
                }
                else if (radioLower.Checked)
                {
                    string TheOutput = input.Text;
                    TheOutput = TheOutput.ToLower();
                    output.Text = TheOutput;
                }
                else if (radioCount.Checked)
                {
                    int broi = 0;
                    for (int i = 0; i < input.Text.Length - 1; i++)
                    {
                        if (input.Text[i] == ' ' && input.Text[i + 1] != ' ')
                        {
                            broi++;
                        }
                    }
                    if (input.Text[input.Text.Length - 1] != ' ')
                    {
                        broi++;
                    }
                    countDum.Text = (broi).ToString();
                }
                else if (radioSearch.Checked)
                {
                    int index, broi = 0;
                    string text = input.Text, textSearch = search.Text;
                    index = text.IndexOf(textSearch);
                    while (index != -1)
                    {
                        broi++; index = text.IndexOf(textSearch, index + 1);
                    }
                    countSav.Text = broi.ToString();
                }
                else if (radioReplace.Checked)
                {
                    output.Text = input.Text.Replace(search.Text, replace.Text);
                }
            }
        }
    }
}
