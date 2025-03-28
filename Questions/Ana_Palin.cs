using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class Ana_Palin
    {
        static int countPalindrome = 0;
        static int highestPalindrome = 0;
        static int countAnagrams = 0;
        static List<int> numbers;
        public static void takeInput()
        {
            Console.WriteLine("Enter integers separated by space:");
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        }

        static void updateFreq(int n, int[] freq)
        {
            while (n > 0)
            {
                int digit = n % 10;
                freq[digit]++;
                n /= 10;
            }
        }
        static bool isAnagram(int a, int b)
        {
            int[] freqA = new int[10];
            int[] freqB = new int[10];

            updateFreq(a, freqA);
            updateFreq(b, freqB);

            for (int i = 0; i < 10; i++)
            {
                if (freqA[i] != freqB[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static int totalAnagrams()
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (i != j && isAnagram(numbers[i], numbers[j]))
                    {
                        countAnagrams++;
                    }
                }
            }

            return countAnagrams/2;
        }

        static bool IsPalindrome(string str)
        {
            int left = 0, right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right]) return false;
                left++;
                right--;
            }
            return true;
        }

        public static int totalPalindromes()
        {
            foreach (int num in numbers)
            {
                if (IsPalindrome(num.ToString()))
                {
                    countPalindrome++;
                    highestPalindrome = Math.Max(highestPalindrome, num);
                }
            }
            return countPalindrome;
        }

        public static int hightestPalindrome()
        {
            return highestPalindrome;
        }
    }
}
