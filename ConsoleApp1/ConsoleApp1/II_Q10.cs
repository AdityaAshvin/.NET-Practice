using System.Runtime.InteropServices;

class II_Q10
{
    public static void URL()
    {
        Console.WriteLine("Part 2 - Question 10 - URL parsing");

        Console.WriteLine("enter a sentence");
        String input = Console.ReadLine()!;

        int protocolIndex = input.IndexOf(':');

        string protocol = "";
        int serverStartInd = 0;

        if (protocolIndex == -1)
        {
            protocol = "";
            serverStartInd = 0;
        }
        else
        {
            protocol = input.Substring(0, protocolIndex);
            serverStartInd = protocolIndex + 3;
        }

        int resInd = input.IndexOf('/', serverStartInd);
        string server = "";
        string resource = "";

        if (resInd == -1)
        {
            resource = "";
            server = input.Substring(serverStartInd);
        }
        else
        {
            resource = input.Substring(resInd + 1);
            server = input.Substring(serverStartInd, resInd - serverStartInd);
        }

        //Console.WriteLine($" serverStarInd+1 = {serverStartInd+1} resInd = {resInd}");

        Console.WriteLine($"[protocol] = \"{protocol}\"");
        Console.WriteLine($"[server] = \"{server}\"");
        Console.WriteLine($"[resource] = \"{resource}\"");
        
    }
}