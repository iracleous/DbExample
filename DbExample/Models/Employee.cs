using System;
using System.Collections.Generic;

#nullable disable

namespace DbExample.Models
{
    public partial class Employee
    {
        public Employee()
        {
            ProjectEmployees = new HashSet<ProjectEmployee>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? HiringDate { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; }
    }
}
