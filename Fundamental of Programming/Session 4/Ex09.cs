using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Session_4
{
    internal class Ex09
    {
        static void Main()
        {
            Console.WriteLine("Bai 9: " + TinhLuyThua(2, 3));
        }
        public static double TinhLuyThua(double x, int y)
        {
            double result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }
    }
}
