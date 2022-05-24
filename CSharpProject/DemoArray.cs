using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpProject.ARR
{
    internal class DemoArray
    {
        static void Main(String[] args)
        {
            //Print numbers

            int[] NUM = new int[10];

            NUM[0] = 10;

            NUM[1] = 20;

            Console.WriteLine(NUM[0]);

            Console.WriteLine(NUM[1]);

            //Create String array and store colors into it

            String[] color = new string[3];

            color[0] = "Red";
            color[1] = "Green";
            color[2] = "Blue";

            Console.WriteLine(color[0] +" "+color[1]+" "+ color[2]);

            //If Else condition, Logical Operator

            int Marks = Convert.ToInt32(Console.ReadLine());

            if (Marks >= 90)
            {
                Console.WriteLine("Grade is A");
            }
            else if (Marks >= 80 && Marks <= 89)
            {

                Console.WriteLine("Grade is B");
            }
            else if (Marks >= 60 && Marks <= 79)
            {

                Console.WriteLine("Grade is C");
            }
            else if (Marks >=45 && Marks <=59)
            {
                Console.WriteLine("Grade is D");
            }
            else if (Marks <= 45)
            {
                Console.WriteLine("Grade is F");
            }
            















        }
       
       
    }
}
