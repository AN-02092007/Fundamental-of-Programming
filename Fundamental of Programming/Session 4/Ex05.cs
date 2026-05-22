using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Session_4
{
    internal class Ex05
    {
        static void Main()
        {
            Console.WriteLine("Bai 5: " + DaoNguocChuoi("hello"));
        }
        public static string DaoNguocChuoi(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
