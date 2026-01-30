using System;

namespace Luxestay
{
    public class HotelRoom : Room
    {
        public string RoomType { get; set; }
        public double RatePerNight { get; set; }
        public string GuestName { get; set; }
        public HotelRoom(string roomType, double ratePerNight, string guestName)
        {
            this.RoomType = roomType;
            this.RatePerNight = ratePerNight;
            this.GuestName = guestName;
        }
        public double calculateTotalBill(int nightsStayed, int joiningYear)
        {
            double totalBill = nightsStayed * RatePerNight;
            int membershipYear = DateTime.Now.Year - joiningYear;
            if(membershipYear > 3)
            {
                totalBill *= 0.9;
            }
            return Math.Round(totalBill);
        }

    }
}