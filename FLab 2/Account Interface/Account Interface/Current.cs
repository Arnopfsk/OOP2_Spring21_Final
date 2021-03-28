using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Interface
{
    class Current : IBasicBankingInterface
    {
        private decimal _balance;
        public bool Deposit(decimal amount)
        {
            _balance += amount;
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if (_balance < amount)
            {
                Console.WriteLine("Sorry! Withdeawal Failed");
                return false;
            }
            else
            {
                _balance -= amount;
                Console.WriteLine(String.Format("Withdraw Successfully withdraw: {0,6}", amount));

                return true;
            }
        }
    }
}