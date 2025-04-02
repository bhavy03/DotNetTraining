using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Week4_5
{
    internal static class Ques1
    {
        public static void DistinctChars()
        {
            Console.WriteLine("Enter the number of strings you want to enter");
            int n = Convert.ToInt32(Console.ReadLine());
            List<String> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }

            var distinctChars = list.SelectMany(chars => chars).Distinct().OrderBy(c => c).ToList();
            Console.WriteLine("Distinct characters in alphabetical order:");
            Console.WriteLine(string.Join(", ", distinctChars));
        }
    }
}
