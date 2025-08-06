using System.Runtime.InteropServices;

class II_Q9
{
    public static void Palindrome()
    {
        Console.WriteLine("Part 2 - Question 9 - Palindrome in Sentences");

        Console.WriteLine("enter a sentence");
        String input = Console.ReadLine()!;

        String sep = ".,:;=()&[]\"'\\/!? ";

        List<string> words = new List<string>();

        string current = "";
        bool isWord = true;

        foreach (char c in input)
        {
            if (sep.Contains(c))
            {
                if (current != "" && isWord)
                {
                    words.Add(current);
                    current = "";
                }
                isWord = false;
            }
            else
            {
                if (current != "" && !isWord)
                {
                    current = "";
                }
                current += c;
                isWord = true;
            }
        }

        if (current != "")
        {
            words.Add(current);
        }

        // Collect unique palindromes (case-insensitive)
        HashSet<string> palindromes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (string word in words)
        {
            if (PalindromeCheck(word))
            {
                palindromes.Add(word);
            }
        }
        
        var sortedPalindromes = palindromes.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);

        Console.WriteLine(string.Join(", ", sortedPalindromes));
    }
    
    static bool PalindromeCheck(string word)
    {
        string lower = word.ToLower();
        int len = lower.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (lower[i] != lower[len - 1 - i])
                return false;
        }
        return true;
    }
}