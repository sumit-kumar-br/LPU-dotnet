
namespace CSharp11NewFeatures._2.List_patterns;

public class FeatureTwo
{

    public static void FeatureExample() 
    {
        int[] numbers = { 5, 10, 15, 20 };
        Console.WriteLine(numbers is [5, 10, 15]);//false
        Console.WriteLine(numbers is [5, 10, 15, ..var rest]); //true
        Console.WriteLine(numbers is [ >= 5, <= 10, _, <= 25]); //true
        if(numbers is [var First, ..var restArray])
        {
            Console.WriteLine(First);
        }

        //string Array Cases
        var emptyStringArray = Array.Empty<string>();
        var myName = new[] { "Muhammad Jamal" };
        var myNameWordsArray = new[] { "Muhammad", "Jamal" };
        var myNameFullNameWords = new[] { "Muhammad", "Jamal", "Muhammad", "Bekheit" };
        var test1 = emptyStringArray switch
        {
            [] => "This Is Empty Array",
            [var fullName] => $"My Name iS {fullName}",
            [var firstName , var lastName] => $"My First Name : {firstName} , Last Name : {lastName}",
            [var first, ..var restName] => $"My FullName is {first} {restName.ToString()}"
        };
        Console.WriteLine(test1);

        var test2 = emptyStringArray switch
        {
            [] => "This Is Empty Array",
            [var fullName] => $"My Name iS {fullName}",
            [var firstName, var lastName] => $"My First Name : {firstName} , Last Name : {lastName}",
            [var first, .. var restName] => $"My FullName is {first} {restName.ToString()}"
        };
        Console.WriteLine(test2);

        var test3 = myNameWordsArray switch
        {
            [] => "This Is Empty Array",
            [var fullName] => $"My Name iS {fullName}",
            [var firstName, var lastName] => $"My First Name : {firstName} , Last Name : {lastName}",
            [var first, .. var restName] => $"My FullName is {first} {restName.ToString()}"
        };
        Console.WriteLine(test3);

        var test4 = myNameFullNameWords switch
        {
            [] => "This Is Empty Array",
            [var fullName] => $"My Name iS {fullName}",
            [var firstName, var lastName] => $"My First Name : {firstName} , Last Name : {lastName}",
            [var first, .. var restName] => $"My FullName is {first} {string.Join(" ",restName) }"
        };
        Console.WriteLine(test4);
    }
}
