
using System;

class Program
{
    // Returns sum of digits of a number
    static int SumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }

    // Checks if a number is prime
    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    // Checks if the number is a Lucky Number
    static bool IsLucky(int x)
    {
        if (IsPrime(x))
            return false;   // must be non-prime

        int s1 = SumOfDigits(x);
        int s2 = SumOfDigits(x * x);

        return s2 == s1 * s1;
    }

    static void Main()
    {
        int m = 20;
        int n = 30;
        int count = 0;

        for (int i = m; i <= n; i++)
        {
            if (IsLucky(i))
            {
                count++;
            }
        }

        Console.WriteLine(count);
        Console.WriteLine(IsLucky(484));
    }
}
