using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_2
{
    internal class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input first integer: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer: ");
            double b = double.Parse(Console.ReadLine());
            if (a * b<0)
            {
                Console.WriteLine("True");
            }
            else
            {  Console.WriteLine("False"); 
            }
            Console.ReadLine();
        }
    }
}
