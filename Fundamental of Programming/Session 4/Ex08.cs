using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Session_4
{
    internal class Ex08
    {
        static void Main()
        {
            Console.WriteLine("Bai 8: " + DemNguyenAm("Hello World"));
        }
        public static int DemNguyenAm(string s)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";
            foreach (char c in s)
            {
                if (vowels.Contains(c)) count++;
            }
            return count;
        }
    }
}
