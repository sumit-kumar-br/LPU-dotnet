using System;
using System.Linq.Expressions;

namespace CakeWorld;

public class InvalidFlavourException: Exception
{
    public InvalidFlavourException():base()
    {
    }
    public InvalidFlavourException(string errorMsg):base(errorMsg)
    {   
    }
}
public class InvalidQuantityException: Exception
{
    public InvalidQuantityException(): base()
    {
        
    }
    public InvalidQuantityException(string errorMsg) : base(errorMsg)
    {
        
    }
}
public class Cake
{
    public string Flavour { get; set; }
    public int QuantityInKg { get; set; }
    public double PricePerKg { get; set; }
    public int discount { get; set; }
    public bool CakeOrder()
    {
        if(Flavour != "Chocolate" && Flavour != "Red Velvet" || Flavour != "Vanilla")
        {
            throw new InvalidFlavourException("Flavour not available. Please select the available flavour");
        }
        if(QuantityInKg <= 0)
        {
            throw new InvalidQuantityException("Quantity must be greater than zero");
        }
        return true;
    }
    public double CalculatePrice()
    {
        switch (Flavour)
        {
            case "Vanilla":
                {
                    discount = 3;
                    break;
                }
            case "Chocolate":
                {
                    discount = 5;
                    break;
                }
            case "Red Velvet":
                {
                    discount = 10;
                    break;
                }
            default:
                {
                    break;
                }
        }
        double totalPrice = QuantityInKg * PricePerKg;
        double discountPrice = totalPrice - totalPrice*discount/100;
        return discountPrice;
    }
}
