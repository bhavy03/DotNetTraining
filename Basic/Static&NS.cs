using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Basic
{
    public static class Static_NS
    {
        static Static_NS()
        {
            Console.WriteLine("hello");
        }
        public static void Static()
        {
            //static classes can't be inherited
            //A static class cannot have constructors.
                
            //The Non-Static variables are created when the object is created 
            //and are destroyed when the object is destroyed.
            //scope of the object is the scope of its referenced variables.
            //variable inside non static block are by default non static

            //variables declared inside static block are by default static
            //Static Variable scope is the Application Scope
            //What it means, as soon as the application start and class execution starts, 
            //static variables are created and they will be there as long as your application is running.
            //Once the application stops, then static variables are going to be deleted.
            //So, the scope is application scope.

            //static constructor is the very first constructor going to execute even before 
            //the main method execution and only executes once
            //not possible to create static constructor with parameters because first block of code
            //going to execute under class and it is called implicitly

            Console.WriteLine("3");


            const float PI = 3.14f;
            //initialization is necessary at the time of declaration 
            //they are static in nature

            //not mandatory to initialize a read-only variable at the time of its declaration,
            //they can also be initialized under the constructor. 
            //That means we can modify the read - only variable value only within a constructor.
            //The read-only variable’s value cannot be modified once after its initialization.
            //readonly int x;
            //won't work cause readonly variables are non-static by default
            //and as non-static it requires an object instead.
        }
    }
}
