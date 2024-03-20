using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVirtualOverridingNew
{
    public class SavingsAccount: BankAccount
    {
        public double Interest { get; set; }

    public SavingsAccount(string name, double balance, double interest) : base(name, balance)
    {
        Interest = interest;
    }

    public override bool Deposit(double amount)
    {
        if (base.Deposit(amount))
        {
            Balance += amount * Interest;
            return true;
        }

        return false;
    }

    public override string ToString()
    {
        return base.ToString() + $" - Interest Rate: {Interest * 100}%";
    }

}//class
}//namespace
