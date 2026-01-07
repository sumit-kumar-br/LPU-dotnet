using System;
using NameTenPercent;
class AddPrg
{
	static void Main()
	{
		int num1;
		int num2;
		Console.Write("Enter first number:");
		num1 = Int32.Parse(Console.ReadLine());
		Console.Write("Enter second number:");
		num2 = Int32.Parse(Console.ReadLine());
		int numResult=num1+num2;
		Console.WriteLine("Sum of {0} and {1} is {2}",num1, num2, numResult);
		ClassTenPercent ctpObj = new ClassTenPercent();
		int tenP = ctpObj.MethodTenPercent(numResult);
		Console.WriteLine("Ten Percent of {0} is {1}",numResult, tenP);
	}
}	