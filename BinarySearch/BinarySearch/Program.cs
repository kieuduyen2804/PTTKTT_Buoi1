using System;

class Program
{
    // Hàm tìm kiếm nhị phân
    static int BinarySearch(int[] arr, int x)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Kiểm tra x có nằm ở giữa không
            if (arr[mid] == x)
                return mid;

            // Nếu x lớn hơn phần tử ở giữa, loại bỏ nửa trái
            if (arr[mid] < x)
                left = mid + 1;
            // Nếu x nhỏ hơn phần tử ở giữa, loại bỏ nửa phải
            else
                right = mid - 1;
        }

        // Trả về -1 nếu không tìm thấy
        return -1;
    }

    // Hàm in mảng
    static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    // Hàm Main để thử nghiệm
    public static void Main(string[] args)
    {
        int[] arr = { 2, 3, 4, 10, 40 };
        int x = 10; // Phần tử cần tìm kiếm

        Console.WriteLine("Mảng ban đầu:");
        PrintArray(arr);

        int result = BinarySearch(arr, x);

        if (result == -1)
            Console.WriteLine($"Phần tử {x} không có trong mảng.");
        else
            Console.WriteLine($"Phần tử {x} được tìm thấy tại chỉ số {result} trong mảng.");
    }
}

