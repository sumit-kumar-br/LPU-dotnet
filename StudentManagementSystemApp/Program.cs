// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using StudentManagementSystem;

StudentBL sblObj = new StudentBL();
sblObj.AcceptStudentDetailS();
// sblObj.CalcTotal();
// sblObj.CalcAverage();
int t1;
float p1;
sblObj.CalcResult(out t1, out p1);
System.Console.WriteLine($"Total: {t1}");
System.Console.WriteLine($"Percentage: {p1}");
