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
       List<Product> product01 = new List<Product>
       {
          new Product("Samsung", 25, 6.3, 2),
          new Product("Iphone", 977, 3, 5)
       };
       Order order01 = new(product01,customer01);
       Console.WriteLine("***Order 01 Packing Label*** ");
       /*foreach(var product in product01)
       {
         Console.WriteLine(product.GetPackingLabel());
       }*/
       Console.WriteLine(order01.GetPackingLabel());
       Console.WriteLine();
       Console.WriteLine("***Order 01 ShippingLabel*** ");
       Console.WriteLine(order01.GetShippingLabel());
       Console.Write("Total Cost: ");
       Console.WriteLine(order01.GetToTalCostOfOrder());

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