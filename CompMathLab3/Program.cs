using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMathLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> func = x => 1 / (1.3 + 2.4 * x);

            Console.WriteLine(SquareCalculator.SimpsonMethod(func, 1, 2.6));
        }
    }
}
