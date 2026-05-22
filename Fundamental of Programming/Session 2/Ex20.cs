using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_2
{
    internal class Ex20
    {
        public static void Main(string[] args)
        {
            Console.Write("First Number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            double b = double.Parse(Console.ReadLine());
            double c = Math.Abs(a - b);
            if (a>b)
            {
                Console.WriteLine(c * 2);
            }
            else
            {  
                Console.WriteLine(c); 
            }    
            Console.ReadLine();
        }
    }
}
