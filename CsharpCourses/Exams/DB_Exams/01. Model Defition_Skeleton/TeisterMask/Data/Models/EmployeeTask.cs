using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeisterMask.Data.Models
{
    public class EmployeeTask
    {
        [Key]
        [Required]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [Key]
        [Required]
        public int TaskId { get; set; }

        public Task Task { get; set; }
    }
}
