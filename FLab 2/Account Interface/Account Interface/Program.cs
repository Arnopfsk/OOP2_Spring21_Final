using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IBasicBankingInterface Savings = new Savings();
            IBasicBankingInterface Current = new Current();
            IBasicBankingInterface Overdraft = new Overdraft();

            Savings.Deposit(2500);
            Savings.Withdraw(800);
            Savings.Withdraw(2050);
            Savings.Deposit(1500);
            Savings.Withdraw(1000);
            Savings.Withdraw(5678);


            Current.Deposit(25000);
            Current.Withdraw(5000);
            Current.Withdraw(15000);
            Current.Deposit(2344);
            Current.Withdraw(7878);

            Overdraft.Deposit(50000);
            Overdraft.Withdraw(800);
            Overdraft.Withdraw(13000);
            Overdraft.Withdraw(60000);
            Overdraft.Deposit(700);
        }
    }
}