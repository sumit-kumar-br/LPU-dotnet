using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // Student Class
    // =========================
    public class Student
    {
        public string StudentId { get; private set; }
        public string Name { get; private set; }
        public string Major { get; private set; }
        public int MaxCredits { get; private set; }

        public List<string> CompletedCourses { get; private set; }
        public List<Course> RegisteredCourses { get; private set; }

        public Student(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            StudentId = id;
            Name = name;
            Major = major;
            MaxCredits = maxCredits;
            CompletedCourses = completedCourses ?? new List<string>();
            RegisteredCourses = new List<Course>();
        }

        public int GetTotalCredits()
        {
            // TODO: Return sum of credits of all RegisteredCourses
            //int sumOfCredits = 0;
            //foreach(var course in RegisteredCourses)
            //{
            //    sumOfCredits += course.Credits;
            //}
            //return sumOfCredits;
            return RegisteredCourses.Sum(c => c.Credits);
        }

        public bool CanAddCourse(Course course)
        {
            // TODO:
            // 1. Course should not already be registered
            // 2. Total credits + course credits <= MaxCredits
            // 3. Course prerequisites must be satisfied
            if(!RegisteredCourses.Any(c => c.CourseCode == course.CourseCode) 
                && GetTotalCredits()+course.Credits<=MaxCredits 
                && course.HasPrerequisites(CompletedCourses))
            {
                return true;
            }
            return false;
            
        }

        public bool AddCourse(Course course)
        {
            // TODO:
            // 1. Call CanAddCourse
            // 2. Check course capacity
            // 3. Add course to RegisteredCourses
            // 4. Call course.EnrollStudent()
            if(CanAddCourse(course))
            {
                if (!course.IsFull())
                {
                    RegisteredCourses.Add(course);
                    course.EnrollStudent();
                    return true;
                }
            }
            return false;
        }

        public bool DropCourse(string courseCode)
        {
            // TODO:
            // 1. Find course by code
            // 2. Remove from RegisteredCourses
            // 3. Call course.DropStudent()
            Course course = RegisteredCourses.Find(c => c.CourseCode == courseCode);
            if(course == null)
            {
                return false;
            }
            RegisteredCourses.Remove(course);
            course.DropStudent();
            return true;
        }

        public void DisplaySchedule()
        {
            // TODO:
            // Display course code, name, and credits
            // If no courses registered, display appropriate message
            if (RegisteredCourses.Count == 0)
            {
                Console.WriteLine("No courses registered.");
                return;
            }

            foreach (Course course in RegisteredCourses)
            {
                Console.WriteLine($"Course Code: {course.CourseCode}");
                Console.WriteLine($"Name: {course.CourseName}");
                Console.WriteLine($"Credits: {course.Credits}");
                Console.WriteLine();
            }

        }
    }
}
