using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Encapsulation! This is the Fractions Project.");
        Console.WriteLine("---------------------------------------------");

        Fraction f1 = new ();
        f1.GetDenominator();
        f1.SetDenominator(2);
   
        
        Fraction f2 = new(6 ,8);
         Console.WriteLine(f2.GetNumerator());
         f2.SetNumerator(3);
         Console.WriteLine("---------------------------------------------");
         f2.GetFractionString();
     
        Console.WriteLine("f3"); 
        Fraction f3 = new(3,4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine("f4"); 
        Fraction f4 = new(); 
        f4.SetNumerator(1);
        f4.SetDenominator(3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());


    }
}