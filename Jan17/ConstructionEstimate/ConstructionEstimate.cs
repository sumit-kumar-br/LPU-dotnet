using System;

class ConstructionEstimateException : Exception
{
    public override string Message =>
        "Sorry your Construction Estimate is not approved";
}

class EstimateDetails
{
    public float ConstructionArea { get; set; }
    public float SiteArea { get; set; }

    public EstimateDetails ValidateConstructionEstimate(float cArea, float sArea)
    {
        if (cArea < sArea)
            throw new ConstructionEstimateException();

        return new EstimateDetails
        {
            ConstructionArea = cArea,
            SiteArea = sArea
        };
    }
}
class Program
{
    static void Main()
    {
        EstimateDetails estimate = new EstimateDetails();

        Console.WriteLine("Enter Construction Area:");
        float cArea = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter Site Area:");
        float sArea = float.Parse(Console.ReadLine());

        try
        {
            estimate.ValidateConstructionEstimate(cArea, sArea);
            Console.WriteLine("Construction Estimate Approved");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
