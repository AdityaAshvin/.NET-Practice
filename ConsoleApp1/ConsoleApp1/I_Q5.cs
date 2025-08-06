//Guesser

class I_Q5
{

    public static void Guesser()
    {
        Console.WriteLine("Part 1 - Question 5 - Number guesser");

        bool flag = true;
        int correctNumber = new Random().Next(3) + 1;

        while (flag)
        {
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