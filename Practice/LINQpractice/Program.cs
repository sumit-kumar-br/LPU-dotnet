using System;
using System.Runtime.CompilerServices;
using LinqPractice;
public class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alok", Age = 20, Marks = 85, City = "Delhi" },
            new Student { Id = 2, Name = "Riya", Age = 22, Marks = 72, City = "Mumbai" },
            new Student { Id = 3, Name = "Rajat", Age = 19, Marks = 78, City = "Delhi" },
            new Student { Id = 4, Name = "Nitya", Age = 21, Marks = 88, City = "Pune" },
            new Student { Id = 5, Name = "Raman", Age = 23, Marks = 65, City = "Bangalore" },
            new Student { Id = 6, Name = "Smita", Age = 22, Marks = 92, City = "Mumbai" },
            new Student { Id = 7, Name = "Saket", Age = 19, Marks = 58, City = "Delhi" },
            new Student { Id = 8, Name = "Prachi", Age = 21, Marks = 88, City = "Pune" },
            new Student { Id = 9, Name = "Naresh", Age = 23, Marks = 95, City = "Bangalore" },
            new Student { Id = 10, Name = "Aarti", Age = 22, Marks = 84, City = "Mumbai" },
            new Student { Id = 11, Name = "Vartika", Age = 19, Marks = 78, City = "Delhi" },
            new Student { Id = 12, Name = "Manan", Age = 21, Marks = 88, City = "Pune" },
            new Student { Id = 13, Name = "Mahesh", Age = 25, Marks = 77, City = "Chennai" },
            new Student { Id = 14, Name = "Ranjeet", Age = 22, Marks = 96, City = "Mumbai" },
            new Student { Id = 15, Name = "Kajal", Age = 19, Marks = 78, City = "Chennai" }

        };

        // All students older than 20
        // List<Student> s1 = students.Where(x=>x.Age>20).ToList();
        // var s2 = students.Where(x=>x.Age>20).ToList();
        
        // Get only students name
        // var nameList = students.Select(x=>x.Name).ToList();

        // count students from Mumbai
        // var mumbai = students.Count(s=>s.City=="Mumbai");

        // Any student with marks above 90
        // var isNinety = students.Any(x=>x.Marks>90);
        // System.Console.WriteLine(isNinety);

        // First student from Delhi
        // var first = students.Find(x=>x.City=="Delhi");
        // var f = students.FirstOrDefault(x=>x.City=="Delhi");
        // System.Console.WriteLine(first.Name);
        // System.Console.WriteLine(f.Name);

        // marks >= 85 ans age < 22
        // var f = students
        //         .Where(s=>s.Marks>=85&&s.Age<22)
        //         .ToList();
        

        // sort by marks(descending)
        // var q7 = students
        //         .OrderByDescending(s=>s.Marks)
        //         .ToList();

        // select name and marks only
        var q8 = students
                .Select(s => new{s.Name,s.Marks,})
                .ToList();

        // student with highest marks
        var q9 = students
                .OrderByDescending(s=>s.Marks)
                .FirstOrDefault();
        var q9_alt = students.MaxBy(s=>s.Marks);

        // group students by city
        // var q10 = students.GroupBy(s=>s.City).ToList();
        // foreach(var city in q10)
        // {
        //     System.Console.WriteLine(city.Key);
        //     System.Console.WriteLine();
        //     foreach(var student in city)
        //     {
        //         System.Console.WriteLine(student.Name);
        //     }
        //     System.Console.WriteLine();
        // }

        // average marks
        var q11 = students.Average(s=>s.Marks);

        // city wise student count
        var q12 = students
                  .GroupBy(s=>s.City)
                  .Select(x=>new{City=x.Key, Count=x.Count()})
                  .ToList();

        // top 2 students by marks
        var q13 = students
                    .OrderByDescending(s=>s.Marks)
                    .Take(2)
                    .ToList();

        var q14 = students
                    .All(s=>s.Age>18);

        

        



    }
}