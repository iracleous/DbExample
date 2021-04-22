using DbExample.Models;
using DbExample.Representation;
using DbExample.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DbExample
{
    static class Program
    {
        static void Main()
        {

            AntiPattern();

        }


        static void UsingOrm()
        {
            using NbgCompanyContext db = new();
            IDepartmentService departmentService = new DepartmentService(db);

            //DepartmentOption departmentOptionToCreate = new() {  Title="Production"};
            //departmentService.CreateDepartment(departmentOptionToCreate);

            DepartmentOption departmentOptionToFind = new() {  Title=""};
            List<Department> departments  = departmentService.RetrieveDepartments(departmentOptionToFind);

            
            Console.WriteLine("------------------------------------------");
            foreach (Department department in departments)
            {
                Console.WriteLine($"{department.DepartmentId}  {department.Title}");
            }
        }


        static void AntiPattern()
        {
            string connnectionString = "Data Source=localhost;Initial Catalog=NbgCompany;User ID=sa;Password=passw0rd";

            SqlConnection connection = new (connnectionString);

            List<Department> departments = new ();

            try
            {
                connection.Open();
                Console.WriteLine("Connection Open ! ");

                string sql = "select * from Department";
                SqlCommand sqlCommand = new (sql, connection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine($" {dataReader.GetValue(0)}  {dataReader.GetValue(1)}     ");
                    Department department = new () { DepartmentId = dataReader.GetInt32(0), Title = dataReader.GetString(1) };
                    departments.Add(department);
                }


                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("------------------------------------------");
            foreach (Department department in departments)
            {
                Console.WriteLine($"{department.DepartmentId}  {department.Title}");
            }
        }


    }
}
