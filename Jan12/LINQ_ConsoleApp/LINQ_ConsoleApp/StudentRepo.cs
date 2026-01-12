using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ConsoleApp
{
    public class StudentRepo
    {
        static List<Student> studList = null;
        public StudentRepo()
        {
            if(studList == null)
            {
                studList = new List<Student>()
                {
                    new Student(){RollNo=1,Name="Sumit",Gender="Male",Marks=90,Fees=1500},
                    new Student(){RollNo=2,Name="Sam",Gender="Male",Marks=80,Fees=1000},
                    new Student(){RollNo=3,Name="Amit",Gender="Male",Marks=88,Fees=2000},
                    new Student(){RollNo=4,Name="Shreya",Gender="Female",Marks=85,Fees=1800},
                    new Student(){RollNo=5,Name="Supriya",Gender="Female",Marks=90,Fees=1700},
                    new Student(){RollNo=6,Name="Rahul",Gender="Male",Marks=83,Fees=2300},
                };
            }
            
        }
        public List<Student> GetAllStudents()
        {
            return studList;
        }
    }
}
