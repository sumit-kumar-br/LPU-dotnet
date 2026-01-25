
// File: CarbonFootprintCalculator.cs
using System;
using System.Collections.Generic;

class CarbonFootprintCalculator
{
    static void Main()
    {
        Console.WriteLine("=== CARBON FOOTPRINT CALCULATOR ===\n");
        
        // Sample data: TransportMode, Distance, ElectricityUsage, DietType
        List<(char, double, double, char)> dailyActivities = new List<(char, double, double, char)>
        {
            ('C', 20.0, 10.0, 'N'),   // Car, 20km, 10kWh, Non-vegetarian
            ('B', 5.0, 8.0, 'V'),     // Bus, 5km, 8kWh, Vegetarian
            ('T', 50.0, 12.0, 'N'),   // Train, 50km, 12kWh, Non-vegetarian
            ('W', 3.0, 15.0, 'V'),    // Walk, 3km, 15kWh, Vegetarian
            ('C', 10.0, 5.0, 'N'),    // Car, 10km, 5kWh, Non-vegetarian
            ('B', 30.0, 20.0, 'V')    // Bus, 30km, 20kWh, Vegetarian
        };
        
        foreach (var activity in dailyActivities)
        {
            CalculateCarbonFootprint(
                activity.Item1,  // transport mode
                activity.Item2,  // distance
                activity.Item3,  // electricity usage
                activity.Item4   // diet type
            );
            Console.WriteLine("------------------------");
        }
    }
    
    static void CalculateCarbonFootprint(char transportMode, double distance, 
                                         double electricityUsage, char dietType)
    {
        // Calculate transport emissions
        double transportEmission = CalculateTransportEmission(transportMode, distance);
        
        // Calculate electricity emissions (2 kg per day)
        double electricityEmission = electricityUsage * 2.0;
        
        // Calculate diet emissions
        double dietEmission = GetDietEmission(dietType);
        
        // Calculate total emissions
        double totalEmission = transportEmission + electricityEmission + dietEmission;
        
        // Get environmental rating
        string rating = GetEnvironmentalRating(totalEmission);
        
        // Display results
        Console.WriteLine($"Transport Mode: {GetTransportName(transportMode)}");
        Console.WriteLine($"Daily Distance: {distance} km");
        Console.WriteLine($"Electricity Usage: {electricityUsage} kWh");
        Console.WriteLine($"Diet Type: {GetDietName(dietType)}");
        
        Console.WriteLine("\nEmissions Breakdown:");
        Console.WriteLine($"  • Transport: {transportEmission:F2} kg CO₂");
        Console.WriteLine($"  • Electricity: {electricityEmission:F2} kg CO₂");
        Console.WriteLine($"  • Diet: {dietEmission:F2} kg CO₂");
        
        Console.WriteLine($"\nTOTAL DAILY FOOTPRINT: {totalEmission:F2} kg CO₂");
        Console.WriteLine($"ENVIRONMENTAL RATING: {rating}");
        
        // Provide recommendations
        ProvideRecommendations(transportMode, distance, electricityUsage, dietType, totalEmission);
    }
    
    static double CalculateTransportEmission(char transportMode, double distance)
    {
        double emissionFactor = transportMode switch
        {
            'C' => 0.20,  // Car
            'B' => 0.05,  // Bus
            'T' => 0.03,  // Train
            'W' => 0.00,  // Walk/Bicycle
            _ => 0.00
        };
        
        return distance * emissionFactor;
    }
    
    static double GetDietEmission(char dietType)
    {
        return dietType switch
        {
            'N' => 1.50,  // Non-vegetarian
            'V' => 0.80,  // Vegetarian
            _ => 0.00
        };
    }
    
    static string GetEnvironmentalRating(double totalEmission)
    {
        return totalEmission switch
        {
            < 5 => "Low",
            < 15 => "Medium",
            _ => "High"
        };
    }
    
    static string GetTransportName(char transportMode)
    {
        return transportMode switch
        {
            'C' => "Car",
            'B' => "Bus",
            'T' => "Train",
            'W' => "Walk/Bicycle",
            _ => "Unknown"
        };
    }
    
    static string GetDietName(char dietType)
    {
        return dietType switch
        {
            'N' => "Non-vegetarian",
            'V' => "Vegetarian",
            _ => "Unknown"
        };
    }
    
    static void ProvideRecommendations(char transportMode, double distance, 
                                       double electricityUsage, char dietType, 
                                       double totalEmission)
    {
        Console.WriteLine("\nRecommendations:");
        
        if (transportMode == 'C' && distance > 10)
        {
            Console.WriteLine("  • Consider using public transport for longer distances");
        }
        
        if (electricityUsage > 15)
        {
            Console.WriteLine("  • Reduce electricity usage - turn off unused appliances");
        }
        
        if (dietType == 'N')
        {
            Console.WriteLine("  • Consider incorporating more vegetarian meals");
        }
        
        if (totalEmission >= 15)
        {
            Console.WriteLine("  • Your carbon footprint is high. Consider all recommendations above");
        }
    }
}