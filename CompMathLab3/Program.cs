using System;

namespace CompMathLab3
{
	class Program
    {
        static void Main(string[] args)
        {
			const double h = 0.2;
			double left = 1;
			double right = 2.4;
			Func<double, double> func = x => 1 / (1.3 + 2.4 * x);

            Console.WriteLine(SquareCalculator.SimpsonMethod(func, left, right, h));
			Console.WriteLine(SquareCalculator.ErrorEstimation(func, left, right, h));
        }
    }
}