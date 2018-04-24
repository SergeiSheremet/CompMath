using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMathLab3
{
    struct Step
    {
        double x, y, k1, k2, k3, k4;

        public Step(double x, double y, double k1, double k2, double k3, double k4)
        {
            this.x = x;
            this.y = y;
            this.k1 = k1;
            this.k2 = k2;
            this.k3 = k3;
            this.k4 = k4;
        }

        public override string ToString()
        {
            return $"(x = {x}, y = {y})\nk1 = {k1}\nk2 = {k2}\nk3 = {k3}\nk4 = {k4}";
        }
    }
}
