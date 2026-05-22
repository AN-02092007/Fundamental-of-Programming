using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Session_4
{
    internal class Ex07
    {
        static void Main()
        {
            Console.Write("Bai 7: ");
            InFibonacci(6);
        }
        public static void InFibonacci(int n)
        {
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a);
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine();
        }
    }
}
