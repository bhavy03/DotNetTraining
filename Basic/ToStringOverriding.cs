using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    //The Object class is the Superclass of all dot net types
    //The difference is Convert.ToString() method handles null
    //whereas the ToString() doesn’t handle null in C#.

    //if string variable declared and hasn't assigned any value then 
    //by default the variable takes null value,in this case
    //ToString will throw NULL reference exception,on other hand 
    //Convert.ToString() will not throw an exception.

    public static class ToStringOverriding
    {
        public static void overriding()
        {
            Employee emp = new Employee();
            emp.FirstName = "Pranaya";
            emp.LastName = "Rout";
            Console.WriteLine(emp.ToString());
        }

        public class Employee
        {
            public string FirstName;
            public string LastName;
            //Overriding the Virtual ToString method of Object class
            //Overriding the Virtual method using override modifier
            public override string ToString()
            {
                return FirstName + ", " + LastName;
            }
        }
    }
}


//Checked Keyword in C# is used to explicitly enable overflow checking for 
//integral-type arithmetic operations and conversions. 
//The Unchecked Keyword in C# is used to suppress overflow-checking for 
//integral-type arithmetic operations and conversions.

//int a = 2147483647;
//int b = 2147483647;
//int c = checked(a + b);  //throw overflow execption
//int c = unchecked(a + b);  //will give -2 and work as default behaviour of compiler

//for statement class obj = new class();
//class obj will not allocate any memory for instance of class
//It only allocates a variable with the name obj in the stack and sets its value to null. 
//When it hits the new keyword, it allocates memory in the heap.