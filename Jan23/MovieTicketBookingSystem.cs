// File: MovieTicketBooking.cs
using System;
using System.Collections.Generic;

class MovieTicketBooking
{
    static void Main()
    {
        Console.WriteLine("=== MOVIE TICKET BOOKING SYSTEM ===\n");
        
        // Sample data: Age, ShowTime, IsStudent, Is3D, NumTickets
        List<(int, int, bool, bool, int)> bookings = new List<(int, int, bool, bool, int)>
        {
            (10, 14, false, false, 2),   // Child, matinee
            (25, 20, true, true, 1),     // Student, evening, 3D
            (65, 16, false, false, 2),   // Senior, afternoon
            (30, 19, false, false, 6),   // Adult, evening, group
            (22, 14, true, false, 3),    // Student, matinee
            (40, 21, false, true, 4)     // Adult, late, 3D
        };
        
        foreach (var booking in bookings)
        {
            CalculateTicketPrice(
                booking.Item1,  // age
                booking.Item2,  // showTime
                booking.Item3,  // isStudent
                booking.Item4,  // is3D
                booking.Item5   // numTickets
            );
            Console.WriteLine("------------------------");
        }
    }
    
    static void CalculateTicketPrice(int age, int showTime, bool isStudent, bool is3D, int numTickets)
    {
        double basePrice = 12.00;
        
        // Apply age discount
        double discountRate = GetAgeDiscountRate(age, isStudent);
        
        // Apply time-based pricing
        double timeAdjustment = GetTimeAdjustment(showTime);
        
        // Apply 3D premium
        double premium3D = is3D ? 5.00 : 0.00;
        
        // Calculate price per ticket
        double pricePerTicket = basePrice * (1 - discountRate) + timeAdjustment + premium3D;
        
        // Apply group discount
        double groupDiscount = numTickets >= 6 ? 0.10 : 0.00;
        
        // Calculate total price
        double totalPrice = pricePerTicket * numTickets * (1 - groupDiscount);
        
        // Display booking details
        Console.WriteLine("Booking Details:");
        Console.WriteLine($"  • Age: {age}");
        Console.WriteLine($"  • Show Time: {showTime}:00");
        Console.WriteLine($"  • Student: {(isStudent ? "Yes" : "No")}");
        Console.WriteLine($"  • 3D Movie: {(is3D ? "Yes" : "No")}");
        Console.WriteLine($"  • Number of Tickets: {numTickets}");
        
        // Display price breakdown
        Console.WriteLine("\nPrice Breakdown:");
        Console.WriteLine($"  • Base Price: ${basePrice:F2}");
        
        if (discountRate > 0)
        {
            Console.WriteLine($"  • Age Discount: {discountRate:P0} (-${basePrice * discountRate:F2})");
        }
        
        if (timeAdjustment != 0)
        {
            string adjustmentType = timeAdjustment > 0 ? "Evening Premium" : "Matinee Discount";
            Console.WriteLine($"  • {adjustmentType}: ${Math.Abs(timeAdjustment):F2}");
        }
        
        if (premium3D > 0)
        {
            Console.WriteLine($"  • 3D Premium: ${premium3D:F2}");
        }
        
        Console.WriteLine($"\n  • Price per Ticket: ${pricePerTicket:F2}");
        
        if (groupDiscount > 0)
        {
            Console.WriteLine($"  • Group Discount ({numTickets} tickets): {groupDiscount:P0}");
        }
        
        Console.WriteLine($"\nTOTAL PRICE: ${totalPrice:F2}");
    }
    
    static double GetAgeDiscountRate(int age, bool isStudent)
    {
        if (age < 12) return 0.30;           // Children
        if (age >= 60) return 0.25;          // Seniors
        if (isStudent) return 0.20;          // Students
        return 0.00;                         // Adults
    }
    
    static double GetTimeAdjustment(int showTime)
    {
        if (showTime < 17) return -2.00;     // Matinee discount
        if (showTime >= 17) return 3.00;     // Evening premium
        return 0.00;
    }
}