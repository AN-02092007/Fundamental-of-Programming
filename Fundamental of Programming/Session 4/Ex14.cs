using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Session_4
{
    internal class Ex14
    {
        static void Main()
        {
            Console.WriteLine("Bai 14: " + TongCacChuSo(1234));
        }
        public static int TongCacChuSo(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}
