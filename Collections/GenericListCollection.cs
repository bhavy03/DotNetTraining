using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class GenericListCollection
    {
        public static void genericListCollection()
        {
            List<string> countries = new List<string>();
            countries.Add("INDIA");
            countries.Add("USA");
            Console.WriteLine(countries[0]);

            List<string> newCountries = new List<string>()
            {
                "JAPAN",
                "UK"
            };
            countries.AddRange(newCountries);
            countries.Insert(1, "China");
            countries.InsertRange(2, newCountries);
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }

            string[] array = new string[] { "INDIA", "USA", "UK" };
            // Copy the array to a List.
            List<string> copiedList = new List<string>(array);


            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>();
            //Adding Elements to the Dictionary using Add Method of Dictionary class
            dictionaryCountries.Add("UK", "London, Manchester, Birmingham");
            dictionaryCountries.Add("USA", "Chicago, New York, Washington");
            dictionaryCountries.Add("IND", "Mumbai, Delhi, Bhubaneswar");

            foreach (KeyValuePair<string, string> KVP in dictionaryCountries)
            {
                Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
            }
            //Accessing Dictionary Elements using For Loop
            Console.WriteLine("\nAccessing Dictionary Elements using For Loop");
            for (int i = 0; i < dictionaryCountries.Count; i++)
            {
                string key = dictionaryCountries.Keys.ElementAt(i);
                string value = dictionaryCountries[key];
                Console.WriteLine($"Key: {key}, Value: {value}");
            }

            //this is for complex types
            Dictionary<int, Student> dictionaryStudents = new Dictionary<int, Student>
            {
                { 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"} },
                { 102, new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"} },
                { 103, new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}},
            };
            foreach (KeyValuePair<int, Student> item in dictionaryStudents)
            {
                Console.WriteLine($"Key: {item.Key}, ID: {item.Value.ID}, Name: {item.Value.Name}, Branch: {item.Value.Branch}");
            }
            //see tryGetValue method if not sure key is present or not

            //Convert array to dictionary
            Student[] arrayStudents = new Student[3];
            arrayStudents[0] = new Student() { ID = 101, Name = "Anurag", Branch = "CSE" };
            arrayStudents[1] = new Student() { ID = 102, Name = "Mohanty", Branch = "CSE" };
            arrayStudents[2] = new Student() { ID = 103, Name = "Sambit", Branch = "ETC" };
            Dictionary<int, Student> dictionaryStudentss = arrayStudents.ToDictionary(std => std.ID, std => std);
            // OR        
            // Dictionary<int, Student> dictionaryStudents = arrayStudents.ToDictionary(employee => employee.ID);
            //OR use a foreach loop
            //Dictionary<int, Student> dict = new Dictionary<int, Student>();
            //foreach (Student std in arrayStudents)
            //{
            //    dict.Add(std.ID, std);
            //}
            foreach (int key in dictionaryStudents.Keys)
            {
                var student = dictionaryStudents[key];
                Console.WriteLine($"Key: {key}, ID: {student.ID}, Name: {student.Name}, Branch: {student.Branch}");
            }
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
    }
}

//in generic dictionary every key has to be unique and not null but value can be null if reference type
//Convert an array to a List – Use ToList() method
//Convert a list to an array – Use ToArray() method
//Convert a List to a Dictionary – Use ToDictionary() method
//Convert an array to a Dictionary – Use ToDictionary() method
//Convert a Dictionary to an array – Use ToArray() method on the Values Property of the dictionary object
//Convert a Dictionary to a List – Use the ToList() method on the Values Property of the dictionary object

//We cannot add elements into a Stack using Collection Initializer and the reason for this is
//the Generic Stack<T> Collection Class does not have an Add method.
//So, the point that you need to remember is if any collection class does not have the
//Add method then you cannot use Collection Initializer to add elements.

//You cannot use a for loop to access the elements of a generic stack collection
//because collection class does not have any integer indexer.