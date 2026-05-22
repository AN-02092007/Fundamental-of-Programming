using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_3
{
    internal class Ex03
    {
        public static void Main(string[] args)
        {
            //Exercise of Operators and Control Flow slide
            Console.WriteLine("Exercise 1:");
            Console.Write("Enter first edge: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second edge: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter third edge: ");
            double c = double.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("This is a triangle.");
                if (a == b && b == c)
                {
                    Console.WriteLine("This is an equilateral triangle.");
                }
                else if (a == b || b == c || c == a)
                {
                    Console.WriteLine("This is an isosceles triangle.");
                }
                else
                {
                    Console.WriteLine("This is a scalene triangle.");
                }
            }
            else
            {
                Console.WriteLine("This is not a triangle.");
            }
            Console.ReadLine();


            //Exercise 2:
            Console.WriteLine("Exercise 2:");
            double sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"");
                double h = double.Parse(Console.ReadLine());
                sum += h;
            }
            double avg = sum / 10;
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {avg}");
            Console.ReadLine();


            //Exercise 3:
            Console.WriteLine("Exercise 3:");
            Console.Write("Enter the number: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                int nhan = x * i;
                Console.WriteLine($"{x} x {i} = {nhan}");
            }
            Console.ReadLine();


            //Exercise 4:
            Console.WriteLine("Exercise 4:");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine(j);
                }
            }
            Console.ReadLine();


            //Exercise 5:
            Console.WriteLine("Exercise 5:");
            int k = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k++;
                }
                Console.WriteLine();
            }

            int num = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int space = 1; space <= 4 - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();


            //Exercise 6:
            Console.WriteLine("Exercise 6:");
            Console.Write("Enter the number of terms (n): ");
            int n = int.Parse(Console.ReadLine());
            double tong = 0.0;
            Console.Write("Harmonic Series: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i} ");
                if (i < n) Console.Write("+ ");
                tong += 1.0 / i;
            }
            Console.WriteLine($"Sum of Series = {tong}");
            Console.ReadLine();


            //Exercise 7:
            Console.WriteLine("Exercise 7:");
            Console.Write("Enter start of range: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end of range: ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine($"Perfect numbers between {start} and {end}:");
            for (int i = start; i <= end; i++)
            {
                int total = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0) total += j;
                }
                if (total == i && i > 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();


            //Exercise 8:
            Console.WriteLine("Exercise 8:");
            Console.Write("Enter start of range: ");
            int bd = int.Parse(Console.ReadLine());
            Console.Write("Enter end of range: ");
            int kt = int.Parse(Console.ReadLine());

            Console.WriteLine($"Perfect numbers between {bd} and {kt}:");

            for (int i = bd; i <= kt; i++)
            {
                int cong = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0) cong += j;
                }
                if (cong == i && i > 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
