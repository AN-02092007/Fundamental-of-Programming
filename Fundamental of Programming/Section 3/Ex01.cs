using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_3
{
    internal class Ex01
    {
        public static void Run()
        {
            /*Exercise from C# Structure Programming Language Fundamentals slide
             Exercise 1:
             */
            Console.Write("Enter first number: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double number2 = double.Parse(Console.ReadLine());
            double sum = number1 + number2;
            Console.WriteLine($"The result of adding two numbers: {sum}");
            Console.ReadLine();


            //Exercise 2:
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            double temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After swapping: {a}, {b}");
            Console.ReadLine();


            //Exercise 3:
            Console.Write("Enter first number: ");
            double firstnumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondnumber = double.Parse(Console.ReadLine());
            double multiplication = firstnumber * secondnumber;
            Console.WriteLine($"{firstnumber} x {secondnumber} = {multiplication}");
            Console.ReadLine();


            //Exercise 4:
            Console.Write("Enter the number of feet: ");
            double feet = double.Parse(Console.ReadLine());
            double meter = 0.3048 * feet;
            Console.WriteLine($"{feet} ft = {meter} m");
            Console.ReadLine();


            //Exercise 5:
            Console.Write("Enter Celsius: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter Fahrenheit: ");
            double f = double.Parse(Console.ReadLine());
            double ctof = (c * 9.0 / 5.0) + 32;
            double ftoc = (f - 32) * 5.0 / 9.0;
            Console.WriteLine($"{c}\u00B0C = {ctof}\u00B0F");
            Console.WriteLine($"{f}\u00B0F = {ftoc}\u00B0C");
            Console.ReadLine();


            //Exercise 6:
            Console.WriteLine("Find the Size of data types:");
            Console.WriteLine($"int: {sizeof(int)}");
            Console.WriteLine($"long: {sizeof(long)}");
            Console.WriteLine($"double: {sizeof(double)}");
            Console.WriteLine($"float: {sizeof(float)}");
            Console.WriteLine($"bool: {sizeof(bool)}");
            Console.ReadLine();


            //Exercise 7:
            Console.Write("Enter character: ");
            char kytu = char.Parse(Console.ReadLine());
            int ascii = (int)kytu;
            Console.WriteLine($"{kytu} = {ascii}");
            Console.ReadLine();


            //Exercise 8:
            Console.Write("Enter radius: ");
            double r = double.Parse(Console.ReadLine());
            double S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Area of Circle: {S}");
            Console.ReadLine();


            //Exercise 9:
            Console.Write("Enter the edge: ");
            double edge = double.Parse(Console.ReadLine());
            double area = edge * edge;
            Console.WriteLine($"Area of Square: {area}");
            Console.ReadLine();


            //Exercise 10:
            Console.Write("Days: ");
            int ngay = int.Parse(Console.ReadLine());
            int Daytoyear = ngay / 365;
            Console.WriteLine($"{Daytoyear} years");
            int numberofremainingdays = ngay % 365;
            int Daytoweek = numberofremainingdays / 7;
            Console.WriteLine($"Days to weeks: {Daytoweek} weeks");
            int odddays = ngay % 7;
            Console.WriteLine($"Days to days: {odddays} days");
            Console.ReadLine();
        }
    }
}
