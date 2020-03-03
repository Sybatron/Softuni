using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TeisterMask.Data.Models;

namespace TeisterMask.DataProcessor.ImportDto
{
    public class EmployeeImportDto
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"([a-z\d]|[A-Z\d]){1,}")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"(\d{3}-){2}(\d{4})")]
        public string Phone { get; set; }

        public int[] Tasks { get; set; }
    }
}
