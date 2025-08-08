using System;

class Q1
{
    public static void Reverse(int len)
    {
        int[] numbers = GenerateNumbers(len);
        ReverseList(numbers);
        PrintNumbers(numbers);
    }

    static int[] GenerateNumbers(int len)
    {
        int[] arr = new int[len];
        for (int i = 0; i < len; i++)
        {
            arr[i] = i;
        }
        return arr;
    }

    static int[] ReverseList(int[] arr)
    {
        int low = 0;
        int high = arr.Length-1;

        while (low <= high)
        {
            int temp = arr[low];
            arr[low] = arr[high];
            arr[high] = temp;
            low += 1;
            high -= 1;
        }

        return arr;
    }

    static void PrintNumbers(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + ",");
        }
    }

}