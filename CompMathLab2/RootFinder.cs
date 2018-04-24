using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMathLab2
{
    static class RootFinder
    {
        public static double BinarySearch(Func<double, double> func, double left, double right)
        {
            for (int i = 0; i < 100; i++)
            {
                double middle = (left + right) / 2;

                double funcLeft = func(left);
                double funcRight = func(right);
                double funcMiddle = func(middle);

                if (funcLeft < funcRight && funcMiddle <= 0 || funcLeft > funcRight && funcMiddle >= 0)
                {
                    left = middle;
                }
                else
                {
                    right = middle;
                }
            }

            return right;
        }

        public static double ChordMethod(Func<double, double> func, double left, double right)
        {
            for (int i = 0; i < 100; i++)
            {
                double funcLeft = func(left);
                double funcRight = func(right);

                double newPoint = left - funcLeft * (right - left) / (funcRight - funcLeft);

                if (func(newPoint) <= 0 && func(left) <= 0 || func(newPoint) >= 0 && func(left) >= 0)
                {
                    left = newPoint;
                }
                else
                {
                    right = newPoint;
                }
            }

            return left;
        }

        public static double TangentMethod(Func<double, double> func, Func<double, double> der, double point)
        {
            for (int i = 0; i < 10; i++)
            {
                double value = func(point);
                double coeff = der(point);
                point -= value / coeff;
            }

            return point;
        }
    }
}