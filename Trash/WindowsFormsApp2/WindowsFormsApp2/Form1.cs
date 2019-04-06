using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int numStud = 7, numDisc = 7;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGrades.Rows.Add(numStud);
            for (int i = 0; i < numStud; i++)
                DataGrades[0, i].Value = "Ученик" + (i+1);

            Random rand = new Random();
            for (int i = 0; i < numStud; i++)
                for (int j = 1; j < numDisc + 1; j++)
                    DataGrades[j, i].Value = rand.Next(2, 6);

            DataSpr.Rows.Add(numDisc);
            DataSpr[0, 0].Value = "БЕЛ";
            DataSpr[0, 1].Value = "Математика";
            DataSpr[0, 2].Value = "Чужд език";
            DataSpr[0, 3].Value = "Информатика";
            DataSpr[0, 4].Value = "Инф. Технологии";
            DataSpr[0, 5].Value = "История";
            DataSpr[0, 6].Value = "География";
        }

        private void DataGrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowLabel.Text = "Ред: " + (e.RowIndex + 1);
            ColumnLabel.Text = "Колона: " + (e.ColumnIndex + 1);
        }

        private void SumUp_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numStud; i++)
            {
                int sum = 0;
                for (int j = 1; j <= numDisc; j++)
                    sum += int.Parse(DataGrades[j, i].Value.ToString());
                double averageStud = (double)sum / numDisc;
                DataGrades[numDisc + 1, i].Value = Math.Round(averageStud, 2);
            }

            for (int j = 1; j <= numDisc; j++)
            {
                int num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0;
                for (int i = 0; i < numStud; i++)
                {
                    if (DataGrades[j, i].Value.ToString() == "2") num2++;
                    else if (DataGrades[j, i].Value.ToString() == "3") num3++;
                    else if (DataGrades[j, i].Value.ToString() == "4") num4++;
                    else if (DataGrades[j, i].Value.ToString() == "5") num5++;
                    else if (DataGrades[j, i].Value.ToString() == "6") num6++;
                }
                DataSpr[1, j - 1].Value = num2;
                DataSpr[2, j - 1].Value = num3;
                DataSpr[3, j - 1].Value = num4;
                DataSpr[4, j - 1].Value = num5;
                DataSpr[5, j - 1].Value = num6;
                double avrDisc = (double)(num2 * 2 + num3 * 3 + num4 * 4 + num5 * 5 + num6 * 6);
                avrDisc = avrDisc / numStud;
                DataSpr[6, j - 1].Value = Math.Round(avrDisc, 2);
            }
        }


    }
}
