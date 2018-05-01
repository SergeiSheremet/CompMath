using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMathLab3
{
    static class SquareCalculator
    {
        public static double SimpsonMethod(Func<double, double> func, double left, double right)
        {
            const double h = 0.2;

            double funcEven = 0;
            double funcOdd = 0;

            for (double i = left + 2 * h; i < right; i += 2 * h)
            {
                funcEven += func(i);
            }

            for (double i = left + h; i < right; i += 2 * h)
            {
                funcOdd += func(left + i * h);
            }

            return h / 3 * (func(left) + 2 * funcEven + 4 * funcOdd + func(right));
        }

        public static double ErrorEstimation(Func<double, double> func, double left, double right)
        {
            return 0;
        }
    }
}
