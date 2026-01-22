using System;

class Program
{
    static int[] GetTableRow(int n, int upto)
    {
        int[] row = new int[upto];
        for (int i = 1; i <= upto; i++)
        {
            row[i - 1] = n * i;
        }
        return row;
    }

    static void Main(string[] args)
    {
        int n = 3;
        int upto = 5;

        int[] result = GetTableRow(n, upto);
        Console.WriteLine(string.Join(",", result));
        // Output: 3,6,9,12,15
    }
}
