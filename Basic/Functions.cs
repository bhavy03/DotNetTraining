using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Basic
{
    //here function signature is swap(int a,int b)
    //in function overloading if same number of parameters and the same type of parameters.
    //So, this is invalid.It doesn’t matter what type of data a function is returning.
    //If two functions have the same number of parameters and of the same type, then this is invalid.

    //In.NET Framework, by default, all the objects are called by value, not called by reference.
    //so in case of primitives or say value types they are stored in stack 
    //while in reference types they store a reference of object to heap memory therefore they work 
    //when we try to change the object with another reference variable 

    //And why this happens is because what one reference variable is storing ? i.e the address of object in heap
    //now as we know everything is pass by copy therefore the address of object get copied to another 
    //reference variable and therefore value change occurs.
    public static class Functions
    {
        public static void swap(ref int a,ref int b)
        {
            //without using ref it will not swap the variables and only make another copy of this
            int temp = a;
            a = b;
            b = temp;

            Console.Write(a);
            Console.WriteLine(b);
        }
        public static void cbvcbr()
        {
            Employee Emp1 = new Employee();
            Emp1.EmployeeID = 1001;
            Emp1.Name = "James";

            UpdateName(Emp1);
            Console.WriteLine($"Emp1 Name = {Emp1.Name}");
        }
        public static void UpdateName(Employee Emp2)
        {
            Emp2 = null;
            //now in this what happens is reference is passed by value and initially Emp2 will point
            //to the location of Emp1 and then Emp2 will point to null but Emp1 will still point to the location
            //now If we want to make Emp1 also null, when you set Emp2 as null,
            //then you have to pass it to the method via reference, which is done in C# by using the ref Keyword,
        }

    }
    public class Employee
    {
        public int EmployeeID;
        public string Name;
    }
}
