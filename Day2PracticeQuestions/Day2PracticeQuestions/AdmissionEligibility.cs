using System;

namespace Day2PracticeQuestions;

public class AdmissionEligibility
{
    public static void IsEligible(int math, int che, int phy)
    {   
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
