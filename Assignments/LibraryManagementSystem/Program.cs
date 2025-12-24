// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using LibraryManagementSystem;

string title;
string author;
int numPages;
DateTime dueDate;
DateTime returnedDate;
int daysToRead;
int dailyLateFee;

Console.WriteLine("Enter the title");
title = Console.ReadLine();
Console.WriteLine("Enter the author");
author = Console.ReadLine();
Console.WriteLine("Enter the number of pages");
numPages = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter the due date");
dueDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter the returned date");
returnedDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter the days to read");
daysToRead = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter the daily late feeRate");
dailyLateFee = Int32.Parse(Console.ReadLine());

Book book = new Book(title, author, numPages, dueDate, returnedDate);
Console.WriteLine($"Average Pages Read Per Day : {book.AveragePagesReadPerDay(daysToRead)}");
Console.WriteLine($"Late Fee : {book.CalculateLateFee(dailyLateFee)}");






