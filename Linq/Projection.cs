using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Projection
    {
        public static void projection()
        {
            //Query syntax
            List<Employee> basicQuery = (from emp in Employee.GetEmployees()
                                         select emp).ToList();

            //Using Query Syntax
            List<int> basicPropQuery = (from emp in Employee.GetEmployees()
                                        select emp.ID)
                                        .ToList(); //At this Point the Query is Executed

            //This is to select only selected fields
            IEnumerable<Employee> selectQuery = (from emp in Employee.GetEmployees()
                                                 select new Employee()
                                                 {
                                                     FirstName = emp.FirstName,
                                                     LastName = emp.LastName,
                                                     Salary = emp.Salary
                                                 });

            //This is anonymous selection
            var SelectQuery = (from emp in Employee.GetEmployees()
                               select new
                               {
                                   FirstName = emp.FirstName,
                                   LastName = emp.LastName,
                                   Salary = emp.Salary
                               });

            var selectQuery2 = (from emp in Employee.GetEmployees()
                                select new
                                {
                                    EmployeeId = emp.ID,
                                    FullName = emp.FirstName + " " + emp.LastName,
                                    AnnualSalary = emp.Salary * 12
                                });

            foreach (Employee emp in basicQuery)
            {
                Console.WriteLine($"ID : {emp.ID} Name : {emp.FirstName} {emp.LastName}");
            }



            //Using Method Syntax
            IEnumerable<Employee> basicMethod = Employee.GetEmployees().ToList();
            foreach (Employee emp in basicMethod)
            {
                Console.WriteLine($"ID : {emp.ID} Name : {emp.FirstName} {emp.LastName}");
            }

            IEnumerable<int> basicPropMethod = Employee.GetEmployees()
                                               .Select(emp => emp.ID);
            //At this Point the Query is Just Generated, Not Executed

            List<Employee> selectMethod = Employee.GetEmployees().
                                          Select(emp => new Employee()
                                          {
                                              FirstName = emp.FirstName,
                                              LastName = emp.LastName,
                                              Salary = emp.Salary
                                          }).ToList();

            //This is anonymous selection
            var SelectMethod = Employee.GetEmployees().
                                          Select(emp => new
                                          {
                                              FirstName = emp.FirstName,
                                              LastName = emp.LastName,
                                              Salary = emp.Salary
                                          }).ToList();

            var selectMethod2 = Employee.GetEmployees().
                                         Select(emp => new
                                         {
                                             EmployeeId = emp.ID,
                                             FullName = emp.FirstName + " " + emp.LastName,
                                             AnnualSalary = emp.Salary * 12
                                         }).ToList();
        }
    }
    public class selectmany
    {
        public void Selectmany()
        {
            List<string> nameList = new List<string>() { "Pranaya", "Kumar" };
            IEnumerable<char> methodSyntax = nameList.SelectMany(x => x);
            IEnumerable<char> querySyntax = from str in nameList
                                            from ch in str
                                            select ch;
            //here selectMany means
            //For each word(x), select each character from it
            foreach (char c in querySyntax)
            {
                Console.Write(c + " ");
            }

            //var MethodSyntax = Student.GetStudents()
            //                            .SelectMany(std => std.Programming,
            //                                 (student, program) => new
            //                                 {
            //                                     StudentName = student.Name,
            //                                     ProgramName = program
            //                                 }
            //                                 )
            //                            .ToList();
            //remember its working as it takes (one source,(collectionselector,resultSelector))

        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {ID = 101, FirstName = "Preety", LastName = "Tiwary", Salary = 60000 },
                new Employee {ID = 102, FirstName = "Priyanka", LastName = "Dewangan", Salary = 70000 },
                new Employee {ID = 103, FirstName = "Hina", LastName = "Sharma", Salary = 80000 },
                new Employee {ID = 104, FirstName = "Anurag", LastName = "Mohanty", Salary = 90000 },
                new Employee {ID = 105, FirstName = "Sambit", LastName = "Satapathy", Salary = 100000 },
                new Employee {ID = 106, FirstName = "Sushanta", LastName = "Jena", Salary = 160000 }
            };
            return employees;
        }
    }
}

//IEnumerable<Employee> basicQuery = (from emp in Employee.GetEmployees() select emp);
//At this point, the query is just created, not executed.
//In order to execute the query, we need to apply some methods to the query,
//such as the ToList() method or a foreach loop.
//If you are not applying the ToList() method on the query,
//then the data type will be:IEnumerable<Employee>
//List<Employee> basicQuery = (from emp in Employee.GetEmployees() select emp).ToList();
//At this time, the query is created as well as executed, as we applied the ToList() method on the query.