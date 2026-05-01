using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_2
{
    internal class Ex09
    {
        public static void Run()
        {
            Console.Write("Enter the First number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            double d = double.Parse(Console.ReadLine());
            double[] numbers = { a, b, c, d };
            double average = numbers.Average();
            Console.WriteLine($"The average of {a}, {b}, {c}, {d} is: {average}");
            Console.ReadLine();
        }
    }
}
