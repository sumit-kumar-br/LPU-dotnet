using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
     // =========================
    // Program (Menu-Driven)
    // =========================
    class Program
    {
        static void Main()
        {
            UniversitySystem system = new UniversitySystem();
            bool exit = false;

            Console.WriteLine("Welcome to University Course Registration System");

            while (!exit)
            {
                Console.WriteLine("\n1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Register Student for Course");
                Console.WriteLine("4. Drop Student from Course");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("6. Display Student Schedule");
                Console.WriteLine("7. Display System Summary");
                Console.WriteLine("8. Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                try
                {
                    // TODO:
                    // Implement menu handling logic using switch-case
                    // Prompt user inputs
                    // Call appropriate UniversitySystem methods
                    switch (choice)
                    {
                        case "1": // Add Course
                            Console.Write("Course Code: ");
                            string code = Console.ReadLine();

                            Console.Write("Course Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Credits: ");
                            int credits = int.Parse(Console.ReadLine());

                            Console.Write("Max Capacity (default 50): ");
                            string capInput = Console.ReadLine();
                            int maxCapacity = string.IsNullOrEmpty(capInput) ? 50 : int.Parse(capInput);

                            system.AddCourse(code, name, credits, maxCapacity);
                            Console.WriteLine("Course added successfully!");
                            break;

                        case "2": // Add Student
                            Console.Write("Student ID: ");
                            string studentId = Console.ReadLine();

                            Console.Write("Name: ");
                            string studentName = Console.ReadLine();

                            Console.Write("Major: ");
                            string major = Console.ReadLine();

                            Console.Write("Max Credits (default 18): ");
                            string creditInput = Console.ReadLine();
                            int maxCredits = string.IsNullOrEmpty(creditInput) ? 18 : int.Parse(creditInput);

                            system.AddStudent(studentId, studentName, major, maxCredits);
                            Console.WriteLine("Student added successfully!");
                            break;

                        case "3": // Register Student for Course
                            Console.Write("Student ID: ");
                            string regStudentId = Console.ReadLine();

                            Console.Write("Course Code: ");
                            string regCourseCode = Console.ReadLine();

                            system.RegisterStudentForCourse(regStudentId, regCourseCode);
                            break;

                        case "4": // Drop Student from Course
                            Console.Write("Student ID: ");
                            string dropStudentId = Console.ReadLine();

                            Console.Write("Course Code: ");
                            string dropCourseCode = Console.ReadLine();

                            system.DropStudentFromCourse(dropStudentId, dropCourseCode);
                            break;

                        case "5": // Display All Courses
                            system.DisplayAllCourses();
                            break;

                        case "6": // Display Student Schedule
                            Console.Write("Student ID: ");
                            string scheduleStudentId = Console.ReadLine();

                            system.DisplayStudentSchedule(scheduleStudentId);
                            break;

                        case "7": // Display System Summary
                            system.DisplaySystemSummary();
                            break;

                        case "8": // Exit
                            exit = true;
                            Console.WriteLine("Exiting system. Goodbye!");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

