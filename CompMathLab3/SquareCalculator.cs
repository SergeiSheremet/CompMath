using System;

namespace CompMathLab3
{
	static class SquareCalculator
    {
		public static double SimpsonMethod(Func<double, double> func, double left, double right, double h)
        {
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

        public static double ErrorEstimation(Func<double, double> func, double left, double right, double h)
        {
            return Math.Abs((SimpsonMethod(func, left, right, h) - SimpsonMethod(func, left, right, 2 * h))) / 15;
        }
    }
}
