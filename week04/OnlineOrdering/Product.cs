using System;
public class Product
{
   private string _name = "";
   private int _id ;
   private double _price = 0;
   private int _quantity = 0; 


// Constructor that takes three parameters
public Product(string name, int id, double price, int quantity)
{
    _name = name;
    _id = id;
    _price = price;
    _quantity = quantity;
}





   public double GetTotalCostOfProduct()
   {
    double totalCost = 0;
    totalCost = _price * _quantity;
    return totalCost;
   }

   // packing label
   public string GetPackingLabel002()
   {
    return $"{_name} [ID: {_id}]";
   }
}