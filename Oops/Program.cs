using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constructors.constructors();
            Console.WriteLine("Hello");

            //object intialization using getter and setter
            //var person = new Person //can also use Person
            //{
            //    Name = "James",
            //    Age = 25
            //};
            //Console.WriteLine(person.Name);

            //object initialization using constructors
            //var employee = new Employee("James")
            //{
            //    Designation = "Manager"
            //};
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Employee
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public Employee(string name)
        {
            Name = name;
        }
    }
}

