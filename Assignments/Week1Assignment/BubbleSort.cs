using System;
using System.Transactions;

namespace Week1Assignment;

public class BubbleSort
{
    public static void Sort()
    {
        int size;
        Console.WriteLine("Enter the esize of the array: ");
        size=Int32.Parse(Console.ReadLine());
        int[] arrNum = new int[size];
        for(int i=0; i<size; i++)
        {
            Console.WriteLine("Enter the element {0}",i+1);
            arrNum[i] = Int32.Parse(Console.ReadLine());
        }
        Console.WriteLine("Before swap");
        Display(arrNum, size);
        for(int i=0; i<size-1; i++)
        {
            for(int j=0; j<size-i-1; j++)
            {
                if (arrNum[j] > arrNum[j + 1])
                {
                    int temp = arrNum[j];
                    arrNum[j] = arrNum[j+1];
                    arrNum[j+1] = temp;
                }
            }
        }
        Console.WriteLine("After swap");
        Display(arrNum, size);
    }
    public static void Display(int[] arr, int size)
    {
        for(int i=0; i<size; i++)
        {
            Console.Write("{0} ",arr[i]);
        }
        Console.WriteLine();
    }
}
