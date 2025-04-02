using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Oops
{
    internal class Partitioning
    {
        public static void partitioning()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Take the first 5 numbers
            IEnumerable<int> firstFive = numbers.Take(5);
            // Take numbers while they are less than 6
            IEnumerable<int> lessThanSix = numbers.TakeWhile(n => n < 6);
            // Skip the first 5 numbers
            IEnumerable<int> skipFirstFive = numbers.Skip(5);
            // Skip numbers while they are less than 6
            IEnumerable<int> skipLessThanSix = numbers.SkipWhile(n => n < 6);
            // Display the results
            Console.WriteLine("First Five: " + string.Join(", ", firstFive));
            Console.WriteLine("Less Than Six: " + string.Join(", ", lessThanSix));
            Console.WriteLine("Skip First Five: " + string.Join(", ", skipFirstFive));
            Console.WriteLine("Skip Less Than Six: " + string.Join(", ", skipLessThanSix));

            List<string> names = new List<string>() { "Sara", "Rahul", "John", "Pam", "Priyanka" };
            List<string> namesResult = names.TakeWhile((name, index) => name.Length > index).ToList();

            IEnumerable<int> EvenNumbers = Enumerable.Range(10, 40).Where(x => x % 2 == 0);
            //Printing the Even Numbers between 10 and 40
            foreach (int num in EvenNumbers)
            {
                Console.Write($"{num} ");
            }

            IEnumerable<string> repeatStrings = Enumerable.Repeat("Welcome to DOT NET Tutorials", 10);
            //Accessing the collection or sequence using a foreach loop
            foreach (string str in repeatStrings)
            {
                Console.WriteLine(str);
            }

            //use case of repeat
            int[] zeros = Enumerable.Repeat(0, 10).ToArray();    //use case of this
            //var mockData = Enumerable.Repeat(new TestData(), 100).ToList();
            //Use Cases:
            //Testing: For unit tests, you must create a collection of items with the same value
            //to test bulk operations or performance.
            //Mock Data: Generating mock data for testing or design purposes, such as populating
            //a UI control with dummy data to see how it looks.

            //The Empty method in LINQ generates an empty sequence of a particular type.
            //This method is useful when you need to return an empty sequence from a method
            //without returning null or when you need to start with an empty sequence and
            //conditionally populate it with elements based on further logic.
            //IEnumerable<string> emptyCollection1 = Enumerable.Empty<string>();
            //Creating Empty Collection of Student
            //IEnumerable<Student> emptyCollection2 = Enumerable.Empty<Student>();
            //Printing the Type and Count of emptyCollection1
            //Console.WriteLine("Count: {0} ", emptyCollection1.Count());
            //Console.WriteLine("Type: {0} ", emptyCollection1.GetType().Name);
            //Printing the Type and Count of emptyCollection2
            //Console.WriteLine("Count: {0} ", emptyCollection2.Count());
            //Console.WriteLine("Type: {0} ", emptyCollection2.GetType().Name);


            //in append When the source is null, it will throw ArgumentNullException
            List<int> intSequence = new List<int> { 10, 20, 30, 40 };
            // Trying to append 5 at the end of the intSequence
            intSequence.Append(5);
            //It doesn't work because the original list has not been changed
            Console.WriteLine(string.Join(", ", intSequence));
            // It works now because we are using a changed copy of the original sequence
            Console.WriteLine(string.Join(", ", intSequence.Append(5)));
            // Creating a new sequence explicitly
            List<int> newintSequence = intSequence.Append(5).ToList();
            // Printing the new sequence in the console
            Console.WriteLine(string.Join(", ", newintSequence));
            //numberSequence.Prepend(50);

            //the zip method
            //Returns: This method will return an IEnumerable<T> that contains merged elements of two input sequences.
            //Exceptions: This method will throw ArgumentNullException when either the first or the second input sequence is null.
            int[] numbersSequence = { 10, 20, 30, 40, 50 };
            string[] wordsSequence = { "Ten", "Twenty", "Thirty", "Fourty" };
            var resultSequence = numbersSequence.Zip(wordsSequence, (first, second) => first + " - " + second);
            foreach (var item in resultSequence)
            {
                Console.WriteLine(item);
            }
            //merges index by index and with fewer elements

            //The LINQ Cast method in C# is used to cast elements of a non-generic collection to a specified type.
            //It’s a part of the System.Linq namespace can be applied to any type that implements IEnumerable,
            //converting it into an IEnumerable<T> where T is the target type. 
            ArrayList list = new ArrayList
            {
                10,
                20,
                30
            };
            IEnumerable<int> result = list.Cast<int>();
            //IEnumerable<int> result = list.OfType<int>();
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}

//List<int> numbers = new List<int>() { 1, 2, 3, 6, 7, 8, 9, 10, 4, 5 };
////Using TakeWhile Method to Fetch Numbers which are less than 6
//List<int> Result1 = numbers.TakeWhile(num => num < 6).ToList();
//Console.Write("Result Of TakeWhile Method: ");
//foreach (var num in Result1)
//{
//    Console.Write($"{num} ");
//}
//Console.WriteLine();
////Using Where Method to Fetch Numbers which are less than 6
//List<int> Result2 = numbers.Where(num => num < 6).ToList();
//Console.Write("Result Of Where Method: ");
//foreach (var num in Result2)
//{
//    Console.Write($"{num} ");
//}
//result is 1 2 3 and 1 2 3 4 5

//Paging implemented like this
//To implement Paging, we need to understand two things: one is Page Number (PN),
//and the other one is the Number of Records per Page (NRP).
//Let’s say Page Number = PN and Number Of Records Per Page = NRP,
//then you need to use the following formula to implement Paging. 
//Result = DataSource.Skip((PN – 1) * NRP).Take(NRP)
