using System;

class InsufficientWalletBalanceException : Exception
{
    public override string Message =>
        "Insufficient balance in your digital wallet";
}

class EcommerceShop
{
    public string UserName { get; set; }
    public double WalletBalance { get; set; }
    public double TotalPurchaseAmount { get; set; }

    public EcommerceShop MakePayment(string name, double balance, double amount)
    {
        if (balance < amount)
            throw new InsufficientWalletBalanceException();

        return new EcommerceShop
        {
            UserName = name,
            WalletBalance = balance - amount,
            TotalPurchaseAmount = amount
        };
    }
    static void Main()
    {
        User user = new User();

        try
        {
            User u = user.ValidatePassword("Sumit", "pass123", "pass123");
            Console.WriteLine("Registered Successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
