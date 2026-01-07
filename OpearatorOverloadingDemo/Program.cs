// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// int num1=100;
// int num2=200;
// int numResult=num1+num2;
// System.Console.WriteLine(numResult);

Employee emp1 = new Employee();
emp1.EmpID = 101;
emp1.EmpName = "Alok";
emp1.BSalary=40000;

Employee emp2 = new Employee();
emp2.EmpID = 102;
emp2.EmpName = "Riya";
emp2.BSalary=35000;

Employee emp3 = new Employee();
emp3.EmpID = 1789;
emp3.EmpName = "Manjeet";
emp3.BSalary=65000;

Employee empObj=emp1+emp2+emp3;
System.Console.WriteLine($"Total salary paid {empObj.BSalary}");

MyLogic m1 = new MyLogic();
m1.ShowCustomerDetails();
m1.ShowEmployeeDetails();