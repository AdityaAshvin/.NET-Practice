using System.Runtime.InteropServices;

class I_Q8
{
    public static void Counting()
    {
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