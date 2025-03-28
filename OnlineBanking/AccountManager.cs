using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking
{
    public static class AccountManager
    {
        public static List<Account> accounts = new List<Account>();

        public static void addAccount()
        {
            try
            {
                Console.Write("Enter Account Number: ");
                int accNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Account Holder Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Initial Balance: ");
                double balance = Convert.ToDouble(Console.ReadLine());
                Account newAccount = new Account() { AccountNumber = accNo, AccountHolderName = name, Balance = balance };

                accounts.Add(newAccount);
                Console.WriteLine("Account Added successfully");
            }
            catch (Exception)
            {
                Console.WriteLine("Enter valid Values!!");
            }
        }

        public static void CheckBalance(int accountNumber)
        {
            var account = accounts.Find(acc => acc.AccountNumber == accountNumber);
            if (account != null)
            {
                Console.WriteLine("Here is your Account Balance: ");
                Console.WriteLine(account.Balance);
            }
            else
            {
                Console.WriteLine("No Record Found");
            }

        }

        public static void searchRecord(int accNo)
        {
            var account = accounts.Find(acc => acc.AccountNumber == accNo);
            if (account != null)
            {
                Console.WriteLine($"{account.AccountNumber,-15} {account.AccountHolderName,-15} {account.Balance,-15}");
            }
            else
            {
                Console.WriteLine("No record found !!");
            }
        }

        public static void checkBookAllotment()
        {
            Console.Write("Enter Account Number: ");
            int accNum = Convert.ToInt32(Console.ReadLine());
            var account = accounts.Find(a => a.AccountNumber == accNum);
            if (account != null)
            {
                Console.WriteLine($"Checkbook Allotted to {account.AccountHolderName}");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }

        }
    }
}
