using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Section_2
{
    internal class Ex07
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the first number: ");
            double firstnumber = double.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            double secondnumber = double.Parse(Console.ReadLine());
            double cong = firstnumber + secondnumber;
            double tru = firstnumber - secondnumber;
            double nhan = firstnumber * secondnumber;
            double chia = firstnumber/secondnumber;
            double mod = firstnumber % secondnumber;
            Console.WriteLine($"{firstnumber} + {secondnumber} = {cong}");
            Console.WriteLine($"{firstnumber} - {secondnumber} = {tru}");
            Console.WriteLine($"{firstnumber} x {secondnumber} = {nhan}");
            Console.WriteLine($"{firstnumber} / {secondnumber} = {chia}");
            Console.WriteLine($"{firstnumber} mod {secondnumber} = {mod}");
            Console.ReadLine();
        }
    }
}
