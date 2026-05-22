using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Session_4
{
    internal class Ex19
    {
        static void Main()
        {
            Console.WriteLine("Bai 19: " + KiemTraNamNhuan(2024));
        }
        public static bool KiemTraNamNhuan(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
