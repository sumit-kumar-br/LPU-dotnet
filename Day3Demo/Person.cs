using System;

namespace Day3Demo;

internal class Person
{
    public Person()
    {
        System.Console.WriteLine("Person Class Constructor invoked");
    }
    ~Person()
    {
        System.Console.WriteLine("Person Class Destructor invoked");
    }
    ///display method for demo purposes
}
