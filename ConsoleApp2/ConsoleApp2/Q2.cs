using System;
using System.Formats.Asn1;

class Q2
{
    public static void Fibonnaci(int n)
    {
        if (n < 1)
        {
            Console.WriteLine("enter a number greater than or equal to 1");
        }
        else if (n == 1)
        {
            Console.WriteLine(1);
            return;
        }
        else if (n == 2)
        {
            Console.WriteLine("1, 1");
            return;
        }
        else
        {
            int[] arr = new int[n];
            arr[0] = 1;
            arr[1] = 1;
            FibonnaciRec(arr, n, 2);

            PrintArr(arr);
        }
    }

    static void FibonnaciRec(int[] arr, int n, int ind)
    {
        if (ind >= n)
        {
            return;
        }
        arr[ind] = arr[ind - 1] + arr[ind - 2];
        FibonnaciRec(arr, n, ind + 1);
    }

    static void PrintArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + ",");
        }
    }
}