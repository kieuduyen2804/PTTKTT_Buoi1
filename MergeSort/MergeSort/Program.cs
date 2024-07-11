using System;

class Program
{
    // Hàm merge để trộn 2 mảng đã sắp xếp
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        // Tạo mảng tạm để lưu các phần tử
        int[] L = new int[n1];
        int[] R = new int[n2];

        // Sao chép dữ liệu vào mảng tạm L[] và R[]
        for (int i = 0; i < n1; ++i)
            L[i] = arr[left + i];
        for (int j = 0; j < n2; ++j)
            R[j] = arr[mid + 1 + j];

        // Merge các mảng tạm lại
        int k = left;
        int p = 0, q = 0;
        while (p < n1 && q < n2)
        {
            if (L[p] <= R[q])
            {
                arr[k] = L[p];
                p++;
            }
            else
            {
                arr[k] = R[q];
                q++;
            }
            k++;
        }

        // Sao chép các phần tử còn lại của L[] nếu có
        while (p < n1)
        {
            arr[k] = L[p];
            p++;
            k++;
        }

        // Sao chép các phần tử còn lại của R[] nếu có
        while (q < n2)
        {
            arr[k] = R[q];
            q++;
            k++;
        }
    }

    // Hàm sắp xếp Merge Sort
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            // Tìm điểm chia để chia mảng thành 2 nửa
            int mid = left + (right - left) / 2;

            // Đệ quy sắp xếp từng nửa
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            // Trộn các mảng đã sắp xếp lại
            Merge(arr, left, mid, right);
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

        MergeSort(arr, 0, arr.Length - 1);
        Console.WriteLine("Mảng sau khi sắp xếp:");
        PrintArray(arr);
    }
}
