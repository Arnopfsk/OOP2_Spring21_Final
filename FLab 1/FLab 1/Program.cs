using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Fahim = new Saving("Fahim", "101", 5000.0f);
            Account Sharier = new Current("Sharier", "202", 4000f);
            Account Khan = new Fixed("Khan", "303", 3000f, 2021, 17);
            Fahim.ShowInfo();
            Sharier.ShowInfo();
            Khan.ShowInfo();
        }
    }
}
