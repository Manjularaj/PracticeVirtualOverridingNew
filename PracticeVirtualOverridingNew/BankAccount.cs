using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeVirtualOverridingNew
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string AccountNumber { get; }
        public double Balance { get; protected set; }

        public BankAccount(string name, double balance)
        {
            Name = name;
            Balance = balance;
            AccountNumber = GenerateAccountNumber();
        }

        protected string GenerateAccountNumber()
        {
            Random random = new Random();
            return random.Next(10000, 50000).ToString();
        }

        public virtual bool Deposit(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Cannot deposit a negative amount.");
                return false;
            }

            Balance += amount;
            return true;
        }

        public virtual bool Withdraw(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Cannot withdraw a negative amount.");
                return false;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
                return false;
            }

            Balance -= amount;
            return true;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - Name: {Name}, Account Number: {AccountNumber}, Balance: {Balance:C}";
        }
    }


}
