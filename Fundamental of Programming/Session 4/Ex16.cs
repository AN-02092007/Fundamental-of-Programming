using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Session_4
{
    internal class Ex16
    {
        static void Main()
        {
            Console.WriteLine("Bai 16: " + XoaTrungLap("programming"));
        }
        public static string XoaTrungLap(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if (!result.Contains(c)) result += c;
            }
            return result;
        }
    }
}
