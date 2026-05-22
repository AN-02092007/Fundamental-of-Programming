using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Session_4
{
    internal class Ex12
    {
        static void Main()
        {
            Console.WriteLine("Bai 12: " + CelsiusToFahrenheit(25));
        }
        public static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }
    }
}
