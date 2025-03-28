using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basic
{
    public static class Strings
    {
        public static void strings()
        {
            //You can use any one of them i.e.either string or String.
            //But as per the naming convention when you are creating a variable 
            //use the small string(i.e. string) and whenever you want to invoke methods on the string 
            //then use the capital string(i.e.String)

            //string str = "bhavya";
            //str = "kuanl";
            //Console.WriteLine(str);

            //They made Strings Immutable for Thread Safety
            //and not int and value types cause they are stored in stack
            //and copied by value and each thread gets its own copy
            //therefore no shared reference and no race condition

            //strings are immutable but now what happening here is
            //str at first refers to the object bhavya and then after it refers to 
            //the object kunal and bhavya is available for GC.
            //therefore in this manner they are immutable

            //now in the case of value type what happens is, if int x = 200 and then x = 100
            //now the value at address of x gets modified or say override to 100 no new object is formed

            //The String Intern in C# is a process that uses the same memory location if the value is the same.

            //now but in case of string concatenation the immutability behaviour generates problem
            //as it creates a new object every time a new string is formed so for this we have stringbuilder

            //StringBuilder stringBuilder = new StringBuilder();
            //if we run this in loop then it will not create new object
            //rather it will override the same object
            //stringBuilder.Append("DotNet Tutorials");
        }
    }
}
