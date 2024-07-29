using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    static class Circle
    {
        static public double GetLength (double r)
        {
            return 2 * Math.PI * r;
        }

        static public double GetArea(double r)
        {
            return Math.PI * r * r;
        }

        static public bool IsPointInside(double x, double y, double r, double x0, double y0)
        {
            double pointDistanse = Math.Sqrt(Math.Pow(x0 - x,2)+Math.Pow(y0 - y,2));
            return pointDistanse <= r;
        }
    }
}
