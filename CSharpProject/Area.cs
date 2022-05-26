using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class Area
    {
        public  double AreaCalculation(int r)
        {
            double area = 3.14 * r * r;
            return area;
        }

        public static double AreaOfTriangle(double height, double base1)
        {
            return (base1 * height)/2;


        }

    }
}
