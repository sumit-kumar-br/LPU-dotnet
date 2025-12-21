using System;

namespace Day2PracticeQuestions;

public class VowelOrConsonants
{
    public static void IsVowelOrConsonant()
    {
        char ch;
        System.Console.WriteLine("Enter the character: ");
        ch = Char.Parse(Console.ReadLine());
        if (ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u'||ch=='A'||ch=='E'||ch=='I'||ch=='O'||ch=='U')
        {
            System.Console.WriteLine("{0} is vowel",ch);
        }
        else
        {
            System.Console.WriteLine("{0} is consonant",ch);
        }
    }
}
