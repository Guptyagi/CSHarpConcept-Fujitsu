using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class Program1
    {


        

        static void Main(String[] args)
        {
            double res=Area.AreaCalculation(5);
            Console.WriteLine("Area of Circle is : " + res);

            res = Area.AreaCalculation(10);
            Console.WriteLine("Area of Circle is : " + res);

            double output=Area.AreaOfTriangle(10.2, 14.9);
            Console.WriteLine("Area of Triangle is : " + output);




        }
    }
}
