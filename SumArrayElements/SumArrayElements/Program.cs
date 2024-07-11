using System;

namespace SumArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sum of Array Elements";

            
            int[] a = { 1, 2, 3, 4 };

            
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            
            Console.WriteLine($"Tổng của các phần tử trong mảng là: {sum}");

            Console.ReadKey();
        }
    }
}
