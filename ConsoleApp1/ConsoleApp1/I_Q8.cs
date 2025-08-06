using System.Runtime.InteropServices;

class I_Q8
{
    public static void Counting()
    {
        Console.WriteLine("Part 1 - Question 8 - Counting till 24");

        for (int i = 1; i <= 4; i += 1)
        {
            for (int k = 0; k <= 24; k += i)
            {
                Console.Write(k + ",");
            }
            Console.WriteLine("");
        }
    }
}