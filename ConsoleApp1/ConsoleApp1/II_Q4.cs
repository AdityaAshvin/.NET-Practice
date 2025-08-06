using System.Runtime.InteropServices;

class II_Q4
{
    public static void Rotation()
    {
        Console.WriteLine("Part 2 - Question 4 - Sum in rotation");

        Console.WriteLine("enter space separated values");
        int[] items = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        Console.WriteLine("enter a integer k");
        int k = Convert.ToInt32(Console.ReadLine());

        int[] sum_arr = new int[items.Length];

        // Step 4: Perform k rotations
        for (int r = 1; r <= k; r++)
        {
            for (int i = 0; i < sum_arr.Length; i++)
            {
                int newIndex = (i + r) % sum_arr.Length; // position after r rotations
                sum_arr[newIndex] += items[i];
            }
        }

        Console.WriteLine($"the sum array is {String.Join(",", sum_arr)}");
    }
}