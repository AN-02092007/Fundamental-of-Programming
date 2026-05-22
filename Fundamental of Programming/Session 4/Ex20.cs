using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming.Session_4
{
    internal class Ex20
    {
        static void Main()
        {
            Console.WriteLine("Bai 20: " + DemSoTu("Học lập trình C# rất thú vị"));
        }
        public static int DemSoTu(string sentence)
        {
            string[] words = sentence.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
