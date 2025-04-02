using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class ElementOperators
    {
        public static void operators()
        {
            var numbers = new int[] { 1, 2, 3 };
            var firstNumber = numbers.First(); // returns 1
            var firstEvenNumber = numbers.Where(n => n % 2 == 0).FirstOrDefault(); // returns 2
            var singleNumber = numbers.Single(n => n == 3); // returns 3
            var thirdNumber = numbers.ElementAtOrDefault(2); // returns 3
            var fourthNumber = numbers.ElementAtOrDefault(3); // returns 0, which is the default for int

            List<string> cityList1 = new List<string> { "DELHI", "mumbai", "Hyderabad" };
            List<string> cityList2 = new List<string> { "delhi", "MUMBAI", "Hyderabad" };
            List<string> cityList3 = new List<string> { "Delhi", "Hyderabad", "Mumbai" };
            bool IsEqualMS = cityList1.SequenceEqual(cityList2, StringComparer.OrdinalIgnoreCase);
            bool IsEqualMS2 = cityList1.OrderBy(city => city).SequenceEqual(cityList3.OrderBy(city => city), StringComparer.OrdinalIgnoreCase);
        }
    }
}
