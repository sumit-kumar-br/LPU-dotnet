// File: DeliveryTimeEstimator.cs
using System;
using System.Collections.Generic;

class DeliveryTimeEstimator
{
    static void Main()
    {
        Console.WriteLine("=== FOOD DELIVERY TIME ESTIMATOR ===\n");
        
        // Sample data: Distance, Weather, CurrentHour, PrepTime
        List<(double, char, int, int)> deliveries = new List<(double, char, int, int)>
        {
            (3.0, 'C', 14, 15),    // Close, Clear, Afternoon
            (8.0, 'R', 18, 20),    // Medium, Rain, Rush hour
            (12.0, 'S', 12, 25),   // Far, Snow, Noon
            (5.0, 'C', 19, 10),    // Normal, Clear, Rush hour
            (2.0, 'R', 16, 5),     // Very close, Rain, Afternoon
            (15.0, 'C', 20, 30)    // Very far, Clear, Evening
        };
        
        foreach (var delivery in deliveries)
        {
            EstimateDeliveryTime(
                delivery.Item1,    // distance
                delivery.Item2,    // weather
                delivery.Item3,    // hour
                delivery.Item4     // prep time
            );
            Console.WriteLine("------------------------");
        }
    }
    
    static void EstimateDeliveryTime(double distance, char weather, int currentHour, int prepTime)
    {
        int baseTime = 30; // Base delivery time in minutes
        int additionalTime = 0;
        
        // Distance factor
        if (distance > 5)
        {
            additionalTime += (int)((distance - 5) * 2);
        }
        
        // Weather factor
        additionalTime += GetWeatherDelay(weather);
        
        // Rush hour factor
        if (IsRushHour(currentHour))
        {
            additionalTime += 15;
        }
        
        int totalDeliveryTime = baseTime + additionalTime;
        int totalTime = totalDeliveryTime + prepTime;
        
        Console.WriteLine($"Distance: {distance} km");
        Console.WriteLine($"Weather: {GetWeatherDescription(weather)}");
        Console.WriteLine($"Current Time: {currentHour}:00");
        Console.WriteLine($"Preparation Time: {prepTime} minutes");
        Console.WriteLine($"Delivery Time: {totalDeliveryTime} minutes");
        Console.WriteLine($"Total Estimated Time: {totalTime} minutes");
        
        DisplayTimeBreakdown(baseTime, additionalTime, prepTime);
    }
    
    static int GetWeatherDelay(char weather)
    {
        return weather switch
        {
            'R' => 10, // Rain
            'S' => 20, // Snow
            'C' => 0,  // Clear
            _ => 0
        };
    }
    
    static bool IsRushHour(int hour)
    {
        return hour >= 17 && hour <= 20; // 5 PM to 8 PM
    }
    
    static string GetWeatherDescription(char weather)
    {
        return weather switch
        {
            'R' => "Rainy",
            'S' => "Snowy",
            'C' => "Clear",
            _ => "Unknown"
        };
    }
    
    static void DisplayTimeBreakdown(int baseTime, int additionalTime, int prepTime)
    {
        Console.WriteLine($"\nTime Breakdown:");
        Console.WriteLine($"  • Base time: {baseTime} min");
        
        if (additionalTime > 0)
        {
            Console.WriteLine($"  • Additional factors: {additionalTime} min");
        }
        
        Console.WriteLine($"  • Preparation: {prepTime} min");
    }
}