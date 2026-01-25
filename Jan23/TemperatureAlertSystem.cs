// File: TemperatureAlertSystem.cs
using System;
using System.Collections.Generic;

class TemperatureAlertSystem
{
    static void Main()
    {
        Console.WriteLine("=== TEMPERATURE ALERT SYSTEM ===\n");
        
        // Sample data: CurrentTemp, PreviousTemp
        List<(double, double)> temperatureReadings = new List<(double, double)>
        {
            (-5.0, 2.0),     // Freezing with rapid change
            (8.0, 7.0),      // Cold
            (20.0, 19.0),    // Comfortable
            (30.0, 20.0),    // Heat with rapid change
            (40.0, 35.0),    // Extreme heat
            (15.0, 5.0)      // Comfortable with rapid change
        };
        
        foreach (var reading in temperatureReadings)
        {
            GenerateTemperatureAlert(reading.Item1, reading.Item2);
            Console.WriteLine("------------------------");
        }
    }
    
    static void GenerateTemperatureAlert(double currentTemp, double previousTemp)
    {
        Console.WriteLine($"Current Temperature: {currentTemp}°C");
        Console.WriteLine($"Previous Temperature: {previousTemp}°C");
        
        string baseAlert = GetTemperatureAlert(currentTemp);
        Console.WriteLine($"Alert: {baseAlert}");
        
        if (IsRapidTemperatureChange(currentTemp, previousTemp))
        {
            Console.WriteLine("⚠ WARNING: Rapid temperature change detected!");
        }
    }
    
    static string GetTemperatureAlert(double temperature)
    {
        if (temperature < 0)
            return "Freezing Alert! Risk of ice formation.";
        else if (temperature <= 10)
            return "Cold Alert. Wear warm clothing.";
        else if (temperature <= 25)
            return "Comfortable temperature. No alerts.";
        else if (temperature <= 35)
            return "Heat Alert. Stay hydrated.";
        else
            return "Extreme Heat Warning! Avoid outdoor activities.";
    }
    
    static bool IsRapidTemperatureChange(double current, double previous)
    {
        return Math.Abs(current - previous) > 10;
    }
}