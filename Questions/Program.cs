using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select the Question you want to perform");
                Console.WriteLine("1. Pyramid\n2. Reverse\n3. Anagram and Palindrome\n4. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Pyramid newPyramid = new Pyramid();
                        Console.WriteLine("Enter the Value");
                        int n = Convert.ToInt32(Console.ReadLine());
                        newPyramid.printPyramid(n);
                        break;
                    case 2:
                        Reverse reverseWord = new Reverse();
                        Console.WriteLine("Enter the sentence");
                        string sen = Console.ReadLine();
                        Console.WriteLine("Word Count is: ");
                        Console.WriteLine(reverseWord.wordCount(sen));
                        Console.WriteLine("Reversed Sentence is: ");
                        reverseWord.reversedString(sen);
                        break;
                    case 3:
                        Ana_Palin.takeInput();
                        Console.WriteLine(Ana_Palin.totalAnagrams());
                        Console.WriteLine(Ana_Palin.totalPalindromes());
                        Console.WriteLine(Ana_Palin.hightestPalindrome());
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Enter Valid choice");
                        break;
                }
            }
        }
    }
}
