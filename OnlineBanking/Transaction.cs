﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
