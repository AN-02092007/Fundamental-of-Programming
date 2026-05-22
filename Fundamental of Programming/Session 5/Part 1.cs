using System;
using System.Collections.Generic;

namespace Fundamental_of_Programming.Session_5
{
    internal class Part_1
    {
        // 0. Hàm tạo mảng ngẫu nhiên
        static int[] CreateRandomArray(int length, int min, int max)
        {
            Random rnd = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(min, max + 1);
            }
            return array;
        }

        // 1. Calculate Average
        static double avg(int[] arr)
        {
            double sum = 0;
            foreach (int num in arr)
                sum += num;
            return sum / arr.Length;
        }

        // 2. Test if array contains a specific value
        static bool ContainsValue(int[] arr, int x)
        {
            foreach (int num in arr)
            {
                if (num == x) return true;
            }
            return false;
        }

        // 3. Find index of an array element
        static int FindIndex(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value) return i;
            }
            return -1;
        }

        // 4. Remove a specific element (Xóa phần tử đầu tiên tìm thấy)
        static int[] RemoveElement(int[] arr, int valueToRemove)
        {
            int index = FindIndex(arr, valueToRemove);
            if (index == -1) return arr;

            int[] newArr = new int[arr.Length - 1];
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != index)
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }
            return newArr;
        }

        // 5. Find Max and Min
        static void FindMaxMin(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];

            foreach (int num in arr)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }
            Console.WriteLine($"Gia tri Lon Nhat: {max} | Nho Nhat: {min}");
        }

        // 6. To reverse an array of integer values
        public static void Bai06(int[] arr)
        {
            int[] reversedArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversedArr[i] = arr[arr.Length - 1 - i];
            }
            Console.WriteLine("6. Mang sau khi dao nguoc thuc su: " + string.Join(", ", reversedArr));
        }

        // 7. To find duplicate values in an array of values
        public static void Bai07(int[] arr)
        {
            Console.Write("7. Cac gia tri bi trung lap: ");
            List<int> daDuyetQua = new List<int>();
            List<int> danhSachTrung = new List<int>();
            bool coTrungLap = false;

            foreach (int so in arr)
            {
                if (daDuyetQua.Contains(so) && !danhSachTrung.Contains(so))
                {
                    Console.Write(so + " ");
                    danhSachTrung.Add(so);
                    coTrungLap = true;
                }
                daDuyetQua.Add(so);
            }

            if (!coTrungLap)
            {
                Console.Write("Khong co phan tu nao bi trung lap.");
            }
            Console.WriteLine();
        }

        // 8. To remove duplicate elements from an array
        public static void Bai08(int[] arr)
        {
            Console.Write("8. Mang sau khi da xoa cac phan tu trung: ");
            List<int> mangDuyNhat = new List<int>();

            foreach (int so in arr)
            {
                if (!mangDuyNhat.Contains(so))
                {
                    mangDuyNhat.Add(so);
                }
            }

            foreach (int so in mangDuyNhat)
            {
                Console.Write(so + " ");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            int[] myArr = CreateRandomArray(10, 1, 20);

            Console.WriteLine("Mang ngau nhien ban dau la: " + string.Join(", ", myArr));

            Console.WriteLine($"1. Trung binh cua mang: {avg(myArr):F2}");

            Console.WriteLine($"2. Mang co chua so 10 khong? {ContainsValue(myArr, 10)}");

            int soCanTimViTri = myArr[0];
            Console.WriteLine($"3. Vi tri (index) dau xuan cua so {soCanTimViTri} la: {FindIndex(myArr, soCanTimViTri)}");

            int[] mangSauXoa = RemoveElement(myArr, myArr[0]);
            Console.WriteLine($"4. Mang sau khi xoa bot phan tu {myArr[0]}: " + string.Join(", ", mangSauXoa));

            Console.Write("5. ");
            FindMaxMin(myArr);

            Bai06(myArr);

            Bai07(myArr);

            Bai08(myArr);

            Console.ReadLine();
        }
    }
}