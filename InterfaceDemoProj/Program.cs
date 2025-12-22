// See https://aka.ms/new-console-template for more information
using InterfaceDemoProj;

Console.WriteLine("Demo on Interfaces");

// IAdd m1 = new MathClass(); // Alok - Add

// IAddSub m2 = new MathClass(); // Riya - Add, Sub

// IAll m3 = new MathClass(); // Rajat - Add, Sub, Prod, Div


// Approach 1
Product pObj = new Product();
pObj.ProdID = 101;
pObj.Name = "Borosil Flask";
pObj.Price = 850;


// Approach 2
// Object Initializer
Product pObj1 = new Product(){ProdID=102,Name="Luxor Marker", Price=25};


// Connection Initializer
List<Product> prodList = new List<Product>()
{
    new Product(){ProdID=101,Name="Pilgrim Moisturizer", Price=550},
    new Product(){ProdID=102,Name="Bellavita Perfume", Price=600},
    new Product(){ProdID=103,Name="HotWheel Toy", Price=400},
    new Product(){ProdID=104,Name="Disney Bowl", Price=250},
    new Product(){ProdID=105,Name="Axcer 90mg", Price=2450},
    new Product(){ProdID=106,Name="Luxor Marker", Price=25},
};

foreach(var item in prodList)
{
    System.Console.WriteLine($"{item.ProdID}\t{item.Name}\t{item.Price}");
}