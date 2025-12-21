using System;

namespace Day2PracticeQuestions;

public class AdmissionEligibility
{
    public static void IsEligible()
    {
        int math;
        int phy;
        int che;
        System.Console.WriteLine("Enter marks of Maths: ");
        math=Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter marks of Physics: ");
        phy=Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter marks of Chemistry: ");
        che=Int32.Parse(Console.ReadLine());   
        int total = math+phy+che;
        if((math>=65&&phy>=55&&che>=50)&&(total>=180||(math+phy)>=140))
        {
            System.Console.WriteLine("Eligible");
        }
        else
        {
            System.Console.WriteLine("Not Eligible");
        }
    }
}
