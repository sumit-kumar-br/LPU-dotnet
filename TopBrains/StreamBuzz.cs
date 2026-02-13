using System;
using System.Collections.Generic;
using System.Linq;

public class CreatorStats
{
    public string CreatorName { get; set; }
    public double[] WeeklyLikes { get; set; }

    public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();
}

public class Program
{
    public void RegisterCreator(CreatorStats record)
    {
        CreatorStats.EngagementBoard.Add(record);
    }

    public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();
        //Implement COde Here
        foreach(var creator in records)
        {
            int count = creator.WeeklyLikes.Count(s => s >= likeThreshold);
            if(count > 0) 
            {
                result.Add(creator.CreatorName, count);
            }
        }
        return result;
    }

    public double CalculateAverageLikes()
    {
       //Implement Code Here
        if(!CreatorStats.EngagementBoard.Any())
            return 0;
        else
            return CreatorStats.EngagementBoard.SelectMany(s=>s.WeeklyLikes).Average();
       
    }

    public static void Main(string[] args)
    {
        Program program = new Program();

        // 🔹 Hard-coded creator data
        CreatorStats c1 = new CreatorStats
        {
            CreatorName = "Nicky",
            WeeklyLikes = new double[] { 1500, 1600, 1800, 2000 }
        };

        CreatorStats c2 = new CreatorStats
        {
            CreatorName = "Roma",
            WeeklyLikes = new double[] { 800, 1000, 1300, 1400 }
        };

        program.RegisterCreator(c1);
        program.RegisterCreator(c2);

        Console.WriteLine("Creators registered successfully\n");

        // 🔹 Show top posts
        double threshold = 1400;
        Console.WriteLine("Top Posts (Threshold: 1400)");

        var topPosts = program.GetTopPostCounts(CreatorStats.EngagementBoard, threshold);

        //Implement COde Here
        foreach(var creator in topPosts)
        {
            Console.WriteLine($"{creator.Key} - {creator.Value}");
        }

        Console.WriteLine();

        // 🔹 Calculate average likes
        Console.WriteLine($"Overall average weekly likes: {program.CalculateAverageLikes()}");
        Console.WriteLine();
        Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
        // Console.WriteLine();

        
    }
}
