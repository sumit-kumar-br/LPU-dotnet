using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

public record Student(string Name, int Score);

// JSON source generator context
[JsonSerializable(typeof(Student[]))]
public partial class StudentJsonContext : JsonSerializerContext
{
}

class Program
{
    static string BuildAndSerialize(string[] items, int minScore)
    {
        var students = new List<Student>(items.Length);

        foreach (var item in items)
        {
            var parts = item.Split(':');
            if (parts.Length == 2 && int.TryParse(parts[1], out int score))
            {
                students.Add(new Student(parts[0], score));
            }
        }

        var result = students
            .Where(s => s.Score >= minScore)
            .OrderByDescending(s => s.Score)
            .ThenBy(s => s.Name)
            .ToArray();

        return JsonSerializer.Serialize(
            result,
            StudentJsonContext.Default.StudentArray
        );
    }

    static void Main()
    {
        string[] items = { "Alice:85", "Bob:70", "Charlie:85", "Dave:60" };
        int minScore = 70;

        string json = BuildAndSerialize(items, minScore);
        Console.WriteLine(json);
    }
}

