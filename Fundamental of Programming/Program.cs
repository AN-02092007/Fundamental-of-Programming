using Fundamental_of_Programming.Section_2;
using System;

namespace Fundamental_of_Programming.Section_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vui long nhap so de chon bai tap (1 - 20): ");
            string luaChon = Console.ReadLine();

            switch (luaChon)
            {
                case "1":
                    Ex01.Run();
                    break;
                case "2":
                    Ex02.Run();
                    break;
                case "3":
                    Ex03.Run();
                    break;
                case "4":
                    Ex04.Run();
                    break;
                case "5":
                    Ex05.Run();
                    break;
                case "6":
                    Ex06.Run();
                    break;
                case "7":
                    Ex07.Run();
                    break;
                case "8":
                    Ex08.Run();
                    break;
                case "9":
                    Ex09.Run();
                    break;
                case "10":
                    Ex10.Run();
                    break;
                case "11":
                    Ex11.Run();
                    break;
                case "12":
                    Ex12.Run();
                    break;
                case "13":
                    Ex13.Run();
                    break;
                case "14":
                    Ex14.Run();
                    break;
                case "15":
                    Ex15.Run();
                    break;
                case "16":
                    Ex16.Run();
                    break;
                case "17":
                    Ex17.Run();
                    break;
                case "18":
                    Ex18.Run();
                    break;
                case "19":
                    Ex19.Run();
                    break;
                case "20":
                    Ex20.Run();
                    break;
                default:
                    Console.WriteLine("Khong co bai nay! Vui long nhap tu 1 den 20.");
                    break;
            }

            Console.ReadLine();
        }
    }
}