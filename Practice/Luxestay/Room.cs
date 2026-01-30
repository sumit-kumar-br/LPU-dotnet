using System;
using System.ComponentModel;

namespace Luxestay
{
    public interface Room
    {
        public double calculateTotalBill(int nightsStayed, int joiningYear);
        public int calculateMembershipYears(int joiningYear)
        {
            return DateTime.Now.Year - joiningYear;
        }
    }
}