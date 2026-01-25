// File: SmartHomeEnergyMonitor.cs
using System;
using System.Collections.Generic;

class SmartHomeEnergyMonitor
{
    static void Main()
    {
        Console.WriteLine("=== SMART HOME ENERGY MONITOR ===\n");
        
        // Sample data: LightsHours, ACHours, TVHours
        List<(double, double, double)> dailyUsage = new List<(double, double, double)>
        {
            (5.0, 8.0, 4.0),    // Moderate usage
            (12.0, 2.0, 6.0),   // High lights, low AC
            (3.0, 12.0, 8.0),   // High AC, high TV
            (8.0, 4.0, 2.0),    // Balanced usage
            (2.0, 24.0, 1.0),   // Extreme AC usage
            (10.0, 6.0, 10.0)   // High usage all
        };
        
        foreach (var usage in dailyUsage)
        {
            AnalyzeEnergyUsage(usage.Item1, usage.Item2, usage.Item3);
            Console.WriteLine("------------------------");
        }
    }
    
    static void AnalyzeEnergyUsage(double lightsHours, double acHours, double tvHours)
    {
        const double electricityRate = 0.15; // $ per kWh
        
        // Calculate energy consumption
        double lightsEnergy = lightsHours * 0.1;     // 0.1 kWh/hour
        double acEnergy = acHours * 1.5;           // 1.5 kWh/hour
        double tvEnergy = tvHours * 0.3;           // 0.3 kWh/hour
        
        // Calculate costs
        double lightsCost = lightsEnergy * electricityRate;
        double acCost = acEnergy * electricityRate;
        double tvCost = tvEnergy * electricityRate;
        
        double totalEnergy = lightsEnergy + acEnergy + tvEnergy;
        double totalCost = lightsCost + acCost + tvCost;
        
        // Display usage summary
        Console.WriteLine("Daily Usage Summary:");
        Console.WriteLine($"  • Lights: {lightsHours} hours ({lightsEnergy:F2} kWh)");
        Console.WriteLine($"  • AC: {acHours} hours ({acEnergy:F2} kWh)");
        Console.WriteLine($"  • TV: {tvHours} hours ({tvEnergy:F2} kWh)");
        Console.WriteLine($"  • Total Energy: {totalEnergy:F2} kWh");
        Console.WriteLine($"  • Total Cost: ${totalCost:F2}");
        
        // Check for usage alerts
        List<string> alerts = new List<string>();
        
        if (lightsHours > 8) alerts.Add("Lights usage exceeds recommended 8 hours");
        if (acHours > 10) alerts.Add("AC usage exceeds recommended 10 hours");
        if (tvHours > 6) alerts.Add("TV usage exceeds recommended 6 hours");
        
        // Display alerts
        if (alerts.Count > 0)
        {
            Console.WriteLine("\n⚠ USAGE ALERTS:");
            foreach (string alert in alerts)
            {
                Console.WriteLine($"  • {alert}");
            }
        }
        
        // Provide savings suggestions
        if (totalCost > 5.00)
        {
            Console.WriteLine("\n💡 SAVINGS SUGGESTIONS:");
            ProvideSavingsSuggestions(lightsHours, acHours, tvHours, totalCost);
        }
        
        // Calculate potential savings
        CalculatePotentialSavings(lightsHours, acHours, tvHours);
    }
    
    static void ProvideSavingsSuggestions(double lightsHours, double acHours, double tvHours, double totalCost)
    {
        Console.WriteLine("Your daily energy cost is high. Consider:");
        
        if (lightsHours > 6)
        {
            Console.WriteLine($"  • Reduce lights usage by 2 hours: Save ${CalculateSaving(0.1, 2, 0.15):F2} daily");
        }
        
        if (acHours > 8)
        {
            Console.WriteLine($"  • Increase AC temperature by 2°C: Save ${CalculateSaving(0.3, acHours, 0.15):F2} daily");
        }
        
        if (tv