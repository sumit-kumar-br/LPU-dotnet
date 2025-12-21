using System;

namespace Day2PracticeQuestions;

public class HeightCategory
{
    public static void HeightMain()
    {
        System.Console.WriteLine("Enter height");
        int height=Int32.Parse(Console.ReadLine());
        if(height<150)
        {
            System.Console.WriteLine("Dwarf");
        } 
        else if(height < 165)
        {
            System.Console.WriteLine("Average");
        }
        else if(height<190)
        {
            System.Console.WriteLine("Tall");
        }
        else
        {
            System.Console.WriteLine("Abnormal");
        }
    }
}
