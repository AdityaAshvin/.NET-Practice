using System.Runtime.InteropServices;

class I_Q7
{
    public static void Switch()
    {
        DateTime time = DateTime.Now;
        Console.WriteLine(time.Hour);

        if (time.Hour < 12)
        {
            Console.WriteLine("Good Morning");
        }
        else if (time.Hour >= 12 && time.Hour < 16)
        {
            Console.WriteLine("Good Afternoon");
        }
        else if (time.Hour >= 16 && time.Hour < 20)
        {
            Console.WriteLine("Good Evening");
        }
        else
        {
            Console.WriteLine("Good Night");
        }
    }
}