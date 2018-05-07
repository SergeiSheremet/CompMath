using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMathLab6
{
	static class NumericalDifferentiator
	{
		public static double NewtonPolynomial(Func<double, double> func, double point, double left, double right, double step)
		{
			int number = (int)((right - left) / step);
			double[][] coeffs = new double[number][];
			coeffs[0] = new double[number];

			for (int i = 0; i < coeffs[0].Length; i++)
			{
				coeffs[0][i] = func(left + i * step);
			}

			for (int i = 1; i < coeffs.Length; i++)
			{
				coeffs[i] = new double[number - i];

				for (int j = 0; j < coeffs[i].Length; j++)
				{
					coeffs[i][j] = coeffs[i - 1][j + 1] - coeffs[i - 1][j];
				}
			}

			double t = (point - left) / step;

			return 0;
		}
	}
}
