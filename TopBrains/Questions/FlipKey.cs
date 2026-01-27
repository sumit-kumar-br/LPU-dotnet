using System;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        string result = CleanseAndInvert("abcdef");

        if (result.Length == 0)
        {
            Console.WriteLine("invalid");
        }
        else
        {
            Console.WriteLine("Generated String is: " + result);
        }
    }

    public static string CleanseAndInvert(string input)
    {
        // Rule 1: input must not be null and must be at least 6 characters
        if (string.IsNullOrEmpty(input) || input.Length < 6)
            return "";

        // Rule 2: input must contain only alphabetic characters
        foreach (char c in input)
        {
            if (!char.IsLetter(c))
                return "";
        }

        // Convert to lowercase
        input = input.ToLower();

        // Remove characters with even ASCII values
        StringBuilder filtered = new StringBuilder();
        foreach (char c in input)
        {
            if ((int)c % 2 != 0)
            {
                filtered.Append(c);
            }
        }

        // Reverse the filtered string
        char[] reversed = filtered.ToString().ToCharArray();
        Array.Reverse(reversed);

        // Convert even index characters to uppercase
        for (int i = 0; i < reversed.Length; i++)
        {
            if (i % 2 == 0)
            {
                reversed[i] = char.ToUpper(reversed[i]);
            }
        }

        return new string(reversed);
    }
}
