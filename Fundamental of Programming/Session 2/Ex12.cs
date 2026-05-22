using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_2
{
    internal class Ex12
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a digit: ");
            string so = Console.ReadLine();
            for (int i = 0; i<2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}", so);
                Console.WriteLine("{0}{0}{0}{0}", so);
            }
            Console.ReadLine();
        }
    }
}
