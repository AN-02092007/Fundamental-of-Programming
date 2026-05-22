using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Session_4
{
    internal class Ex04
    {
        static void Main()
        {
            Console.WriteLine("Bai 4: Giai thua 5! = " + TinhGiaiThua(5));
        }
        public static long TinhGiaiThua(int n)
        {
            long ketQua = 1;
            for (int i = 1; i <= n; i++)
            {
                ketQua *= i;
            }
            return ketQua;
        }
    }
}
