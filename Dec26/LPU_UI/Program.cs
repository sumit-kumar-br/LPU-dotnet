// UI class of the project

using System;
using LPU_BL;
using LPU_Entity;
using LPU_Exceptions;
using System.Collections.Generic;

namespace LPU_UI
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("     Student Management System");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Search Student By ID ");
            Console.WriteLine("2. Search Student By Name");
            Console.WriteLine("3. Add Student Details");
            Console.WriteLine("4. Update Student Details");
            Console.WriteLine("5. Drop Student Details");
            Console.WriteLine("6. Exit");
        }
        static void Main(string[] args)
        {
            StudentBL sblObj = null;
            sblObj = new StudentBL();
            do
            {
                Menu();
                int choice = 0;
                Console.WriteLine("Please Enter Your Choice :");
                choice = Int32.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    case 1: // Search student by ID
                        {
                            int id = 0;
                            try
                            {
                                Console.WriteLine("Enter Student ID for Search :");
                                id = Convert.ToInt32(Console.ReadLine());

                                Student sObj = sblObj.SearchStudentByID(id);
                                
                                if(sObj != null)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("ID\t| Name\t| Course\t| Address");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("========================================");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($"{sObj.StudentId}\t| {sObj.Name}\t| {sObj.Course}\t| {sObj.Address}");
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                            }
                            catch(LpuException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            
                            break;
                        }
                    case 2: // Search Student By Name
                        {
                            try
                            {
                                Console.WriteLine("Enter Student Name for Search :");
                                String name = Console.ReadLine();
                                List<Student> studList = sblObj.SearchStudentByName(name);

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("ID\t| Name\t| Course\t| Address");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("========================================");

                                foreach (var sObj in studList)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($"{sObj.StudentId}\t| {sObj.Name}\t| {sObj.Course}\t| {sObj.Address}");
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            catch(LpuException e)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("We are coming soon.....");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            catch(Exception e)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("We are coming soon.....");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            
                            break;
                        }
                    case 3: // Add Students
                        {
                            try
                            {
                                Student sObj = new Student();
                                Console.WriteLine("Enter student's ID ");
                                sObj.StudentId = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Enter student's name ");
                                sObj.Name = Console.ReadLine();
                                Console.WriteLine("Enter the course (Mechanical, Electrical, Civil, CSE, IT) ");
                                string course = Console.ReadLine();
                                sObj.Course = Enum.Parse<CourseType>(course);
                                Console.WriteLine("Enter the address ");
                                sObj.Address = Console.ReadLine();

                                bool result = sblObj.EnrollStudent(sObj);
                                if(result)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Student enrolled successfully!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                            catch(LpuException e)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(e.Message);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            catch(Exception e)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(e.Message);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            
                            break;
                        }
                    case 4: // Modify Students details
                        {
                            break;
                        }
                    case 5: // Drop Students details
                        {
                            break;
                        }
                    case 6: // exit from Application
                        {
                            return ;
                        }
                    default:
                        break;
                }
            } while (true);
        }
    }
}