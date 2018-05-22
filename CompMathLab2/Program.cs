using System;

namespace CompMathLab2
{
	class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> func = x => 2 - 0.5 * Math.Pow(x, 2) - 0.5 * Math.Pow(x, -1) * Math.Sin(x) - x;
            Func<double, double> der = x => 0.5 * Math.Sin(x) / Math.Pow(x, 2) - x - 0.5 * Math.Cos(x) / x - 1;

            Console.WriteLine($"Binary search method: {RootFinder.BinarySearch(func, 1, 2)}");
            Console.WriteLine($"Chord method: {RootFinder.ChordMethod(func, 1, 2)}");
            Console.WriteLine($"Tangent method: {RootFinder.TangentMethod(func, der, 2)}");
        }
    }
}