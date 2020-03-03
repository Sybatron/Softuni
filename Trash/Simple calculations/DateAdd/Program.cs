using System;

namespace DateAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime endDate = Convert.ToDateTime(this.txtStartDate.Text);
            Int64 addedDays = Convert.ToInt64(txtDaysSupp.Text);
            endDate = endDate.AddDays(addedDays);
            DateTime end = endDate;
            this.txtEndDate.Text = end.ToShortDateString();
        }
    }
}
