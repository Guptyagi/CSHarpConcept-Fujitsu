using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpProject.ARR
{
    internal class DemoArray
    {
        static void Main2(String[] args)


        {
            //Another way of handling loop ForEach Loop

            int[] nn = { 100,90,80,70,60,50,40,30,20,10 };

            foreach (int x in nn)
            {
                if (x >= 50)
                {
                    Console.WriteLine(x);

                }
                
            }



            int[] n = { 10, 20, 30, 40, 50, 60, 70, 80 };

            int l = n.Length;

            for (int i = 0; i < l; i++)
            {

                Console.WriteLine(n[i]);
            }
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

            //Grade based on Marks

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

            //For Loop


            


            















        }
       
       
    }
}
