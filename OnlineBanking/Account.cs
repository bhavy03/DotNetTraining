using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double Balance { get; set; }
        public List<Transaction> transactions  = new List<Transaction>();
    }
}
