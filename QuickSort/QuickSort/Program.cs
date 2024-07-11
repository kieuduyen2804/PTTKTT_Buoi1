using System;

class Program
{
    // Hàm hoán đổi hai phần tử trong mảng
    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    // Hàm phân đoạn và sắp xếp Quick Sort
    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high]; // Chọn phần tử cuối cùng làm pivot
        int i = low - 1; // Chỉ số của phần tử nhỏ hơn pivot

        for (int j = low; j < high; j++)
        {
            // Nếu phần tử hiện tại nhỏ hơn hoặc bằng pivot
            if (arr[j] <= pivot)
            {
                i++; // Tăng chỉ số của phần tử nhỏ hơn pivot
                Swap(arr, i, j); // Hoán đổi arr[i] và arr[j]
            }
        }

        Swap(arr, i + 1, high); // Hoán đổi pivot (arr[high]) và phần tử arr[i+1]
        return i + 1; // Trả về chỉ số của pivot đã được sắp xếp
    }

    // Hàm sắp xếp Quick Sort
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            // pi là chỉ số của pivot, arr[pi] đã được đặt vào đúng vị trí
            int pi = Partition(arr, low, high);

            // Đệ quy sắp xếp các phần tử trước và sau pivot
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
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
        int[] arr = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Mảng ban đầu:");
        PrintArray(arr);

        QuickSort(arr, 0, arr.Length - 1);
        Console.WriteLine("Mảng sau khi sắp xếp:");
        PrintArray(arr);
    }
}
