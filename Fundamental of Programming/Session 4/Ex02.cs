using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Session_4
{
    internal class Ex02
    {
        static void Main()
        {
            Console.WriteLine("Bai 2: " + KiemTraChan(10));
        }
        public static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }
    }
}
