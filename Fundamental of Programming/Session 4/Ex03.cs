using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Session_4
{
    internal class Ex03
    {
        static void Main()
        {
            Console.WriteLine("Bai 3: Max = " + TimMax(4, 9, 2));
        }
        public static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
    }
}
