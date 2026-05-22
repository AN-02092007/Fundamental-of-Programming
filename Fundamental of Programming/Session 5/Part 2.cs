using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamental_of_Programming
{
    internal class Part_2
    {
        //Requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
        public static void Bai1_BubbleSort()
        {
            int[] numbers = new int[10];
            Console.WriteLine("Vui long nhap 10 so nguyen:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhập số thứ {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.Write("Lỗi! Vui lòng chỉ nhập số nguyên. Nhập lại: ");
                }
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n=> Mảng sau khi sắp xếp tăng dần (Bubble Sort):");
            Console.WriteLine(string.Join(", ", numbers));
        }

        //2. Request a sentence from the user, then ask to enter a word. Search if the word appears in the phrase using the linear search algorithm.
        public static void Bai2_LinearSearch()
        {
            Console.Write("Vui lòng nhập một câu bất kỳ: ");
            string sentence = Console.ReadLine();

            Console.Write("Vui lòng nhập 1 từ cần tìm trong câu trên: ");
            string wordToFind = Console.ReadLine();

            string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            bool isFound = false;

            for (int i = 0; i < words.Length; i++)
            {
                if (string.Equals(words[i], wordToFind, StringComparison.OrdinalIgnoreCase))
                {
                    isFound = true;
                    Console.WriteLine($"=> Đã tìm thấy từ '{wordToFind}' xuất hiện tại vị trí từ thứ {i + 1} trong câu.");
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"=> Không tìm thấy từ '{wordToFind}' trong câu trên.");
            }
        }

        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Bai1_BubbleSort();

            Bai2_LinearSearch();

            Console.ReadLine();
        }
    }
}
