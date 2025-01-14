using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Boolean choice = false;
        Console.WriteLine("Abstraction! This is the Journal Project.");
        Console.WriteLine("*****************************************");
    do
    {

    
        Console.WriteLine("");
        Console.WriteLine("Please select one of the following options ?");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine(" 5. Quit");
        Console.Write("What will you like to do ?");
        userInput = Console.ReadLine();

        switch(userInput)
        {
            case "1":
            break;

            case "2":
            break;

            case "3":
            break;

            case "4":
            break;

            case "5":
            choice = true;
            break;
        }

    }while(!choice);

    }
}