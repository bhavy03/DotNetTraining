using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement
{
    class Books
    {
        public int serialNumber { get; set; }
        public string nameOfBook { get; set; }
        public string author { get; set; }
        public DateTime Date { get; set; }


        public void display()
        {
            Console.WriteLine($"{serialNumber,-15} {nameOfBook,-20} {author,-20} {Date,-15}");
        }

    }
}
