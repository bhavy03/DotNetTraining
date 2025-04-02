using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Grouping
    {
        public static void grouping()
        {
            IEnumerable<IGrouping<string, Student>> GroupByMS1 = Student.GetStudents().GroupBy(s => s.Barnch);
            //Using Query Syntax
            IEnumerable<IGrouping<string, Student>> GroupByQS1 = (from std in Student.GetStudents()
                                                                  group std by std.Barnch);

            var GroupByMS = Student.GetStudents().GroupBy(s => s.Gender)
                            //Then Sorting the data based on key in Descending Order
                            .OrderByDescending(c => c.Key)
                            .Select(std => new
                            {
                                Key = std.Key,
                                //Sorting the Students in Each Group based on Name in Ascending order
                                Students = std.OrderBy(x => x.Name)
                            });
            //Using Query Syntax
            //First Group the Data by Gender
            var GroupByQS = from std in Student.GetStudents()
                                //First store the data into a group
                            group std by std.Gender into stdGroup
                            //Then Sorting the data based on key in Descending Order
                            orderby stdGroup.Key descending
                            select new
                            {
                                Key = stdGroup.Key,
                                //Sorting the Students in Each Group based on Name in Ascending order
                                Students = stdGroup.OrderBy(x => x.Name)
                            };
            //It will iterate through each groups
            foreach (var group in GroupByQS)
            {
                Console.WriteLine(group.Key + " : " + group.Students.Count());
                //Iterate through each student of a group
                foreach (var student in group.Students)
                {
                    Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Branch :" + student.Barnch);
                }
            }

            // Grouping in multiple groups 
            var GroupByMultipleKeysMS = Student.GetStudents()
               //Grouping Multiple Keys using an Anonymous Object
               .GroupBy(x => new { x.Barnch, x.Gender })
               //.GroupBy(student => (student.Branch, student.Gender)) this is using tuple
               .Select(g => new
               {
                   Branch = g.Key.Barnch,
                   Gender = g.Key.Gender,
                   Students = g.OrderBy(x => x.Name)
               }); ;
            //Using Query Syntax
            var GroupByMultipleKeysQS = (from std in Student.GetStudents()
                                             //Grouping Multiple Keys using an Anonymous Object
                                         group std by new
                                         {
                                             std.Barnch,
                                             std.Gender
                                         } into stdGroup
                                         select new
                                         {
                                             Branch = stdGroup.Key.Barnch,
                                             Gender = stdGroup.Key.Gender,
                                             //Sort the Students of Each group by Name in Ascending Order
                                             Students = stdGroup.OrderBy(x => x.Name)
                                         });
            //It will iterate through each group
            foreach (var group in GroupByMultipleKeysQS)
            {
                Console.WriteLine($"Barnch : {group.Branch} Gender: {group.Gender} No of Students = {group.Students.Count()}");
                //It will iterate through each item of a group
                foreach (var student in group.Students)
                {
                    Console.WriteLine($"  ID: {student.ID}, Name: {student.Name}, Age: {student.Age} ");
                }
                Console.WriteLine();
            }
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Barnch { get; set; }
        public int Age { get; set; }
        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student { ID = 1001, Name = "Preety", Gender = "Female", Barnch = "CSE", Age = 20 },
                new Student { ID = 1002, Name = "Snurag", Gender = "Male", Barnch = "ETC", Age = 21  },
                new Student { ID = 1003, Name = "Pranaya", Gender = "Male", Barnch = "CSE", Age = 21  },
                new Student { ID = 1004, Name = "Anurag", Gender = "Male", Barnch = "CSE", Age = 20  },
                new Student { ID = 1005, Name = "Hina", Gender = "Female", Barnch = "ETC", Age = 20 },
                new Student { ID = 1006, Name = "Priyanka", Gender = "Female", Barnch = "CSE", Age = 21 },
                new Student { ID = 1007, Name = "santosh", Gender = "Male", Barnch = "CSE", Age = 22  },
                new Student { ID = 1008, Name = "Tina", Gender = "Female", Barnch = "CSE", Age = 20  },
                new Student { ID = 1009, Name = "Celina", Gender = "Female", Barnch = "ETC", Age = 22 },
                new Student { ID = 1010, Name = "Sambit", Gender = "Male",Barnch = "ETC", Age = 21 }
            };
        }
    }
}


//The LINQ ToLookup Method exactly does the same thing as the LINQ GroupBy Method.
//The only difference between these two methods is that the GroupBy method uses Deferred Execution,
//whereas the ToLookup method uses Immediate Execution.