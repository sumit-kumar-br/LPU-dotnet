using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPropertyDemo
{
    internal class Customer
    {
        List<Orders> orderList;
        public Customer()
        {
            orderList = new List<Orders>();
        }
        
        public int CustID { get; set; }
        public string Name { get; set; }
        public Address BillingAddr { get; set; }
        public Address ShippingAddr { get; set; }
        public List<Orders> MyOrders
        {
            get
            {
                return orderList;
            }
            protected set
            {
                orderList = value;
            }
        }
    }
}
