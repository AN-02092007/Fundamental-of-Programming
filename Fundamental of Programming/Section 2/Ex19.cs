using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_2
{
    internal class Ex19
    {
        public static void Run()
        {
            Console.Write("First Number: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            double number2 = double.Parse(Console.ReadLine());
            if (number1 == number2)
            {
                Console.WriteLine((number1 + number2) * 3);
            }
            else
            {
                Console.WriteLine(number1 + number2);
            }
            Console.ReadLine();
        }
    }
}
