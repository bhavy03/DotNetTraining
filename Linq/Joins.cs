using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Joins
    {
        public static void joins()
        {
            var departments = new List<Department>
            {
                new Department { DepartmentId = 1, Name = "HR" },
                new Department { DepartmentId = 2, Name = "IT" }
            };
            var employees = new List<Employee3>
            {
                new Employee3 { EmployeeId = 101, DepartmentId = 1, Name = "Alice" },
                new Employee3 { EmployeeId = 102, DepartmentId = 2, Name = "Bob" },
                new Employee3 { EmployeeId = 103, DepartmentId = 1, Name = "Charlie" },
                new Employee3{ EmployeeId = 104, DepartmentId = 2, Name = "John" },
                new Employee3 { EmployeeId = 105, DepartmentId = 1, Name = "Smith" }
            };
            //Performing Group Join
            var result = from department in departments
                         join employee in employees on department.DepartmentId equals employee.DepartmentId into grouped
                         select new { DepartmentName = department.Name, Employees = grouped };
            foreach (var item in result)
            {
                Console.WriteLine($"Department: {item.DepartmentName}");
                foreach (var employee in item.Employees)
                {
                    Console.WriteLine($"\tEmployee: {employee.Name} ");
                }
                Console.WriteLine();
            }

            //var JoinUsingMS = Employee.GetAllEmployees() //Outer Data Source
            //              .Join( //Performing LINQ Inner Join
            //Address.GetAllAddresses(),  //Outer Data Source
            //              employee => employee.AddressId, //Outer Key Selector
            //              address => address.ID, //Inner Key selector
            //              (employee, address) => new //Projecting the data into an Annonymous Type
            //              {
            //                  EmployeeName = employee.Name,
            //                  AddressLine = address.AddressLine
            //              }).ToList();
            ////Accessing the Result using For Each Loop
            //foreach (var employee in JoinUsingMS)
            //{
            //    Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            //}
        }
    }

    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
    }
    public class Employee3
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
    }
}
