using System;

namespace CompMathLab6
{
	class Program
	{
		static void Main(string[] args)
		{
			Func<double, double> func = x => 1 / (2 * x * x + 3 * x + 1);
			double point = 1.5;
			double left = 1;
			double right = 2;
			double step = 0.25;

			Console.WriteLine(NumericalDifferentiator.NewtonPolynomial(func, point, left, right, step));
		}
	}
}