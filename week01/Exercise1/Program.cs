using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName;
        string lastName;
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
       
        Console.Write("What is your first name ? ");
        firstName = Console.ReadLine();


        Console.Write("What is your last name ? ");
        lastName = Console.ReadLine();
        
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}