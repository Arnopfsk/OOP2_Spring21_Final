using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_Account
{
    class Special_Savings : Accounts
    {
        public Special_Savings(int maximumTransaction)
        {
            this.maximumTransaction = maximumTransaction;
        }
        public Special_Savings(string name, int? accNo, double bal, int maximumTransactions) : base(name, accNo, bal)
        {
            this.maximumTransaction = maximumTransaction;
        }
        public override void Withdraw(double amount)
        {
            if (TransactionNum <= maximumTransaction && Balance - amount >= amount * 20 / 100)
            {
                Balance -= amount;
                TransactionNum++;
                Console.WriteLine("Withdraw done sucessfully.");
            }
            else
            {
                Console.WriteLine("Amount is not available.");
            }
        }
    }
}