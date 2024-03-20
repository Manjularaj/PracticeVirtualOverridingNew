using System.Security.Principal;

namespace PracticeVirtualOverridingNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();

            SavingsAccount savingsAccount = new SavingsAccount("William Cram", 10000, 0.09);
            CheckingAccount checkingAccount = new CheckingAccount("Manjula Rajan", 20000, 5);
            RetirementAccount retirementAccount = new RetirementAccount("Breshna", 30000, 0.06);

            accounts.Add(savingsAccount);
            accounts.Add(checkingAccount);
            accounts.Add(retirementAccount);

            foreach (var account in accounts) //deposit 500
            {
                account.Deposit(500);
            }


            foreach (var account in accounts) //deposit -50000
            {
                account.Deposit(-50000);
            }

            foreach (var account in accounts)
            {
                account.Withdraw(200);// Withdraw 200
            }


            foreach (var account in accounts)
            {
                account.Withdraw(-200000);// Witddraw 200000


            }

            foreach(var account in accounts)//Try to overdraw each account
            {

                account.Withdraw(account.Balance + 500);
            }


            foreach (var account in accounts)
            {

                Console.WriteLine(account);
            }

        }
    }
}