using System;

namespace Day2DemoConsole;

public class Student
{
    #region Fields
        int rollNo;
        string name;
        string addr;
    #endregion

    /// <summary>
    /// default constructor for student class
    /// </summary>
    public Student()
    {
        rollNo=100;
        name="Dummy";
        addr="Dummy City";
    }

    public Student(int id, string name, string city)
    {
        rollNo=id;
        this.name=name;
        addr=city;
    }

    public void DisplayDetails(Student s1)
    {
        System.Console.WriteLine(" Roll No: {0}\n Name: {1}\n Add: {2}",s1.rollNo, s1.name, s1.addr);
    }
}