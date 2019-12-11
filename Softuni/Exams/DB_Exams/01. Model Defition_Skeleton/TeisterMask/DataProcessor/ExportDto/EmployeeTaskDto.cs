using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeisterMask.DataProcessor.ExportDto
{
    public class EmployeeTaskDto
    {
        [Key]
        [Required]
        public int EmployeeId { get; set; }

        [Key]
        [Required]
        public int TaskId { get; set; }
    }
}
