using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_2
{
    internal class Ex06
    {
        public static void Run()
        {
            Console.Write("Input the first number to multiply: ");
            int so1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            int so2 = int.Parse(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            int so3 = int.Parse(Console.ReadLine());
            int multiply = so1 * so2 * so3;
            Console.WriteLine($"{so1} x {so2} x {so3} = {multiply}");
            Console.ReadLine();
        }
    }
}
