using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    //OOPs, is a technique, not a technology.
    //constructors are the special types of methods of a class that are executed
    //whenever we create an instance (object) of that class.
    //The constructor method does not return any value. 
    //by default if no constructor is created then default constructor(i.e implicit constructor)
    //is created at compile time in which all variables are initialized with either 0 or null or false
    //Implicitly Defined Constructors are public.
    //Test test = new Test();
    //here Test is class name and Test() is constructor
    public class Constructors
    {
        public static void constructors()
        {
            //CopyConstructor obj1 = new CopyConstructor(10);
            //obj1.Display();
            CopyConstructor obj3 = new CopyConstructor();
            //CopyConstructor obj2 = new CopyConstructor(obj1);
            //obj2.Display();
        }
    }
    public class CopyConstructor
    {
        int x;
        public CopyConstructor()
        {
            int a = 30;
            Console.WriteLine(a);
        }
        public CopyConstructor(int i)
        {
            x = i;
        }
        //Copy Constructor
        //it is basically that constructor which takes a class or say constructor as a argument


        public CopyConstructor(CopyConstructor obj)
        {
            x = obj.x;
        }

        //If a class contains any static variables, 
        //then only implicit static constructors come into the picture otherwise 
        //we must be defined them explicitly.

        //Static Constructors are responsible for initializing static variables 
        //and these constructors are never called explicitly.
        //They are called Implicitly and moreover, 
        //these constructors are the first to execute in any class

        //The non-static constructors are never called implicitly,
        //they are always called explicitly whereas the static constructor never called explicitly,
        //they are always going to be called implicitly.

        //Static Constructors cannot be parameterized, so overloading of the static constructors
        //is not possible in C#.
        // why we cannot parameterize the static constructor?
        // The answer is simple. The static constructors are executed implicitly
        // and hence we never get a chance to pass a value.

        //A static constructor is only implicitly created when:
        //A class contains static fields initialized at runtime using a complex expression.
        //The compiler determines that static initialization must be deferred rather than performed at compile-time.
        //static int j = 100; for this simple it will not
        //for this it will assign a value
        //static int j = GetValue();  // Static field assigned using a method
        //static int GetValue()
        //{
        //    Console.WriteLine("Static field initialized");
        //    return 100;
        //}
        static CopyConstructor()
        {
            int a = 10;
            Console.WriteLine(a);
        }
        public void Display()
        {
            Console.WriteLine($"Value of X = {x}");
        }

        //We need to use the private constructor in C# when the class contains only static members.
        //Using a private constructor is not possible to create an instance from outside the class.
        //private CopyConstructor()
        //{
        //    Console.WriteLine("This is private constructor");
        //}
        //used when the Main method is in same class
        //if we have any private constructor and also public constructor then the class can be inherited
    }

    public class Parent
    {
        //Private Constructor
        private Parent()
        {
            Console.WriteLine("Parent Class Private Constructor is Called");
        }
        public class Child : Parent
        {
            //no need to use base() cause it is implicitely created while child constructor is created
            public Child()
            {
                Console.WriteLine("Child Class Public Constructor is Called");
            }
        }
    }

    //If you want to restrict inheritance then don’t go for the private constructor,
    //instead, make the Class Sealed which will restrict the class to be inherited
    //from either outside or inside.
}


//The most important point that you need to keep in mind is that
//a destructor method cannot have any parameters as well as cannot be applied with any modifiers.
//As the destructor is not parameterized, so we cannot overload the destructor.
//GC.Collect(); it is used for calling garbage collection
//no destructor in struct and only in a class no overloading and doesnot take modifiers
//Destructor implicitly calls the Finalize method on the base class of the object

//Child child = new Child("Bhavya"); this is how you pass string to base with child
//class Parent
//{
//    public Parent(string name)
//    {
//        Console.WriteLine($"Parent Constructor Called with Name: {name}");
//    }
//}
//class Child : Parent
//{
//    public Child(string name) : base(name) // Passes parameter to Parent Constructor
//    {
//        Console.WriteLine("Child Constructor Called");
//    }
//}


