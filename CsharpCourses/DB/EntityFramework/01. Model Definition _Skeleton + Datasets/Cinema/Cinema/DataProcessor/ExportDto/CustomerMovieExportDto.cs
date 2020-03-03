using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.DataProcessor.ExportDto
{
    public class CustomerMovieExportDto
    {
        //first name, last name and balance formatted to the second digit
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Balance { get; set; }
    }
}
