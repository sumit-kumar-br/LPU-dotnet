// Day 2 class 

using System.Runtime.InteropServices;
using Day2DemoConsole;
static void Menu()
{
    System.Console.WriteLine("1. Add student details");
    System.Console.WriteLine("2. Update student details");
    System.Console.WriteLine("3. Drop student details");
}
Console.WriteLine("Hello, World!");

Student sObj = new Student(123, "Sumit", "Delhi");
sObj.DisplayDetails(sObj);

sObj = new Student(123, "Sumit", "Mumbai");
sObj.DisplayDetails(sObj);

string[] cities={"Pune", "Chennai", "Agra", "Amritsar", "Mumbai"};
// int i=0;
// while(i<cities.Length)
// {
//     System.Console.WriteLine(cities[i]);
//     i++;
// }
foreach(var city in cities)
{
    System.Console.WriteLine(city);
}
int choice=0;
do
{
    Menu();
    System.Console.WriteLine("Enter your choice: ");
    choice = Int32.Parse(Console.ReadLine());
    switch(choice)
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        default:
            break;
    }
}while(true);