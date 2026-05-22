using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Session_4
{
    internal class Ex18
    {
        static void Main()
        {
            Console.WriteLine("Bai 18: " + DecimalToBinary(10));
        }
        public static string DecimalToBinary(int n)
        {
            if (n == 0) return "0";
            string binary = "";
            while (n > 0)
            {
                binary = (n % 2) + binary;
                n /= 2;
            }
            return binary;
        }
    }
}
