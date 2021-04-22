using DbExample.Models;
using DbExample.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExample.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly NbgCompanyContext db;

    
        public  DepartmentService(NbgCompanyContext _db)
        {
            db = _db;
        }

        public Department CreateDepartment(DepartmentOption departmentOption)
        {
            if (departmentOption == null)
            {
                return null;
            }
            Department department = new () { Title = departmentOption.Title };
            db.Departments.Add(department);
            db.SaveChanges();
            return department;

        }

        public bool DeleteDepartment(int departmentId)
        {
            throw new NotImplementedException();
        }

        public Department RetrieveDepartment(DepartmentOption departmentOption)
        {
            throw new NotImplementedException();
        }

        public List<Department> RetrieveDepartments(DepartmentOption departmentOption)
        {
            if (departmentOption == null)
            {
                return new();
            }

            if (departmentOption == null)
            {
                return new();
            }
            List<Department> departments = db
                .Departments
                .Where(department => department.Title.Contains(departmentOption.Title))
                .ToList();
            return departments;
        }

        public Department UpdateDepartment(int departmentId, DepartmentOption departmentOption)
        {
            throw new NotImplementedException();
        }
    }
}
