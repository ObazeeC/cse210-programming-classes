using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering! This is the OnlineOrdering Project.");
        
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
        Console.WriteLine(pro.GetTotalCostOfProduct());
     


    }
}