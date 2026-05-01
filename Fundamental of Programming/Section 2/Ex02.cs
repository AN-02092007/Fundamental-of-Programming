using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_2
{
    internal class Ex02
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số thứ nhất: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            int number2 = int.Parse(Console.ReadLine());
            int sum = number1 + number2;
            Console.WriteLine($"Tổng là: {sum}");
            Console.ReadLine();
        }
    }
}
