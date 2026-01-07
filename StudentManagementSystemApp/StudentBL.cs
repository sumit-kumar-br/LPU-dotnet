using System;
namespace StudentManagementSystem
{
    public class StudentBL
    {
        Student sObj = null;
        public StudentBL()
        {
            sObj = new Student();
        }
        public void AcceptStudentDetailS()
        {
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            System.Console.WriteLine("  Student Management System   ");
            System.Console.WriteLine("==============================");
            Console.ForegroundColor=ConsoleColor.DarkCyan;
            try
            {
                System.Console.WriteLine("Enter your roll no: ");
                sObj.RollNo=Int32.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter your Name: ");
                sObj.Name=Console.ReadLine();
                
                System.Console.WriteLine("Enter your Address: ");
                sObj.Address=Console.ReadLine();         

                System.Console.WriteLine("Enter your Physics Marks: ");
                sObj.Phy=Int32.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter your Chemistry Marks: ");
                sObj.Chem=Int32.Parse(Console.ReadLine());
                
                System.Console.WriteLine("Enter your Mathematics Marks: ");
                sObj.Maths=Int32.Parse(Console.ReadLine());

            }
            catch(InvalidMarksException e)
            {
                Console.ForegroundColor=ConsoleColor.Red;
                System.Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.ForegroundColor=ConsoleColor.Red;
                System.Console.WriteLine(e.Message);
            }
            
            Console.ForegroundColor=ConsoleColor.White;

        }

        public int CalcTotal()
        {
            sObj.Total = sObj.Phy + sObj.Chem + sObj.Maths;
            return sObj.Total;
        }
        public float CalcAverage()
        {
            sObj.Perc = (float)sObj.Total / 3;
            return sObj.Perc;
        }

        public void CalcResult(out int myTotal, out float myPerc)
        {
            myTotal=sObj.Phy+sObj.Chem+sObj.Maths;
            myPerc=(float)myTotal/3;
        }
    }
}