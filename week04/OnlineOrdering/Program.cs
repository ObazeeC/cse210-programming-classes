using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering! This is the OnlineOrdering Project.");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine();
        //Product pro = new();
       // Order order01 = new();
       Address address01 = new("16 Nosa street", "Benin-City", "Edo State", "Nigeria");
       Customer customer01 = new("Esosa Obazee", address01);
       List<Product>product01 = new List<Product>
       {
          new Product("Samsung", 25, 6.3, 2),
          new Product("Iphone", 977, 3, 5)
       };
       Order order01 = new(product01,customer01);
       Console.WriteLine("***Order 01 Packing Label*** ");
       order01.GetPackingLabel();
       Console.WriteLine();
       Console.WriteLine("***Order 01 ShippingLabel*** ");
       Console.WriteLine(order01.GetShippingLabel());
       Console.Write("Total Cost: ");
       Console.WriteLine(order01.GetToTalCostOfOrder());
       Console.WriteLine();
       
       // Order two
       Address address02 = new("Via Treviso 16", "Milan", "Lombardy", "Italy");
       Customer customer02 = new("Emilio Conte", address02);
       List<Product>product02 = new List<Product>
       {
        new Product("TV set", 032, 200, 1),
        new Product("Iphone", 977, 600, 1),
        new Product("Power bank", 209, 50, 2),
       };
       Order order02 = new(product02, customer02);
       Console.WriteLine("***Order 02 Packing Label*** ");
       order02.GetPackingLabel();
       Console.WriteLine();
       Console.WriteLine("***Order 02 ShippingLabel*** ");
       Console.WriteLine(order02.GetShippingLabel());
       Console.Write("Total Cost: ");
       Console.WriteLine(order02.GetToTalCostOfOrder());
       Console.WriteLine();

       // other three
       Address address03 = new("555 Elm Street", "Springfield", "Idaho", "USA");
       Customer customer03 = new("Smith Junior", address03);
       List<Product>product03 = new List<Product>
       {
        
         new Product("Jordan Sneakers", 101, 4, 10),
         new Product("Hp laptop", 455, 20, 5),
         new("Headset", 345, 20,3),
         new Product("Football", 006, 3, 5),
       };
       Order order03 = new(product03, customer03);
       Console.WriteLine("***Order 03 Packing Label*** ");
       order03.GetPackingLabel();
       Console.WriteLine();
       Console.WriteLine("***Order 03 ShippingLabel*** ");
       Console.WriteLine(order03.GetShippingLabel());
       Console.Write("Total Cost: ");
       Console.WriteLine(order03.GetToTalCostOfOrder());
       Console.WriteLine();




        /*
        //Test the Address and Customer
        string street = "Horizon street";
        string city = "Idaho";
        string state = "Utah";
        string country = "USA";
        Address ad1 = new(street, city, state, country);
        Console.WriteLine(ad1.GetAddress());
        Console.WriteLine(ad1.IsInUSA()); 
        ad1.GetCity();
        
        //Test Product class
        string name = "Esosa Obazee";
        string id = "EO354";
        Product pro = new(name, id);
        pro.SetPrice(3);
        pro.SetQuantity(5);
        Console.Write($"{name}, ID: {id} spent : ");
        Console.WriteLine(pro.GetTotalCostOfProduct());*/
     


    }
}