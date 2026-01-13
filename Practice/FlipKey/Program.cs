// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Text;
public class Program
{
    public string CleanseAndInvert(string input)
    {
        if(string.IsNullOrEmpty(input) || input.Length < 6)
        {
            return "";
        }
        foreach(var ch in input)
        {
            if (!char.IsLetter(ch))
            {
                return "";
            }
        }
        string output = "";
        input = input.ToLower();
        foreach(char ch in input)
        {
            if ((int)ch % 2 != 0)
            {
                output+=ch;
            }
        }
        StringBuilder filtered = new StringBuilder(output);
        char[] reversed = filtered.ToString().ToCharArray();
        Array.Reverse(reversed);

        for(int i=0; i<reversed.Length; i++)
        {
            if (i % 2 == 0)
            {
                reversed[i] = char.ToUpper(reversed[i]);
            }
        }
        return new string(reversed);        
    }
    public static void Main(string[] args)
    {
        Program pObj = new Program();
        System.Console.WriteLine("Enter the word");
        string word = Console.ReadLine();

        string key = pObj.CleanseAndInvert(word);
        System.Console.WriteLine(key);

    }
}