// using System.Linq;

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
}
public class Solution
{
    public static List<Student> getPassedStudents(List<Student> students)
    {
        return students.Where(s => s.Marks >= 50).ToList();
    }
    public static Student getTopper(List<Student> students)
    {
        return students.MaxBy(s => s.Marks);
    }
    public static List<Student> sortedByMarks(List<Student> students)
    {
        return students.OrderByDescending(s => s.Marks).ToList();
    }
    public static void Main()
    {
        List<Student> studentList = new List<Student>()
        {
            new Student{StudentId=101, Name="Ananya", Marks=78},
            new Student{StudentId=102, Name="Ravi", Marks=45},
            new Student{StudentId=103, Name="Neha", Marks=88},
            new Student{StudentId=104, Name="Arjun", Marks=67},
        };
        Console.WriteLine("Passed Students:");
        List<Student> passedStudents = getPassedStudents(studentList);
        passedStudents.ForEach(s => Console.WriteLine($"{s.Name}"));
        Console.WriteLine();

        Console.WriteLine("Topper:");
        Student topper = getTopper(studentList);
        Console.WriteLine($"{topper.Name} - {topper.Marks}");
        Console.WriteLine();

        Console.WriteLine("Students Sorted by Marks:");
        List<Student> orderedStudent = sortedByMarks(studentList);
        orderedStudent.ForEach(s => Console.WriteLine($"{s.Name} - {s.Marks}"));
        Console.WriteLine();
        
    }
}