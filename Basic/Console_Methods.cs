using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//That Console class is coming from the System namespace.
//And the System namespace is present in the System Assembly.

//System is a namespace but belongs to the .NET base class library.

//and BCL is a collection of libraries (DLLs) that provide fundamental functionalities.

//C#.NET is a completely Object-Oriented Programming Language.

//same assembly means same project

//internal means Accessible only within the same assembly.

//.NET Ecosystem(including ASP.NET, WinForms, etc.) -> .NET Runtime(CLR) -> BCL -> System

//A namespace is a container that contains a group of related classes and interfaces, 
//as well as, a namespace can also contain other namespaces.

//Generally, the namespace name will be the same as the project name but it is not mandatory, 
//you can give any user-defined name to the namespace.

//Console is a class

//Read(): This method read a single character from the keyboard and returns its ASCII value.
//The Datatype should be int as it returns the ASCII value.

//ReadKey():  This method reads a single character from the keyboard and 
//returns that character information like what key has been entered, 
//and what its corresponding ASCII value is.


namespace Basic
{
    public static class Console_Methods
    {
        public static void PrintMessages()
        {
            Console.WriteLine("Hello world");
            Project.dog dd = new Project.dog();
            dd.a = 3;
            Console.WriteLine(dd.a);

            Console.Title = "My Custom Console App";
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();
            //Apply background color immediately
            //it will apply color to whole console
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.CursorSize = 50;
            // 50% size of the full cursor height

            Console.Write("HI ");
            Console.Write("C#.NET ");
            Console.WriteLine("Welcome");

            //string name1 = Console.ReadLine();
            //string name2 = "Kunal";
            //Console.WriteLine(name1);
            //Console.WriteLine("Hello " + name1);
            //Console.WriteLine($"Hello {name1} and {name2}");

            //int num1 = Convert.ToInt32(Console.Read());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num1);

            //Console.Beep();
            //Console.ResetColor();
            //Console.Clear();

            //Console.ReadKey();
        }
    }
    //class dog
    //{
    //    public int a;
    //}
}

namespace Project
{
    public class dog
    {
        public int a;
    }
}
