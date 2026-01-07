using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPropertyDemo
{
    internal class PrimeCustomer: Customer
    {
        public List<Orders> MyPrimeOrders // write only
        {
            set
            {
                MyOrders = value;
            }
        }
    }
}
