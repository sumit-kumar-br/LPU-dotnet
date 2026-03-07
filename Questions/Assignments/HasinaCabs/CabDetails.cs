using System;
using System.Text.RegularExpressions;

namespace HasinaCabs;

public class CabDetails: Cab
{
    public bool ValidateBookingID()
    {
        string pattern = @"AC@/d{3}$";
        return !Regex.IsMatch(BookingID, pattern);
    }
    public double CalculateFareAmount()
    {
        double pricePerKm;
        switch (CabType)
        {
            case "Hatchback":
                {
                    pricePerKm = 10;
                    break;
                }
            case "Sedan":
                {
                    pricePerKm = 20;
                    break;
                }
            case "SUV":
                {
                    pricePerKm = 30;
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid cab type");
                    return 0.0;
                }
        }
        double waitingCharge = Math.Sqrt(WaitingTime);
        double totalFare = Math.Floor(Distance * pricePerKm + waitingCharge * 100)/100;
        return totalFare;
    }

}
