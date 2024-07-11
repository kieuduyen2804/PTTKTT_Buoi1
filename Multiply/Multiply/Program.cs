using System;

class Program
{
    // Hàm nhân hai số nguyên lớn
    static string Multiply(string num1, string num2)
    {
        // Xử lý các trường hợp đặc biệt
        if (num1.Equals("0") || num2.Equals("0"))
            return "0";

        int m = num1.Length;
        int n = num2.Length;
        int[] result = new int[m + n];

        // Chuyển các ký tự số về dạng số và đảo ngược các chuỗi
        char[] arr1 = num1.ToCharArray();
        Array.Reverse(arr1);
        char[] arr2 = num2.ToCharArray();
        Array.Reverse(arr2);

        // Thực hiện phép nhân từ phải sang trái
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i + j] += (arr1[i] - '0') * (arr2[j] - '0');
                result[i + j + 1] += result[i + j] / 10;
                result[i + j] %= 10;
            }
        }

        // Bỏ các số 0 thừa ở đầu kết quả
        int k = result.Length - 1;
        while (k >= 0 && result[k] == 0)
            k--;

        // Nếu không có kết quả, trả về "0"
        if (k == -1)
            return "0";

        // Xây dựng chuỗi kết quả từ các số trong mảng result
        string multiplyResult = "";
        for (; k >= 0; k--)
            multiplyResult += result[k];

        return multiplyResult;
    }

    // Hàm Main để thử nghiệm
    public static void Main(string[] args)
    {
        string num1 = "123456789";
        string num2 = "987654321";

        Console.WriteLine("Số nguyên lớn 1: " + num1);
        Console.WriteLine("Số nguyên lớn 2: " + num2);

        string result = Multiply(num1, num2);
        Console.WriteLine("Kết quả nhân hai số nguyên lớn:");
        Console.WriteLine(result);
    }
}
