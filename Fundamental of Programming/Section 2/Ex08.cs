using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_2
{
    internal class Ex08
    {
        public static void Run()
        {
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                int ketqua = n * i;
                Console.WriteLine($"{n} * {i} = {ketqua}");
            } 
            Console.ReadLine();
        }
    }
}
