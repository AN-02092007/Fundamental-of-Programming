using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_2
{
    internal class Ex15
    {
        public static void Run()
        {
            Console.Write("");
            string kytu = Console.ReadLine();
            string ketqua = kytu.Remove(1, 1);
            string result = kytu.Remove(kytu.Length - 1);
            string xoa = kytu.Remove(0, 1);
            Console.WriteLine($"{ketqua}");
            Console.WriteLine($"{result}");
            Console.WriteLine($"{xoa}");
            Console.ReadLine();
        }
    }
}
