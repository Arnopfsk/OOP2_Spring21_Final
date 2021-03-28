using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            CasioBasic B = new CasioBasic();
            B.Sum(45, 5);
            B.Sub(45, 5);
            B.Multiplication(45, 5);
            B.Division(45, 5);

            Casioscientific S = new Casioscientific();
            S.Sin_value(145.45);
            S.Absolute(-45);
            S.X_to_power_y(2, 3);
        }
    }
}