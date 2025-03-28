using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace Basic
{
    class Programs
    {
        static void Main(string[] args)
        {
            //Console_Methods.PrintMessages();

            //Datatypes.DataTypes();

            //Literals.literal();

            //Day2.appdomain();

            //int a = 2;
            //int b = 3;
            //Console.Write(a);
            //Console.WriteLine(b);
            //Functions.swap(ref a, ref b);
            //Console.Write(a);
            //Console.WriteLine(b);
            //Functions.cbvcbr();

            //int number1 = Convert.ToInt32(Console.ReadLine());
            //int number2 = 20, sum;
            //sum = number1 + number2;
            //Console.WriteLine("{0} + {1} = {2}", number1, number2, sum);

            //Strings.strings();

            //Static_NS.Static();

            //Properties.properties();

            int x = 10;
            object y = x;  // here it is boxing value type to reference type(object)
            int z = (int)y; // here it is unboxing reference type to value type

            newclass neww = new newclass()
            {
                Message = 23
            };
            //can initialize the public fields and properties like this

        }
    }
    public class newclass
    {
        public int Message;
        public void GenericMethod()
        {
            Console.WriteLine("Hello world");
        }
    }
}

