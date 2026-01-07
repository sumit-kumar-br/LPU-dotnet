using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPU_Common
{
    public interface IRepo<T>
    {
        //CRUD
        //C-Create
        //R-Read
        //U-Update
        //D-Delete
        List<T> ShowAll();
        T ShowDetailsByID(int id);
        bool AddDetails(T obj);
        bool UpdateDetails(int id, T obj);
        bool DeleteDetails(int id);
    }
}
