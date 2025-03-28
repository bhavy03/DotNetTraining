using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking
{
    static class TransactionManager
    {
        public static void addTransaction(Account account, double amount, string type, DateTime date)
        {
            Random random = new Random();
            int randomNumber = random.Next();
            Transaction newTransaction = new Transaction() { TransactionId = randomNumber, Type = type, Amount = amount, Date = date };
            account.transactions.Add(newTransaction);
        }
        public static void Transfer()
        {
            try
            {
                Console.Write("Enter your Account Number: ");
                int fromAcc = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Sender's Account Number: ");
                int toAcc = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                var sender = AccountManager.accounts.Find(a => a.AccountNumber == fromAcc);
                var receiver = AccountManager.accounts.Find(a => a.AccountNumber == toAcc);

                if (sender == null || receiver == null)
                {
                    Console.WriteLine("Invalid Account Number.");
                    return;
                }
                if (sender.Balance < amount)
                {
                    Console.WriteLine("Insufficient Balance.");
                    return;
                }
                if (amount < 0) return;

                sender.Balance -= amount;
                receiver.Balance += amount;

                addTransaction(sender, amount, "Debit", DateTime.UtcNow);
                addTransaction(receiver, amount, "Credit", DateTime.UtcNow);

                Console.WriteLine("Transfer Done Successfully");
            }
            catch (Exception)
            {
                Console.WriteLine("Enter Valid Values");
            }
        }
        public static void viewHistory()
        {
            Console.WriteLine("Enter Account Number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());
            var account = AccountManager.accounts.Find(a => a.AccountNumber == accNo);
            if (account != null)
            {
                Console.WriteLine("Transaction History:");
                foreach (var transaction in account.transactions)
                {
                    Console.WriteLine($"{transaction.TransactionId,-15} {transaction.Type,-20} {transaction.Amount,-20} {transaction.Date,-15}");
                }
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }
    }
}
