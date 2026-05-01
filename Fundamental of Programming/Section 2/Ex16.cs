using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_2
{
    internal class Ex16
    {
        public static void Run()
        {
            Console.Write("");
            string kytu = Console.ReadLine();
            char dau = kytu[0];
            char cuoi = kytu[kytu.Length - 1];
            string giua = kytu.Substring(1, kytu.Length - 2);
            Console.WriteLine($"{cuoi}{giua}{dau}");
            Console.ReadLine();
        }
    }
}
