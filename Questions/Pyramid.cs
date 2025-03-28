using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class Pyramid
    {
        public void printPyramid(int n)
        {
            for(int i = n; i >= 0; i--)
            {
                for(int j = 1;j<= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
