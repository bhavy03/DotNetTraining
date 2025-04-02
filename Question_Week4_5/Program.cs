using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Week4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the problem you want solution of:");
            Console.WriteLine("1. Ques1\n2. Ques2\n3. Ques3\n4. Ques4\n5. Ques5\n6. Ques6");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Ques1.DistinctChars();
                    break;
                case 2:
                    Ques2.SelectNth();
                    break;
                case 3:
                    Ques3.TotalQuantity();
                    break;
                case 4:
                    Ques4.thresholdGreater();
                    break;
                case 5:
                    Ques5.expensive();
                    break;
                case 6:
                    Ques6.joining();
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    break;
            }
        }
    }
}
