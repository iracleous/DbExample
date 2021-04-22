using DbExample.Models;

using DbExample.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExample.Services
{
    public interface IDepartmentService
    {

        //crud
        public Department CreateDepartment(DepartmentOption departmentOption);
        public Department RetrieveDepartment(DepartmentOption departmentOption);
        public List<Department> RetrieveDepartments(DepartmentOption departmentOption);
        public Department UpdateDepartment(int departmentId, DepartmentOption departmentOption);
        public bool DeleteDepartment(int departmentId);
    }
}
