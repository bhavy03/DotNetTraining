using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class SetOperators
    {
        public static void setoperators()
        {
            int[] sequence1 = { 1, 2, 3, 4, 5 };
            int[] sequence2 = { 4, 5, 6, 7, 8 };
            var distinct = sequence1.Distinct();
            Console.WriteLine("Distinct: " + string.Join(", ", distinct));
            var union = sequence1.Union(sequence2);
            Console.WriteLine("Union: " + string.Join(", ", union));
            var intersect = sequence1.Intersect(sequence2);
            Console.WriteLine("Intersect: " + string.Join(", ", intersect));
            var except = sequence1.Except(sequence2);
            Console.WriteLine("Except: " + string.Join(", ", except));
            var concatenated = sequence1.Concat(sequence2);
            Console.WriteLine("Concat: " + string.Join(", ", concatenated));
            bool areEqual = sequence1.SequenceEqual(sequence2);
            Console.WriteLine($"SequenceEqual: {areEqual}");
        }

        public static void distinct()
        {
            List<int> intCollection = new List<int>()
            {
                1,2,3,2,3,4,4,5,6,3,4,5
            };
            //Using Method Syntax
            var MS = intCollection.Distinct();
            //Using Query Syntax
            var QS = (from num in intCollection
                      select num).Distinct();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }

            string[] namesArray = { "Priyanka", "HINA", "hina", "Anurag", "Anurag", "ABC", "abc" };
            //now here it is case sensitive
            var distinctNames = namesArray.Distinct();
            //now here it is not case sensitive
            var distinctNames2 = namesArray.Distinct(StringComparer.OrdinalIgnoreCase);

            //see distinct with complex types in which we override the equals method
        }

        public static void except()
        {
            //var MS = dataSource1.Except(dataSource2).ToList();

            //var QS = (from std in Student.GetStudents()
            //          select std)
            //         .Select(std => new { std.ID, std.Name })
            //         .Distinct().ToList();

            //The Except Method will throw an exception if any sequences are null.

            string[] dataSource1 = { "India", "USA", "UK", "Canada", "Srilanka" };
            string[] dataSource2 = { "India", "uk", "Canada", "France", "Japan" };
            //Method Syntax
            var MS = dataSource1.Except(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            //Query Syntax
            var QS = (from country in dataSource1
                      select country)
                      .Except(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();

            //List<Student> AllStudents = new List<Student>()
            //{
            //    new Student {ID = 101, Name = "Preety" },
            //    new Student {ID = 102, Name = "Sambit" },
            //    new Student {ID = 103, Name = "Hina"},
            //    new Student {ID = 104, Name = "Anurag"},
            //    new Student {ID = 105, Name = "Pranaya"},
            //    new Student {ID = 106, Name = "Santosh"},
            //};
            //List<Student> Class6Students = new List<Student>()
            //{
            //    new Student {ID = 102, Name = "Sambit" },
            //    new Student {ID = 104, Name = "Anurag"},
            //    new Student {ID = 105, Name = "Pranaya"},
            //};

            ////Method Syntax
            //var MS = AllStudents.Select(x => new { x.ID, x.Name })
            //        .Except(Class6Students.Select(x => new { x.ID, x.Name })).ToList();
            ////Query Syntax
            //var QS = (from std in AllStudents
            //          select new { std.ID, std.Name })
            //          .Except(Class6Students.Select(x => new { x.ID, x.Name })).ToList();

            //can make comparer class and use it as this
            //StudentComparer studentComparer = new StudentComparer();
            ////Method Syntax
            //var MS = AllStudents.Except(Class6Students, studentComparer).ToList();

            //either make this override in student class or create equals in comparer class
            //    public override bool Equals(object obj)
            //{
            //    //As the obj parameter type is object, so we need to
            //    //cast it to Student Type
            //    return this.ID == ((Student)obj).ID && this.Name == ((Student)obj).Name;
            //}

        }
    }
}
