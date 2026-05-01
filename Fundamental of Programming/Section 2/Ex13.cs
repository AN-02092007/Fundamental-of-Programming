using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_2
{
    internal class Ex13
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", x);
            for (int i = 0; i<3; i++)
            {
                Console.WriteLine("{0} {0}", x);
            }
            Console.WriteLine("{0}{0}{0}", x);
            Console.ReadLine();
        }
    }
}
