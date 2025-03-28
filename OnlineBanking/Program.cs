using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Online Banking System");
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Check balance\n2. View Transaction History\n3. Balance Transfer\n4. Add Record\n5. Search Record\n6. Cheque Book Allotment\n7. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Account Number; ");
                        int accNo = Convert.ToInt32(Console.ReadLine());
                        AccountManager.CheckBalance(accNo);
                        break;
                    case 2:
                        Console.WriteLine($"{"ID",-15} {"Type",-20} {"Amount",-20} {"Date",-15}");
                        TransactionManager.viewHistory();
                        break;
                    case 3:
                        TransactionManager.Transfer();
                        break;
                    case 4:
                        AccountManager.addAccount();
                        break;
                    case 5:
                        Console.WriteLine("Enter Account Number; ");
                        int acNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{"Account Number",-15} {"Name",-15} {"Balance",-15}");
                        AccountManager.searchRecord(acNo);
                        break;
                    case 6:
                        AccountManager.checkBookAllotment();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Enter a valid choice!");
                        break;
                }
            }
        }
    }
}
