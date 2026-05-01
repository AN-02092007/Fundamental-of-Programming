using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_2
{
    internal class Ex17
    {
        public static void Run()
        {
            Console.Write("Input a string: ");
            string kytu = Console.ReadLine();
            char dau = kytu[0];
            Console.WriteLine($"{dau}{kytu}{dau}");
            Console.ReadLine();
        }
    }
}
