using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public static class Datatypes
    {
        public static void DataTypes()
        {
            //int a = 4;
            //int b = a;
            //b = 2;
            //a = 3;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //byte b1 = 66;
            //can't store negative and max will be 255
            //Console.WriteLine(b1);
            //Console.WriteLine((char)b1);
            //Console.WriteLine($"Byte Min Value:{sbyte.MinValue} and Max Value:{sbyte.MaxValue}");
            //Console.WriteLine($"Byte Size:{sizeof(sbyte)} Byte");
            //sbyte sb2 = -100;
            //can store negative number, max is 127 and min is -128


            //char ch = 'B';
            //Console.WriteLine($"Char: {ch}");
            //Console.WriteLine($"Equivalent Number: {(byte)ch}");
            //Console.WriteLine($"Char Minimum: {(int)char.MinValue} and Maximum: {(int)char.MaxValue}");
            //Console.WriteLine($"Char Size: {sizeof(char)} Byte");


            //string str = "ABC";
            //var howManyBytes = str.Length * sizeof(Char);
            //Console.WriteLine($"str Value: {str}");
            //Console.WriteLine($"str Size: {howManyBytes}");

            //Int16 is short Int32 is int and Int64 is long
            //and for unsigned of these versions use ushort,uint,ulong


            //Single a = 1.123f;
            //Double b = 1.456;
            //Decimal c = 1.789M;
            //Single takes 4 bytes,double takes 8 and decimal takes 16
            //can also use float,double and decimal instead

            //Console.WriteLine($"Default Value of Byte: {default(byte)} ");
        }
    }
}

