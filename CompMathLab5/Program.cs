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
            Func<double, double, double> diff = (x, y) => x * Math.Pow(y, 2) - y;

            LinkedList<Step> result = NumericalIntegrator.RungeKutta(diff, 1, 0, 2, 0.1);

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
