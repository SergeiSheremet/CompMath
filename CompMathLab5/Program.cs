using System;
using System.Collections.Generic;

namespace CompMathLab3
{
	class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> diff = (x, y) => ((8 + 12 * Math.Cos(x)) * Math.Exp(2 * x) - 3 * Math.Pow(y, 2) * Math.Cos(x)) / (2 * y);

            LinkedList<Step> result = NumericalIntegrator.RungeKutta(diff, 2, 0, 2, 0.2);

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
