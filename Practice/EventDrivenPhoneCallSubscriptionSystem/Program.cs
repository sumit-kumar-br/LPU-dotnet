using System;

class Program
{
    public static void Main(string[] args)
    {
        PhoneCall phoneCallObj = new PhoneCall();
        phoneCallObj.MakeAPhoneCall(true);
        System.Console.WriteLine(phoneCallObj.Message);

        phoneCallObj.MakeAPhoneCall(false);
        System.Console.WriteLine(phoneCallObj.Message);    
    }
}