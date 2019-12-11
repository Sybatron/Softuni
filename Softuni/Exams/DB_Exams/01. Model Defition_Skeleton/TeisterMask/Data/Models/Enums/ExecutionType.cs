using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace TeisterMask.Data.Models.Enums
{
    public enum ExecutionType
    {
        ProductBacklog = 1,
        SprintBacklog = 2,
        InProgress = 3,
        Finished = 4
    }
}
