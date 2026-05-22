using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Session_4
{
    internal class Ex13
    {
        static void Main()
        {
            int[] arr = { 10, 5, 8, 2, 9 };
            Console.WriteLine("Bai 13: " + TimMin(arr));
        }
        public static int TimMin(int[] arr)
        {
            int min = arr[0];
            foreach (int num in arr)
            {
                if (num < min) min = num;
            }
            return min;
        }
    }
}
