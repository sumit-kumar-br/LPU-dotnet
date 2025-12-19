// See https://aka.ms/new-console-template for more information

using System;
using Day2PracticeQuestions;

// Console.WriteLine("Hello, World!");

 
// 1. Height Category
// System.Console.WriteLine("Enter height");
// int height=Int32.Parse(Console.ReadLine());
// HeightCategory.HeightMain(height);
    
// 2. Largest of Three
// int num1;
// int num2;
// int num3;
// System.Console.WriteLine("Enter the first number:");
// num1 = Int32.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the second number:");
// num2 = Int32.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the third number:");
// num3 = Int32.Parse(Console.ReadLine());
// LargestOfThree.Largest(num1, num2, num3);


// 3. Leap Year Checker
// int year;
// System.Console.WriteLine("Enter the year");
// year=Int32.Parse(Console.ReadLine());
// LeapYearChecker.CheckLeapYear(year);


// 4. Quadratic Expression
// int a;
// int b;
// int c;
// System.Console.WriteLine("Enter a: ");
// a = Int32.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter b: ");
// b = Int32.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter c: ");
// c = Int32.Parse(Console.ReadLine());
// QuadraticEquation.QuadEquation(a,b,c);

// 5. Admission Eligiblity
int math;
int phy;
int che;
System.Console.WriteLine("Enter marks of Maths: ");
math=Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Enter marks of Physics: ");
phy=Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Enter marks of Chemistry: ");
che=Int32.Parse(Console.ReadLine());
AdmissionEligibility.IsEligible(math,phy,che);


