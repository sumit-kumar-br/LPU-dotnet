using System;
namespace Demo
{ 
	public class Circle
	{
		int radius;
		public Circle(int r)
		{ 
		radius = r; 
		}
	}
	public class Employee
	{
		public string EmpName{get;set;}
	}
	public class Square
	{
		int length;
		public Square(int l) 
		{ 
		length = l;
		}
	}
	public class IsTest
	{
			public static void Test(object o)
			{
				Circle c;
				Square s;
				Employee e1;
				if (o is Circle)
				{
				Console.WriteLine("o is Circle");
				c = (Circle)o;
				}
				else if (o is Square)
				{
				Console.WriteLine("o is Square");
				s = (Square)o;
				}
				else if(o is Employee)
				{
					e1=(Employee)o;
					e1.EmpName="Alok";
					Console.WriteLine(e1.EmpName);
					
				}
				else
				{
				Console.WriteLine("o is neither Circle nor Square");
				}
			}
	
	
			public static void Main(string[] args)
			{
				Circle c1 = new Circle(10);
				Square s1 = new Square(12);
				Employee emp=new Employee();
				Test(emp);
				Test(c1);
				Test(s1);
			}
	}
}