using System;
public class Order
{
    private List<Product>_product;
    private Customer _customer;
    

public Order(List<Product> product, Customer customer)
{
    _product = product;
    _customer = customer;
    
    /*
    foreach(var client in _customer)

    {
        if(client.LiveInUnitedState() == true)
        {
            shipmentCost = 5;
        }
        else
        {
            shipmentCost = 5 + 30;
        }
        
    }*/

    
}
    public double GetToTalCostOfOrder()
    {
        double totalCost = 0;
        double shippingCost = 0;
        bool shipment;
        
        foreach(var product in _product)
        {
            totalCost = product.GetTotalCostOfProduct();
        }
        shipment = _customer.LiveInUnitedState();
        if(shipment == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        return totalCost + shippingCost ;
    }

    public string GetPackingLabel()
    {
       // return(GetPackingLabel002();
       string PackingLabel = "";
       foreach(var product in _product)
       {
        PackingLabel = product.GetPackingLabel002();
       }
       return PackingLabel;
    }
    public string GetShippingLabel()
    {
        
       return _customer.GetShippingLabel002();
    }
}