using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class II_Q6
{
    public static void Freq()
    {
        Console.WriteLine("Part 2 - Question 6 - Most freq number");

        Console.WriteLine("enter space separated values");
        int[] items = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

        int global_freq = 0;
        int freq_ele = items[0];

        for (int i = 0; i < items.Length; i += 1)
        {
            int freq = 0;
            for (int j = 0; j < items.Length; j += 1)
            {
                if (items[i] == items[j] && i != j)
                {
                    freq += 1;
                }
            }
            //Console.WriteLine($"the freq of item {items[i]} is {freq} and global freq is {global_freq}");
            if (freq > global_freq)
            {
                freq_ele = items[i];
                global_freq = freq;
                Console.WriteLine($"the freq of item {items[i]} is {freq} and fre_ele is updated {freq_ele}");
            }
        }

        Console.WriteLine($"the most freq ele is {freq_ele}");

    }
}