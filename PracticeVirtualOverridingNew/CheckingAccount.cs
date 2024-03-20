using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVirtualOverridingNew
{
    public class CheckingAccount: BankAccount
    {

        public double OverdraftFee { get; set; }

        public CheckingAccount(string name, double balance, double overdraftFee) : base(name, balance)
        {
            OverdraftFee = overdraftFee;
        }

        public override bool Withdraw(double amount)
        {
            if (!base.Withdraw(amount))
            {
                Balance -= OverdraftFee;
                Console.WriteLine($"Overdraft fee of {OverdraftFee:C} applied.");
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Overdraft Fee: {OverdraftFee:C}";
        }
    }
}
