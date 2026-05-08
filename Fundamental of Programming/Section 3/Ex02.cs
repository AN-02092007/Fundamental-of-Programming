using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_3
{
    internal class Ex02
    {
        public static void Run()
        {
            // Exercise of Data Types slide
            Console.WriteLine("Exercise 1:");
            Console.Write("");
            double Celsius = double.Parse(Console.ReadLine());
            double CtoK = Celsius + 273;
            double CtoF = Celsius * 18 / 10 + 32;
            Console.WriteLine($"Kelvin = {CtoK}");
            Console.WriteLine($"Fahrenheit = {CtoF}");
            Console.ReadLine();


            Console.WriteLine("Exercise 2:");
            Console.Write("");
            double r = double.Parse(Console.ReadLine());
            double S = 4 * Math.PI * Math.Pow(r, 2);
            double V = 4.0 / 3.0 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Surface: {S}");
            Console.WriteLine($"Volume: {V}");
            Console.ReadLine();


            Console.WriteLine("Exercise 3:");
            Console.Write("");
            double a = double.Parse(Console.ReadLine());
            Console.Write("");
            double b = double.Parse(Console.ReadLine());
            double cong = a + b;
            double tru = a - b;
            double nhan = a * b;
            double chia = a / b;
            double mod = a % b;
            Console.WriteLine($"{a} + {b} = {cong}");
            Console.WriteLine($"{a} - {b} = {tru}");
            Console.WriteLine($"{a} x {b} = {nhan}");
            Console.WriteLine($"{a}/{b} = {chia}");
            Console.WriteLine($"{a} mod {b} = {mod}");
            Console.ReadLine();
        }
    }
}
