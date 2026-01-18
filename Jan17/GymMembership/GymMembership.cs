using System;
using System.Collections.Generic;

class FitnessCenter
{
    Dictionary<int, double[]> members = new Dictionary<int, double[]>();

    public void AddMember(int id, double height, double weight)
    {
        members[id] = new double[] { height, weight };
    }

    public double CalculateBMI(int id)
    {
        if (!members.ContainsKey(id))
            throw new Exception("MemberId is not present");

        double h = members[id][0];
        double w = members[id][1];
        return w / (h * h);
    }

    public int CalculateFee(string goal)
    {
        if (goal == "Weight Loss") return 2500;
        if (goal == "Weight Gain") return 3000;
        return 2000;
    }
      static void Main()
    {
        FitnessCenter center = new FitnessCenter();

        Console.WriteLine("Enter MemberId:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Height:");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Weight:");
        double weight = double.Parse(Console.ReadLine());

        center.AddMember(id, height, weight);

        Console.WriteLine("Enter goal:");
        string goal = Console.ReadLine();

        try
        {
            Console.WriteLine("BMI: " + center.CalculateBMI(id));
            Console.WriteLine("Fee: " + center.CalculateFee(goal));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
