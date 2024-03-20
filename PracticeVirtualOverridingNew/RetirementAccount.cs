using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVirtualOverridingNew
{
    public class RetirementAccount: SavingsAccount
    {
        public RetirementAccount(string name, double balance, double interest) : base(name, balance, interest)
        {
        }

        public new bool Withdraw(double amount)
        {
            Console.WriteLine("Cannot withdraw from a retirement account.");
            return false;
        }



    }
}
