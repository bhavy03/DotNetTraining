using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class Reverse
    {
        string[] strArray;
        public int wordCount(string sen)
        {

            if (!string.IsNullOrEmpty(sen))
            {
                strArray = sen.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return strArray.Count();
            }
            else
            {
                return 0;
            }
        }

        public void reversedString(string sen)
        {
            if (!string.IsNullOrEmpty(sen))
            {
                foreach (string word in strArray)
                {
                    for (int i = word.Length - 1; i >= 0; i--)
                    {
                        Console.Write(word[i]);
                    }
                    Console.Write(" ");
                }

            }
            else
            {
                Console.WriteLine("Empty String");
            }
        }

    }
}
