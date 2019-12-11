namespace TeisterMask.DataProcessor
{
    using System;
    using System.Linq;
    using Data;
    using TeisterMask.DataProcessor.ExportDto;
    using Formatting = Newtonsoft.Json.Formatting;

    public class Serializer
    {
        public static string ExportProjectWithTheirTasks(TeisterMaskContext context)
        {
            var employees = context.Employees
                .Select(e => new EmployeeExportDto
                {
                    Username = e.Username,
                    Tasks = context.EmployeesTasks.Where(et => et.EmployeeId == e.Id)
                                                .Select(et => new TasksExportDto
                                                {
                                                    TaskName = et.Task.Name,
                                                    OpenDate = et.Task.OpenDate,
                                                    DueDate = et.Task.DueDate,
                                                    LabelType = et.Task.LabelType,
                                                    ExecutionType = et.Task.ExecutionType
                                                }).ToList()
                }).ToList();
            return null;
        }

        public static string ExportMostBusiestEmployees(TeisterMaskContext context, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}