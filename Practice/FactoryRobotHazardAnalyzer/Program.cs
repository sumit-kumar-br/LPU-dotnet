using System;
using FactoryRobotHazardAnalyzer;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter Arm Precision (0.0 - 1.0):");
            double armPrecision = Double.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter Worker Density (1 - 20):");
            int workerDensity = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical):");
            string machinaryState = Console.ReadLine();

            RobotHazardAuditor obj = new RobotHazardAuditor();
            double hazardRisk = obj.CalculateHazardRisk(armPrecision,workerDensity,machinaryState);
            System.Console.WriteLine("Robot Hazard Risk Score: " + hazardRisk);
        }
        catch(RobotSafetyException e)
        {
            System.Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
}

