using System.Runtime.InteropServices;

class II_Q1
{
    public static void Copying()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int arr_len = arr.Length;
        int[] copy = new int[arr_len];

        for (int i = 0; i < arr_len; i++)
        {
            copy[i] = arr[i];
        }

        Console.WriteLine($"original arr: {String.Join(", ", arr)}");
        Console.WriteLine($"Copied arr: {String.Join(", ", copy)}");

    }
}