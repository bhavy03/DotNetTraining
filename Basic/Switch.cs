﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public static class Switch
    {
        public static void switches()
        {
            string str = "C#";
            switch (str)
            {
                case "C#":
                case "Java":
                case "C":
                    Console.WriteLine("It’s a Programming Langauge");
                    break;
                case "MSSQL":
                case "MySQL":
                case "Oracle":
                    Console.WriteLine("It’s a Database");
                    break;
                case "MVC":
                case "WEB API":
                    Console.WriteLine("It’s a Framework");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
