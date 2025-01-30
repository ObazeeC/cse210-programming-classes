using System;
public class Product
{
   private string _name = "";
   private string _id = "";
   private int _price = 0;
   private int _quantity = 0; 


// Constructor that takes two parameter, the name and the ID
public Product(string name, string id)
{
    _name = name;
    _id = id;
}


// Getters and Setters
public int SetPrice(int price)
{
    _price = price;
    return _price;
}

public int SetQuantity(int quantity)
{
    _quantity = quantity;
    return _quantity;
}

public int GetPrice()
{
    return _price;
}

public int GetQuantity()
{
    return _quantity;
}

   public int GetTotalCostOfProduct()
   {
    int totalCost = 0;
    totalCost = _price * _quantity;
    return totalCost;
   }
}