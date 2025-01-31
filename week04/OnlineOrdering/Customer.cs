using System;
public class Customer
{
    private string _name = "";
   // private Address _address = new();
    private Address _address ;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        
    }
  
    
    public bool LiveInUnitedState()
    {
    bool InUSA = _address.IsInUSA();
    return InUSA;
    }

    public string GetShippingLabel002()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }



}