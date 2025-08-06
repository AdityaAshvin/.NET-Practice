//Pattern printing

class I_Q4
{
    public static void pattern()
    {
        Console.WriteLine("Part 1 - Question 4 - Pattern printing");

        for (int i = 0; i < 5; i++)
        {
            for (int j = 5 - i; j > 0; j--)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < 2 * i + 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}