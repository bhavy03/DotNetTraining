using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement
{
    class Hardware
    {
        public int SerialNumber { get; set; }
        public string modelName { get; set; }
        public string Manufacturer { get; set; }

        public void display()
        {
            Console.WriteLine($"{SerialNumber,-15} {modelName,-20} {Manufacturer,-15}");
        }

    }
}
