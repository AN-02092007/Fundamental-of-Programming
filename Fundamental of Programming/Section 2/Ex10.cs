using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_2
{
    internal class Ex10
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double z = double.Parse(Console.ReadLine());
            double d = (x + y) * z;
            double e = x * y + y * z;
            Console.WriteLine($"Result of specified numbers {x}, {y} and {z}, (x + y).z is {d} and x.y + y.z is {e}");
            Console.ReadLine();
        }
    }
}
