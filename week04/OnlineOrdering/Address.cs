using System;
using System.Reflection.Metadata.Ecma335;

public class Address
{
    private string _street = "";
    private string _city = "";
    private string _state = "";
    private string _country ="";

// Create a constructor for the address that accepts four paramentals
// This way we are guarantee to know the country
public Address(string street, string city, string state, string country)
{
   _street = street;
   _city = city;
   _state = state;
   _country = country;
}

// Create getters for the private variables


    public bool IsInUSA()
    {
        /*
        bool USA = false;
        if(_country == "USA" || _country == "United States")
        { 
         USA = true;
        }
        else
        {
            USA = false;
        }

        return USA;*/
        return _country.ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return _street + ", "  +   _city + "\n" + _state +"\n" + _country;
    }
}