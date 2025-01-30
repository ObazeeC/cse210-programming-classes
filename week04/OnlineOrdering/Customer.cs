using System;
public class Customer
{
    private string _name = "";
   // private Address _address = new();
    private Address _address;

    
    public bool LiveInUnitedState()
    {
    bool InUSA = _address.IsInUSA();
    return InUSA;
    }

}