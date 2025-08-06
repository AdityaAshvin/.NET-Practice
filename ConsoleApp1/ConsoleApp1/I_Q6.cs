using System.Runtime.InteropServices;

class I_Q6
{
    public static void Days()
    {

        Console.WriteLine("Part 1 - Question 6 - Age in days");

        DateTime birthdate = new DateTime(2001, 02, 16);
        DateTime today = DateTime.Now;

        TimeSpan age = today - birthdate;
        Console.WriteLine($"Your age in days is {age.Days}");

        int daysToNextAnniversary = 10000 - (age.Days % 10000);
        Console.WriteLine($"you will celebrate your 10000 day anniversary on {today.AddDays(daysToNextAnniversary)}");
    }
}