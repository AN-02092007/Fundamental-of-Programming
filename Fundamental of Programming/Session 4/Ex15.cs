using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Session_4
{
    internal class Ex15
    {
        static void Main()
        {
            int[] arr = { 3, 1, 4, 2 };
            Console.Write("Bai 15: ");
            SapXepMang(arr);
        }
        public static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);
            foreach (int num in arr)
            {
                Console.Write(num);
            }
            Console.WriteLine();
        }
    }
}
