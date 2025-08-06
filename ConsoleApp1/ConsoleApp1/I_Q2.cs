using System.Runtime.InteropServices;

class I_Q2
{
    public static void convert()
    {
        Console.WriteLine("Part 1 - Question 2 - Day conversion");

        Console.WriteLine("enter an integer value");
        int centuries = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"you entered this {centuries}");

        int years = centuries * 100;
        int days = (int)(years * 365.24);

        long hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;

        ulong ms = (ulong)(seconds * 1000);
        ulong mis = ms * 1000;
        ulong ns = mis * 1000;

        Console.WriteLine($" {centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {ms} milliseconds = {mis} microseconds = {ns} nanoseconds ");
    }
}