using System;
public class Customer
{
    private string _name = "";
   // private Address _address = new();
   private Address _address;

    
    public bool LiveInUnitedState()
    {
    bool InU_S = _address.IsInUSA();
    return InU_S;
    }

}