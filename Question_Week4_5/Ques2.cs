using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Week4_5
{
    internal static class Ques2
    {
        public static void SelectNth()
        {
            List<Student> students = new List<Student>
            {
            new Student { ID = 1, Name = "Alice" },
            new Student { ID = 2, Name = "Bob" },
            new Student { ID = 3, Name = "Charlie" },
            new Student { ID = 4, Name = "David" },
            new Student { ID = 5, Name = "Emma" }
            };

            Console.Write("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            var nthStudent = students.ElementAt(n - 1);
            if (nthStudent != null)
            {
                Console.WriteLine($"The {n}th student is: {nthStudent.Name}");
            }
            else
            {
                Console.WriteLine("Invalid index!");
            }
        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}