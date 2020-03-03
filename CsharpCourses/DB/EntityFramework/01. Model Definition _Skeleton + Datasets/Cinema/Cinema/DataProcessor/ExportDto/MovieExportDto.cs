using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.DataProcessor.ExportDto
{
    public class MovieExportDto
    {
        //its name, rating formatted to the second digit, total incomes formatted same way and customers.
        public string MovieName { get; set; }

        public string Rating { get; set; }

        public string TotalIncomes { get; set; }

        public ICollection<CustomerMovieExportDto> Customers { get; set; }
    }
}
