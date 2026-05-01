using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_2
{
    internal class Ex03
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số thứ nhất: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            double b = double.Parse(Console.ReadLine());
            double c = a / b;
            Console.WriteLine($"Kết quả: {c}");
            Console.ReadLine();

        }
    }
}
