using System;
using System.Collections.Generic;

#nullable disable

namespace DbExample.Models
{
    public partial class Project
    {
        public Project()
        {
            ProjectEmployees = new HashSet<ProjectEmployee>();
        }

        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }

        public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; }
    }
}
