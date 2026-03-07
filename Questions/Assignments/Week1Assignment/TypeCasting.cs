using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;

namespace Week1Assignment;

public class TypeCasting
{
    public static void TypeCast()
    {
        int size1;
        int size2;
        Console.WriteLine("Enter the size of first array: ");
        size1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the size of second array: ");
        size2 = Int32.Parse(Console.ReadLine());
        double[] dInputArray1 = new double[size1];
        double[] dInputArray2 = new double[size2];

        Console.WriteLine("Enter the elements of the first arrsy: ");
        for(int i=0; i<size1; i++)
        {
            dInputArray1[i] = Double.Parse(Console.ReadLine());   
        }
        Console.WriteLine("Enter the elements of the second arrsy: ");
        for(int i=0; i<size2; i++)
        {
            dInputArray2[i] = Double.Parse(Console.ReadLine());   
        }
        int size = Math.Max(size1, size2);
        int[] sumArray = new int[size];
        for(int i=0; i<size; i++)
        {
            double val1 = (i<size1) ? dInputArray1[i]: 0;
            double val2 = (i<size2) ? dInputArray2[i]: 0;
            sumArray[i] = (int)(val1+val2);
        }
        Console.WriteLine("Sum Array: ");
        for(int i=0; i<size; i++)
        {
            Console.Write(sumArray[i]+" ");
        }
    }
}