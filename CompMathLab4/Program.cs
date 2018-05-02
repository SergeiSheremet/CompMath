using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMathLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            double alpha = 0.2;
            double beta = 0.0;
            double gamma = 0.0;

            List<double> x = new List<double>
            {
                1.1 - alpha,
                2.4 + gamma,
                4.3 - beta,
                5.9 + alpha,
                7.8 - beta,
                9.5 + alpha,
                11.0 + gamma,
                12.7 - gamma,
                13.9 + beta,
                15.4 + alpha
            };
            List<double> y = new List<double>
            {
                4.5 + gamma,
                5.2 - beta,
                5.4 + alpha,
                5.8 + beta,
                6.6 - alpha,
                6.8 + gamma,
                7.4 - alpha,
                7.5 + beta,
                7.9 + gamma,
                8.5 - gamma
            };

            //var tuple = (k: 5, b: 5);

            foreach (var i in Approximation.FiberMethod(x, y))
            {
                Console.WriteLine(i);
            }

            //Console.WriteLine(Approximation.DeviationSumOfSqures());

            foreach (var i in Approximation.LeastSquares(x, y))
            {
                Console.WriteLine(i);
            }
        }
    }
}
