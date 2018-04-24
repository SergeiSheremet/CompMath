using System;
using System.Collections.Generic;

namespace CompMathLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[][] system =
            {
                new double[] { 2, -6, 3, -1 },
                new double[] { 7, 2, -15, -32 },
                new double[] { 1, -4, 9, 5 }
            };

            double[] answer = EquationsSystemSolver.Solve(system);

            Console.WriteLine("System of Equations");
            foreach (var i in system)
            {
                foreach (var j in i)
                {
                    Console.Write(j + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Solution of the System of Equations");
            foreach (var i in answer)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine();
        }
    }
}
