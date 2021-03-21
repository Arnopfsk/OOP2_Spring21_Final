using System;

namespace Abstraction_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Accounts acc1 = new Special_Savings("Arnop", 00001, 10000, 01);
            Special_Savings s1 = new Special_Savings(30);
            
            Overdraft od = new Overdraft("Fahim", 00002, 20000, 5000);
            Accounts acc2 = new Overdraft(2000);

        }
    }
}