//Fizzbuzz

class I_Q3
{
    public static void Fizzbuzz()
    {
        Console.WriteLine("Part 1 - Question 3 - Fizzbuzz");

        for (int i = 0; i < 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void Codechecker()
    {
        int max = 500;
        Console.WriteLine("ensure max value does not exceed the byte max value");
        for (byte i = 0; i < max; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void Guesser()
    {
        bool flag = true;
        while (flag)
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Guess a number");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());
            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Your answer is outside the range");
            }
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine("Your guess is lower than the correct number");
            }
            else if (guessedNumber > correctNumber)
            {
                Console.WriteLine("Your guess is higher than the correct number");
            }
            else
            {
                Console.WriteLine("Your guess is correct");
                flag = false;
            }  
        }
    }
}