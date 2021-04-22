﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DbExample.Models
{
    public partial class ProjectEmployee
    {
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? StartingDate { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
    }
}
