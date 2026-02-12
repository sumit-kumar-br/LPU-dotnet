public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
    public int Age { get; set; }
    public int Attendance { get; set; }
}

public class EligiblityEngine
{
    public void CheckEligibility(Student student, string program, Predicate<Student> rule)
    {
        Console.WriteLine($"========= ELIGIBILITY CHECK =========");
        Console.WriteLine($"Student Name : {student.Name}");
        Console.WriteLine($"Program      : {program}");
        Console.WriteLine($"Eligible     : {rule(student)}");
        Console.WriteLine($"-----------------------------------");
        Console.WriteLine();
    }
}
public class Solution
{
    public static void Main()
    {
        // STEP 1: Create student object (hardcoded dataset)
        Student student = new Student
        {
            StudentId = 301,
            Name = "Ananya",
            Marks = 78,
            Age = 18,
            Attendance = 85
        };
        Predicate<Student> engineeringEligiblity = s => s.Marks >= 60;
        Predicate<Student> medicalEligiblity = s => s.Marks >= 70 && s.Age >= 17;
        Predicate<Student> managementEligiblity = s => s.Marks >= 55 && s.Attendance >= 75;

        EligiblityEngine engine = new EligiblityEngine();
        engine.CheckEligibility(student, "Engineering", engineeringEligiblity);
        engine.CheckEligibility(student, "Medical", medicalEligiblity);
        engine.CheckEligibility(student, "Management", managementEligiblity);

    }
}
