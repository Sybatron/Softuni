using System;
using System.Collections.Generic;
using System.Text;

namespace TeisterMask.DataProcessor.ExportDto
{
    public class EmployeeExportDto
    {
        public string Username { get; set; }

        public ICollection<TasksExportDto> Tasks { get; set; }
    }
}
