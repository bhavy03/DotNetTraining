using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Department department1 = new Department
            //{
            //    DepartmentName = "Technology",
            //    Employees = new List<Employee>
            //    {
            //        new Employee() {EmployeeName = "Jack"},
            //        new Employee() {EmployeeName = "Kim"},
            //        new Employee() {EmployeeName = "Shen"}
            //    }
            //};

            //Department department2 = new Department
            //{
            //    DepartmentName = "Technology",
            //    Employees = new List<Employee>
            //    {
            //        new Employee() {EmployeeName = "rahul"},
            //        new Employee() {EmployeeName = "Linga"},
            //        new Employee() {EmployeeID = 1}
            //    }
            //};


            Employee employee = new Employee
            {
                EmployeeName = "Hari",
                Departments = new List<Department>
                {
                    new Department(){ DepartmentName = "Technology" },
                     new Department(){ DepartmentName = "Arts" },
                }
            };
            DataAccessHelper dbHelper = new DataAccessHelper();
            //dbHelper.AddDepartment(department2);
            dbHelper.AddEmployee(employee);

            //    var addedDepartment = dbHelper.FetchDepartments().FirstOrDefault();
            //    try
            //    {
            //        Console.WriteLine("Department Name is: " + addedDepartment.DepartmentName + Environment.NewLine);
            //        Console.WriteLine("Department Employees are: " + Environment.NewLine);

            //        foreach (var addedDepartmentEmployee in addedDepartment.Employees)
            //        {
            //            Console.WriteLine(addedDepartmentEmployee.EmployeeName + Environment.NewLine);
            //        }

            //    }
            //    catch
            //    {
            //        Console.WriteLine("error");
            //    }
        }
    }
}
//Navigation properties are added as virtual properties in the entity.
//EF also does not create a column for a property which does not have either getters or setters.
//The Entity Framework code first approach provides us with three approaches while creating the database.
//CreateDatabaseIfNotExists
//DropCreateDatabaseWhenModelChanges  : If modal changes then drop and create the database
//DropCreateDatabaseAlways : useful in testing as everytime database is dropped and created

//Code First Migrations
//Imagine a scenario where you want to add a new model/ entity and you do not want the existing database
//to get deleted or changed when you update the database with the newly added model class.
//Code first migrations here help you to update the existing database with your newly
//added model classes and your existing database remains intact with the existing data.
//So, the data and schema won’t be created again.

//for this in package manager write Enable-Migrations