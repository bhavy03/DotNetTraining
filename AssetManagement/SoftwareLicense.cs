using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement
{
    class SoftwareLicense
    {
        public int serialNumber { get; set; }
        public string softwareName { get; set; }
        public string licenseKey { get; set; }
        public DateTime expiryDate { get; set; }

        public void display()
        {
            Console.WriteLine($"{serialNumber,-15} {softwareName,-20} {licenseKey,-20} {expiryDate,-15}");
        }

    }
}
