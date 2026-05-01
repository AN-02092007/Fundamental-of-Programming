using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_2
{
    internal class Ex05
    {
        public static void Run()
        {
            Console.Write("Input the First Number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number: ");
            int b = int.Parse(Console.ReadLine());
            int temp = a;
            a = b; 
            b = temp;
            Console.WriteLine("After Swapping:");
            Console.WriteLine($"First Number: {a}");
            Console.WriteLine($"Second Number: {b}");
            Console.ReadLine();
        }
    }
}
