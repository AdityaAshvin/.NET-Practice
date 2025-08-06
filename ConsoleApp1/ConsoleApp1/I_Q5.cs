//Guesser

class I_Q5
{

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