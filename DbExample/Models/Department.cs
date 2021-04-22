using System;
using System.Collections.Generic;

#nullable disable

namespace DbExample.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DepartmentId { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
