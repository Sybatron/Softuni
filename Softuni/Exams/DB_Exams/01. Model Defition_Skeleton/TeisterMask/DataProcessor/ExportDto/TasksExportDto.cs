using System;
using System.Collections.Generic;
using System.Text;
using TeisterMask.Data.Models.Enums;

namespace TeisterMask.DataProcessor.ExportDto
{
    public class TasksExportDto
    {
        public string TaskName { get; set; }

        public DateTime OpenDate { get; set; }

        public DateTime DueDate { get; set; }

        public LabelType LabelType { get; set; }

        public ExecutionType ExecutionType { get; set; }
    }
}
