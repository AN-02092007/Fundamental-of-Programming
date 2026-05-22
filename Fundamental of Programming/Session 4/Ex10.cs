using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Session_4
{
    internal class Ex10
    {
        static void Main()
        {
            int[] arr = { 4, 5, 6, 7 };
            Console.WriteLine("Bai 10: " + TinhTrungBinh(arr));
        }
        public static double TinhTrungBinh(int[] arr)
        {
            double sum = 0;
            foreach (int num in arr) sum += num;
            return sum / arr.Length;
        }
    }
}
