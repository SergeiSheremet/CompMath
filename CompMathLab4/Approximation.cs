using System;
using System.Collections.Generic;
using System.Linq;

namespace CompMathLab4
{
	static class Approximation
    {
        public static (double k, double b) FiberMethod(IList<double> xList, IList<double> yList)
        {
            Validation(xList, yList);

            double k = (yList[yList.Count - 1] - yList[0]) / (xList[xList.Count - 1] - xList[0]);
            double b = yList[0] - k * xList[0];

            return (k, b);
        }

        public static (double k, double b) LeastSquares(IList<double> xList, IList<double> yList)
        {
            Validation(xList, yList);

            double xSum = xList.Sum();
            double ySum = yList.Sum();
            double xSqrSum = 0;
            double xySum = 0;

            foreach(double x in xList)
            {
                xSqrSum += x * x;
            }

            for(int i = 0; i < xList.Count; i++)
            {
                xySum += xList[i] * yList[i];
            }

            double k = (xList.Count * xySum - xSum * ySum) / (xList.Count * xSqrSum - xSum * xSum);
            double b = (ySum - k * xSum) / xList.Count;

            return (k, b);
        }
        
        public static double DeviationSumOfSquares(double k, double b, IList<double> xList, IList<double> yList)
        {
            Validation(xList, yList);

            double e = 0;

            for (int i = 0; i < xList.Count; i++)
            {
                e += Math.Pow(yList[i] - k * xList[i] - b, 2);
            }

            return e;
        }
        
        private static void Validation(IList<double> xList, IList<double> yList)
        {
            if ((xList.Count != yList.Count) || (xList.Count < 2)) throw new Exception();
        }
    }
}
