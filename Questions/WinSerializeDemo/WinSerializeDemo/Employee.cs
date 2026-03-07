using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSerializeDemo
{
    [Serializable]
    public class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        [NonSerialized]
        int sal;
        public int Salary
        {
            get { return sal; }
            set { sal = value; }
        }
    }
}
