using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq
{
    internal class Ordering
    {
        public static void ordering()
        {
            //The OrderBy operator sorts elements in ascending order based on a specified key.
            //The OrderByDescending operator is similar to OrderBy but sorts the elements in
            //descending order based on a specified key.
            //The ThenBy operator is often used after OrderBy or OrderByDescending to provide a secondary level of sorting.
            //The Reverse operator reverses the order of elements in a sequence, effectively sorting them in descending order.
            //It is a simple way to reverse the current order.

            var people = new List<Person>
            {
                new Person { FirstName = "John", LastName = "Doe", Age = 30 },
                new Person { FirstName = "Jane", LastName = "Doe", Age = 25 },
                new Person { FirstName = "Joe", LastName = "Bloggs", Age = 30 },
                // ... other people ...
            };
            var sortedPeople = people
                .OrderBy(p => p.LastName)
                .ThenBy(p => p.FirstName)
                .ThenByDescending(p => p.Age);
            foreach (var person in sortedPeople)
            {
                Console.WriteLine($"{person.LastName}, {person.FirstName}: {person.Age}");
            }
        }

        public static void orderby()
        {
            List<int> intList = new List<int>() { 10, 45, 35, 29, 100, 69, 58, 50 };
            var MS = intList.OrderBy(num => num);
            //Using Query Syntax
            var QS = (from num in intList
                      orderby num
                      select num).ToList();

            //By default, sorting is case -sensitive and in ascending order.

            //    public class CaseInsensitiveComparer : IComparer<string>
            //{
            //    public int Compare(string x, string y)
            //    {
            //        return string.Compare(x, y, true);
            //    }
            //}
            //CaseInsensitiveComparer caseInsensitiveComparer = new CaseInsensitiveComparer();
            //string[] Alphabets = { "a", "b", "c", "A", "B", "C" };
            //var SortedAlphabets = Alphabets.OrderBy(aplhabet => aplhabet, caseInsensitiveComparer);
            //foreach (var item in SortedAlphabets)
            //{
            //    Console.Write(item + " ");
            //}
        }

        public static void thenby()
        {
            //var MS = Student.GetAllStudents()
            //                .OrderBy(x => x.FirstName)
            //                .ThenBy(y => y.LastName)
            //                .ToList();
        }

        public static void reverse()
        {
            int[] intArray = new int[] { 10, 30, 50, 40, 60, 20, 70, 100 };
            IEnumerable<int> ArrayReversedData = intArray.Reverse();
            Console.WriteLine("After Reverse the Data");
            foreach (var number in ArrayReversedData)
            {
                Console.Write(number + " ");
            }

            IEnumerable<int> ArrayReversedData2 = (from num in intArray select num).Reverse();

            List<string> stringList = new List<string>() { "Preety", "Tiwary", "Agrawal", "Priyanka", "Dewangan" };
            IEnumerable<string> ReverseData1 = stringList.AsEnumerable().Reverse();
            IQueryable<string> ReverseData2 = stringList.AsQueryable().Reverse();
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
