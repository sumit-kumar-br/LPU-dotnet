using System;
using System.Collections.Generic;
using System.Text;

public class SolutionDefault
{
    public static void Main()
    {
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();

        HashSet<char> secondWordChars = new HashSet<char>();
        foreach (char c in word2.ToLower())
        {
            secondWordChars.Add(c);
        }

        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        string filtered = "";

        // Task 1: Remove common consonants
        foreach (char c in word1)
        {
            char lower = char.ToLower(c);

            if (vowels.Contains(lower) || !secondWordChars.Contains(lower))
            {
                filtered += c;
            }
        }

        // Task 2: Remove consecutive duplicates
        string result = "";

        for (int i = 0; i < filtered.Length; i++)
        {
            if (i == 0 || filtered[i] != filtered[i - 1])
            {
                result += filtered[i];
            }
        }
        Console.WriteLine(result.ToString());
    }
}
