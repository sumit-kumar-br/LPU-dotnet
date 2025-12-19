using System;

namespace Day2PracticeQuestions;

public class HeightCategory
{
    public static void HeightMain(int height)
    {
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
