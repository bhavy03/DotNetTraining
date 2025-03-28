using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Filtering
    {
        public static void filtering()
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Method Syntax
            IEnumerable<int> filteredData = intList.Where(num => num > 5);

            //Method Syntax
            var OddNumbersWithIndexPosition = intList.Select((num, index) => new
            {
                Numbers = num,
                IndexPosition = index
            }).Where(x => x.Numbers % 2 != 0).Select(data => new
            {
                Number = data.Numbers,
                IndexPosition = data.IndexPosition
            });

            //Query Syntax
            IEnumerable<int> filteredResult = from num in intList
                                              where num > 5
                                              select num;

            foreach (int number in filteredData)
            {
                Console.WriteLine(number);
            }

            //Query Syntax
            var OddNumbersWithIndexPosition2k = from number in intList.Select((num, index) => new { Numbers = num, IndexPosition = index })
                                                where number.Numbers % 2 != 0
                                                select new
                                                {
                                                    Number = number.Numbers,
                                                    IndexPosition = number.IndexPosition
                                                };


            //ofType filtering
            //Data Source Contains both Integer and String Data
            List<object> dataSource = new List<object>()
            {
                "Tom", "Mary", 50, "Prince", "Jack", 10, 20, 30, 40, "James"
            };
            //Fetching only the Integer Data from the Data Source
            //using Linq Method Syntax and OfType Method
            List<int> intData = dataSource.OfType<int>().ToList();

            //using Linq Query Syntax and OfType Method
            var intData2 = (from num in dataSource.OfType<int>() select num).ToList();

            //using Linq Query Syntax and is Method
            var stringData = (from name in dataSource
                              where name is string
                              select name).ToList();

            //Print the Integer Data
            foreach (int number in intData)
            {
                Console.Write(number + " ");
            }

        }
    }
}
//That means the Where method filters a sequence (such as an array or a list) based on a predicate.
//A predicate is a function that takes an element of the sequence as input and returns a boolean value (true or false).
//The method returns all elements for which the predicate returns true.
//List<int> numbers = new List<int>() { 10, 20, 25, 30, 35, 40 };
// Predicate function to check if a number is greater than 25
//Predicate<int> isGreaterThan25 = num => num > 25;
// Find all numbers greater than 25
//List<int> result = numbers.FindAll(isGreaterThan25);
