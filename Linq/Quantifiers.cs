using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Quantifiers
    {
        public static void quatifiers()
        {
            //quantifier operators check whether some or all elements in a sequence or collection satisfy a condition.

            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            bool anyGreaterThanThree = numbers.Any(x => x > 3); // true, as at least one element is greater than 3
            bool anyEven = numbers.Any(x => x % 2 == 0); // true, as there are even numbers in the 

            bool allGreaterThanZero = numbers.All(x => x > 0); // true, as all elements are greater than 0
            bool allEven = numbers.All(x => x % 2 == 0); // false, as not all elements are even

            bool containsFive = numbers.Contains(5); // checks if the sequence contains the number 5
        }

        public static void all()
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };
            //Using Method Syntax
            bool ResultMS = IntArray.All(x => x > 10);
            //Using Query Syntax
            bool ResultQS = (from num in IntArray
                             select num).All(x => x > 10);
        }

        public static void any()
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };
            //Using Method Syntax
            var ResultMS = IntArray.Any();
            //Using Query Syntax
            var ResultQS = (from num in IntArray
                            select num).Any();

            //Here Without Predicate:
            //The method iterates over the sequence.
            //If the sequence has at least one element, it returns true.
            //If the sequence is empty, it returns false.
        }
    }
}
