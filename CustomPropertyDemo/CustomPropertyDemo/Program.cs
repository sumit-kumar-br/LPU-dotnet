using System;
namespace CustomPropertyDemo
{
    //struct Customer1 
    //    // value type in Csharp; stored in stack; ligtweight; no need of inheritance, encapsulation, etc....
    //{
    //    //    public int ID { get; set; }
    //    //    public string Name { get; set; }
    //    int id;
    //    string name;
    //    public Customer1(int id1, string nm)
    //    {
    //        id = id1;
    //        name = nm;1
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            // Init Customer Object
            Customer custObj = new Customer();
            
            custObj.CustID = 101;
            custObj.Name = "Alok";
            // init the shipping address
            custObj.ShippingAddr = new Address();
            custObj.ShippingAddr.FlatNo = 1802;
            custObj.ShippingAddr.BuildingName = "Sky Tower";
            custObj.ShippingAddr.Street = "Lane 1";
            custObj.ShippingAddr.Locality = "Wakad";
            custObj.ShippingAddr.City = "Pune";

            // 1 Customer can have many orders
            custObj.MyOrders = new List<Orders>()
            {
                new Orders{ OrderID=1124, OrderDate = new DateTime(2001,12,22), Amount=14000},
                new Orders{ OrderID=2076, OrderDate = new DateTime(2002,3,12), Amount=24000},
                new Orders{ OrderID=8540, OrderDate = new DateTime(2002,10,12), Amount=4000},
                new Orders{ OrderID=12122, OrderDate = new DateTime(2008,1,26), Amount=2000}
            };

        }
    }
}