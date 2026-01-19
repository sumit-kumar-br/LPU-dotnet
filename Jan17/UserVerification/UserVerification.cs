using System;

class InvalidPhoneNumberException : Exception
{
    public override string Message => "Invalid phone number";
}

class UserVerification
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public UserVerification ValidatePhoneNumber(string name, string phone)
    {
        if (phone.Length != 10)
            throw new InvalidPhoneNumberException();

        return new UserVerification
        {
            Name = name,
            PhoneNumber = phone
        };
    }
}
class Program
{
    static void Main()
    {
        UserVerification user = new UserVerification();

        Console.WriteLine("Enter Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Phone Number:");
        string phone = Console.ReadLine();

        try
        {
            user.ValidatePhoneNumber(name, phone);
            Console.WriteLine("Phone number verified");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
