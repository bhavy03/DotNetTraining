using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Basic
{
    public static class Literals
    {
        public static void literal()
        {
            //The fixed values are called Literals in C#.
            //int x = 100; Here x is a variable, and 100 is literal.

            // Decimal literal
            //int a = 101; 
            // Hexa-Decimal Literal
            //int c = 0x123f; //Prefix with 0x, and suffix with f
            //Binary literal
            //int d = 0b1111; // //Prefix with 0b

            //There is no Octal Number Literals in C#
            //By Default Floating Point Literal is double

            //Character literal using Unicode representation
            //char ch2 = '\u0041';

            //string str3 = "Dot\nNet\tTutorials";
            //string str4 = @"Dot\nNet\tTutorials";
            //In this case, the escape sequences or characters will be printed as it is in the output.
            //Console.WriteLine($"str3: {str3}");
            //Console.WriteLine($"str4: {str4}");

            //int num1 = 0b10001; //Allowed
            //int num2 = 0b1000145; //Error
            //prefixed with 0b and you can use only 0 and 1.

            //int numInt = 1500;
            //Type numIntType = numInt.GetType();
            //Console.WriteLine($"numInt Type: {numIntType}");

            //The only difference between a static and constant variable is that 
            //the static variables can be modified whereas the constant variables in C# 
            //can’t be modified once it is declared


            //That means it is not mandatory to initialize a read - only variable
            //at the time of its declaration, they can also be initialized under the constructor. 
            //That means we can modify the read - only variable value only within a constructor.
            //Can't modify readonly variable
        }
    } 
}
