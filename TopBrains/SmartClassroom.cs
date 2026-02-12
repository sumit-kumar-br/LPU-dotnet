using System;

public class Solution
{
    public bool IsAttendanceValid(
        int loginMinute,
        int totalMinutesPresent,
        bool biometricVerified
    )
    {
        if(loginMinute <= 10 && totalMinutesPresent >= 45 && biometricVerified){
            return true;
        }
        return false;
    }
}
