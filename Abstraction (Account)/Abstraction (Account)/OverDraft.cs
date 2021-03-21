using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_Account
{
    class Overdraft : Accounts
    {
        double overdraftLimit;

        public Overdraft(double overdraftLimit)
        {
            this.overdraftLimit = overdraftLimit;
        }
        public Overdraft(string name, int? accNo, double bal, double overdraftLimit) : base(name, accNo, bal)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount)
        {
            if (amount <= Balance + overdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine("Withdraw done sucessfully.");
            }
            else
            {
                Console.WriteLine("Withdraw cant not be done.");
            }
        }
    }
}