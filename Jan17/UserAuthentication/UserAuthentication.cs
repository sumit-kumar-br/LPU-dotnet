using System;

class PasswordMismatchException : Exception
{
    public override string Message =>
        "Password entered does not match";
}

class User
{
    public string Name { get; set; }
    public string Password { get; set; }

    public User ValidatePassword(string name, string password, string confirm)
    {
        if (password != confirm)
            throw new PasswordMismatchException();

        return new User { Name = name, Password = password };
    }
    static void Main()
    {
        User user = new User();

        Console.WriteLine("Enter Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Password:");
        string password = Console.ReadLine();

        Console.WriteLine("Enter Confirm Password:");
        string confirm = Console.ReadLine();

        try
        {
            user.ValidatePassword(name, password, confirm);
            Console.WriteLine("Registered Successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
