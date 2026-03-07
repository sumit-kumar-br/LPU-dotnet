using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateDemo
{
    public interface IRepo<T>
    {
        public bool Add(Product obj);
        public Product SearchByID(int id);
    }
}
