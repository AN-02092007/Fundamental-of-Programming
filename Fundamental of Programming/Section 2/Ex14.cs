using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_2
{
    internal class Ex14
    {
        public static void Run()
        {
            Console.Write("Enter the amount of celsius: ");
            double C = double.Parse(Console.ReadLine());
            double K = C + 273.15;
            double F = (C * 9.0 / 5.0) + 32;
            Console.WriteLine($"Kelvin = {K}");
            Console.WriteLine($"Fahrenheit = {F}");
            Console.ReadLine();
        }
    }
}
