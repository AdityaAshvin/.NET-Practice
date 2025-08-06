using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

class II_Q7
{
    public static void Reverse()
    {

        Console.WriteLine("Part 2 - Question 7 - Reverse a word");

        Console.WriteLine("enter a string");
        string input = Console.ReadLine()!;

        char[] charArr = input.ToCharArray();

        int start = 0;
        int end = charArr.Length - 1;

        while (start <= end)
        {
            char temp = charArr[start];
            charArr[start] = charArr[end];
            charArr[end] = temp;
            start += 1;
            end -= 1;
        }

        String reverse = new string(charArr);

        Console.WriteLine($"approach 1 - reverse string is:  {reverse}");

        Console.Write($"approach 2 - reverse string is: ");

        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
    }
}