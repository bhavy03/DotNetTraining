using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Aggregate
    {
        public static void aggregate()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            int countEven = numbers.Count(x => x % 2 == 0); // 2
            int sum = numbers.Sum();
            int min = numbers.Min();
            int max = numbers.Max();
            double average = (numbers.Average());
            int product = numbers.Aggregate((accumulator, number) => accumulator * number);
            int productWithSeed = numbers.Aggregate(2, (acc, num) => acc * num);
            Console.WriteLine($"Event Number Count: {countEven} and Sum is {sum}");

            string[] skills = { "C#.NET", "MVC", "WCF", "SQL", "LINQ", "ASP.NET" };
            string result = skills.Aggregate((s1, s2) => s1 + ", " + s2);
            Console.WriteLine(result);

            int Salary = Employee2.GetAllEmployees().Aggregate<Employee2, int>(0, (TotalSalary, emp) => TotalSalary += emp.Salary);
            //public static TAccumulate Aggregate<TSource, TAccumulate>(

            //alternative without generics
            //int totalSalary = Employee.GetAllEmployees().Select(emp => emp.Salary).Aggregate((total, salary) => total + salary);
            Console.WriteLine(Salary);

            //string CommaSeparatedEmployeeNames = Employee.GetAllEmployees().Aggregate<Employee, string, string>(
            //                            "Employee Names: ",  // seed value
            //                            (employeeNames, employee) => employeeNames = employeeNames + employee.Name + ", ",
            //                            employeeNames => employeeNames.Substring(0, employeeNames.Length - 1));
        }

        public static void sum()
        {
            int[] intNumbers = new int[] { 10, 30, 50, 40, 60, 20, 70, 90, 80, 100 };
            int MSTotal = intNumbers.Sum(num =>
            {
                if (num > 50)
                    return num;
                else
                    return 0;
            });
            //Using Query Syntax with a Predicate
            int QSTotal = (from num in intNumbers
                           select num).Sum(num =>
                           {
                               if (num > 50)
                                   return num;
                               else
                                   return 0;
                           });

            int?[] nullableNumbers = { 1, 2, null, 4, 5 };
            int sum = nullableNumbers.Sum().GetValueOrDefault();

            int?[] nullableNumbers2 = { 1, 2, 10, null, 4, 5 };
            int? max = nullableNumbers.Max();
            Console.WriteLine("Max = " + max);

            double? average = nullableNumbers.Average();
            Console.WriteLine("Average = " + average);

            int MSCount = intNumbers.Count(num =>
            {
                if (num > 40)
                    return true;
                else
                    return false;
            });


        }
    }

    public class Employee2
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
        public static List<Employee2> GetAllEmployees()
        {
            List<Employee2> listStudents = new List<Employee2>()
            {
                new Employee2{ID= 101,Name = "Preety", Salary = 10000, Department = "IT"},
                new Employee2{ID= 102,Name = "Priyanka", Salary = 15000, Department = "Sales"},
                new Employee2{ID= 103,Name = "James", Salary = 50000, Department = "Sales"},
                new Employee2{ID= 104,Name = "Hina", Salary = 20000, Department = "IT"},
                new Employee2{ID= 105,Name = "Anurag", Salary = 30000, Department = "IT"},

            };
            return listStudents;
        }
    }
}
