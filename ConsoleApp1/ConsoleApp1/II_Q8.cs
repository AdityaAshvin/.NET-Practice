using System.Runtime.InteropServices;

class II_Q8
{
    public static void Reverse2()
    {
        Console.WriteLine("Part 2 - Question 8 - Reverse words in sentence");

        Console.WriteLine("enter a sentence to be reversed");
        String input = Console.ReadLine()!;

        String sep = ".,:;=()&[]\"'\\/!? ";
        
        List<string> words = new List<string>();
        List<string> nonwords = new List<string>();

        string current = "";
        bool isWord = true;

        foreach (char c in input)
        {
            if (sep.Contains (c))
            {
                if (current != "" && isWord)
                {
                    words.Add(current);
                    nonwords.Add("word");
                    current = "";
                }
                nonwords.Add(c.ToString());
                isWord = false;
            }
            else
            {
                if ( current != "" && !isWord)
                {
                    nonwords.Add(current);
                    current = "";
                }
                current += c;
                isWord = true;
            }
        }

        if (current != "")
        {
            words.Add(current);
            nonwords.Add("word");
        }

        words.Reverse();
        int wordIndex = 0;

        string ans = "";

        foreach (string part in nonwords)
        {
            if (part == "word")
            {
                ans += words[wordIndex++];
            }
            else
            {
                ans += part;
            }
        }
        Console.WriteLine(ans);
    }
}