using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Session_4
{
    internal class Ex11
    {
        static void Main()
        {
            Console.WriteLine("Bai 11: " + KiemTraDoiXung("radar"));
        }
        public static bool KiemTraDoiXung(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);
            return s == reversed;
        }
    }
}
