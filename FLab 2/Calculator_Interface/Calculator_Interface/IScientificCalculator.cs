using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Interface
{
    interface IScientificCalculator
    {
        double X_to_power_y(double x, double y);
        int Absolute(int x);
        double Sin_value(double angle);
    }
}