using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPU_Common
{
    interface IEmployee<T>:IRepo<T>
    {
        List<T> ShowAllFemaleEmployees();
        List<T> ShowAllMaleEmployees();
        List<T> ShowAllEmployeesWithAgeAbove40();
    }
}
