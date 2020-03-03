namespace TeisterMask.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

    using Data;
    using System.Xml.Serialization;
    using System.Text;
    using TeisterMask.DataProcessor.ImportDto;
    using System.IO;
    using TeisterMask.Data.Models;
    using System.Globalization;
    using TeisterMask.Data.Models.Enums;
    using Newtonsoft.Json;
    using System.Linq;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedProject
            = "Successfully imported project - {0} with {1} tasks.";

        private const string SuccessfullyImportedEmployee
            = "Successfully imported employee - {0} with {1} tasks.";

        public static string ImportProjects(TeisterMaskContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(ProjectImportDto[]), new XmlRootAttribute(elementName: "Projects"));
            var objects = (ProjectImportDto[])serializer.Deserialize(new StringReader(xmlString));
            var sb = new StringBuilder();

            foreach (var dto in objects)
            {
                if (IsValid(dto))
                {
                    var project = new Project
                    {
                        Name = dto.Name,
                        OpenDate = DateTime.ParseExact(dto.OpenDate, @"dd/MM/yyyy", CultureInfo.InvariantCulture)
                    };

                    if (!(dto.DueDate == null) && dto.DueDate != string.Empty)
                    {
                        project.DueDate = DateTime.ParseExact(dto.DueDate, @"dd/MM/yyyy", CultureInfo.InvariantCulture);
                    }
                    //TODO Random new line added
                    context.Projects.Add(project);
                    AddAllTasks(context, project, dto.Tasks, ref sb);
                    sb.AppendLine(string.Format(SuccessfullyImportedProject, project.Name, project.Tasks.Count));
                }
                else
                {
                    sb.AppendLine(ErrorMessage);
                }
            }

            context.SaveChanges();
            return sb.ToString().Trim();
        }

        public static string ImportEmployees(TeisterMaskContext context, string jsonString)
        {
            var employeesDtos = JsonConvert.DeserializeObject<EmployeeImportDto[]>(jsonString);

            var sb = new StringBuilder();
            foreach (var dto in employeesDtos)
            {
                if (IsValid(dto))
                {
                    var employee = new Employee
                    {
                        Username = dto.Username,
                        Email = dto.Email,
                        Phone = dto.Phone,
                    };
                    context.Employees.Add(employee);
                    AddAllEmployeeTasks(context, dto.Tasks, employee.Id, ref sb);
                }
                else
                {
                    sb.AppendLine(ErrorMessage);
                }
            }
            context.SaveChanges();
            return sb.ToString();
        }

        private static void AddAllEmployeeTasks(TeisterMaskContext context, int[] tasksIds, int employeeId, ref StringBuilder sb)
        {
            foreach (var taskId in tasksIds)
            {
                if (context.Tasks.Any(t => t.Id == taskId) && !context.EmployeesTasks.Any(et => et.TaskId == taskId))
                {
                    var employeeTask = new EmployeeTask
                    {
                        EmployeeId = employeeId,
                        TaskId = taskId
                    };
                    context.EmployeesTasks.Add(employeeTask);
                }
                else
                {
                    sb.AppendLine(ErrorMessage);
                }
            }

            context.SaveChanges();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }

        private static void AddAllTasks(TeisterMaskContext context, Project project, TaskImportDto[] tasks, ref StringBuilder sb)
        {
            var projectId = project.Id;
            var projectOpenDate = project.OpenDate;
            var projectDueDate = project.DueDate;

            foreach (var dto in tasks)
            {
                if (IsValid(dto) && IsOpenDateValid(dto.OpenDate, projectOpenDate) && IsDueDateValid(dto.DueDate, projectDueDate))
                {
                    var task = new Task
                    {
                        Name = dto.Name,
                        OpenDate = DateTime.ParseExact(dto.OpenDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        DueDate = DateTime.ParseExact(dto.DueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        ExecutionType = (ExecutionType)dto.ExecutionType,
                        LabelType = (LabelType)dto.LabelType,
                        ProjectId = projectId
                    };
                    context.Tasks.Add(task);
                }
                else
                {
                    sb.AppendLine(ErrorMessage);
                }
            }

            context.SaveChanges();
        }

        private static bool IsDueDateValid(string dueDate, DateTime? projectDueDate)
        {
            var dtoDueTime = DateTime.ParseExact(dueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            if (projectDueDate != null)
            {
                if (projectDueDate > dtoDueTime)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }

        }

        private static bool IsOpenDateValid(string openDate, DateTime projectOpenDate)
        {
            var dtoDueTime = DateTime.ParseExact(openDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            if (projectOpenDate < dtoDueTime)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}