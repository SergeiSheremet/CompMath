using System;
using System.Collections.Generic;

namespace CompMathLab3
{
	static class NumericalIntegrator
    {
        public static LinkedList<Step> RungeKutta(Func<double, double, double> diff, double yStart, double a, double b, double h)
        {
            LinkedList<Step> log = new LinkedList<Step>();
            double y = yStart;

            for (double x = a; x < b; x += h)
            {
                double k1 = diff(x, y);
                double k2 = diff(x + h / 2, y + h * k1 / 2);
                double k3 = diff(x + h / 2, y + h * k2 / 2);
                double k4 = diff(x + h, y + h * k3);

                y += (k1 + 2 * k2 + 2 * k3 + k4) * h / 6;
                log.AddLast(new Step(x + h, y, k1, k2, k3, k4));
            }

            return log;
        }
    }
}
