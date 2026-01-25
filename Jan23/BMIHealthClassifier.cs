
// File: BMICalculator.cs
using System;
using System.Collections.Generic;

class BMICalculator
{
    static void Main()
    {
        Console.WriteLine("=== BMI HEALTH CLASSIFIER ===\n");
        
        // Sample data: Weight(kg), Height(m), IsAthlete
        List<(double, double, bool)> persons = new List<(double, double, bool)>
        {
            (50.0, 1.65, false),    // Underweight
            (65.0, 1.75, false),    // Normal
            (85.0, 1.75, false),    // Overweight
            (100.0, 1.70, false),   // Obese
            (90.0, 1.80, true),     // Athlete - overweight BMI but high muscle
            (58.0, 1.60, false)     // Normal
        };
        
        foreach (var person in persons)
        {
            AnalyzeBMI(person.Item1, person.Item2, person.Item3);
            Console.WriteLine("------------------------");
        }
    }
    
    static void AnalyzeBMI(double weight, double height, bool isAthlete)
    {
        double bmi = CalculateBMI(weight, height);
        string classification = ClassifyBMI(bmi, isAthlete);
        
        Console.WriteLine($"Weight: {weight} kg");
        Console.WriteLine($"Height: {height} m");
        Console.WriteLine($"Is Athlete: {(isAthlete ? "Yes" : "No")}");
        Console.WriteLine($"BMI: {bmi:F1}");
        Console.WriteLine($"Health Classification: {classification}");
        
        DisplayRecommendations(bmi, weight, height, isAthlete);
    }
    
    static double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }
    
    static string ClassifyBMI(double bmi, bool isAthlete)
    {
        if (isAthlete)
        {
            return bmi switch
            {
                < 18.5 => "Underweight (Athlete)",
                < 25 => "Normal (Athlete)",
                < 30 => "Fit (High muscle mass)",
                _ => "Obese (Consult doctor)"
            };
        }
        else
        {
            return bmi switch
            {
                < 18.5 => "Underweight",
                < 25 => "Normal",
                < 30 => "Overweight",
                _ => "Obese"
            };
        }
    }
    
    static void DisplayRecommendations(double bmi, double weight, double height, bool isAthlete)
    {
        if (!isAthlete)
        {
            if (bmi < 18.5)
            {
                double targetWeight = 18.5 * height * height;
                double gainNeeded = targetWeight - weight;
                Console.WriteLine($"Recommendation: Gain {gainNeeded:F1} kg to reach normal range");
            }
            else if (bmi >= 25)
            {
                double targetWeight = 24.9 * height * height;
                double loseNeeded = weight - targetWeight;
                Console.WriteLine($"Recommendation: Lose {loseNeeded:F1} kg to reach normal range");
            }
            else
            {
                Console.WriteLine("Recommendation: Maintain current weight");
            }
        }
        else
        {
            Console.WriteLine("Recommendation: As an athlete, focus on body composition rather than BMI");
        }
    }
}