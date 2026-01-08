// Demo of collections

class GenericCollectioDemo
{
    class Product
{
    public int ProdID { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
}
    public static void ListDemo()
    {
        List<Product> prodList = new List<Product>()
            {
                new Product(){ProdID=101,Name="DummyProd",Price=150},
                new Product(){ProdID=102,Name="Fastrack Wrist Watch",Price=7500},
                new Product(){ProdID=103,Name="Logitech Mouse",Price=750},
                new Product(){ProdID=104,Name="Paracetamol",Price=15},
            };
        //1. Create -Add Data to List
        Product p1 = new Product();
        Console.Write("Enter Product ID :");
        p1.ProdID = Int32.Parse(Console.ReadLine());
        Console.Write("Enter Product Name:");
        p1.Name = Console.ReadLine();
        Console.Write("Enter Product Price :");
        p1.Price = Int32.Parse(Console.ReadLine());
        //Passing Product to List
        prodList.Add(p1);
        //Update The Product
        //step 1.Search the Product which u want to Update.
        Console.Write("Enter Product ID to Update:");
        int id = Int32.Parse(Console.ReadLine());
        Product prodFound = prodList.Find(p => p.ProdID == id);
        if (prodFound != null)
        {
            Console.Write("Enter New  Product Name :");
            prodFound.Name = Console.ReadLine();
            Console.Write("Enter New  Product Price :");
            prodFound.Price = Int32.Parse(Console.ReadLine());
        }
        //Read Data from List
        Console.Write("Enter Product ID for Search:");
        int pid = Convert.ToInt32(Console.ReadLine());
        Product p = prodList.Find(c => c.ProdID == pid);
        if (p != null)
        {
            Console.WriteLine($"ID {p.ProdID}\t Name :{p.Name}");
        }
        //Delete on List
        Console.Write("Enter Product ID for Delete:");
        int pid1 = Int32.Parse(Console.ReadLine());
        Product pO1 = prodList.Find(c => c.ProdID == pid1);
        if (pO1 != null)
        {
            prodList.Remove(pO1);
        }
    }
}
