using System;

namespace LibraryManagementSystem;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int NumPages { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime ReturnedDate { get; set; }
    public Book()
    {
        
    }
    public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
    {
        this.Title = title;
        this.Author = author;
        this.NumPages = numPages;
        this.DueDate = dueDate;
        this.ReturnedDate = returnedDate;
    }
   public double AveragePagesReadPerDay(int daysToRead)
    {
        double averagePagesToReadPerDay = (double)NumPages/ daysToRead;
        return averagePagesToReadPerDay;
    }
    public double CalculateLateFee(double dailyLateFeeRate)
    {
        int daysLate = (ReturnedDate - DueDate).Days;
        double lateFee = daysLate * dailyLateFeeRate;
        return lateFee;
    }

}
