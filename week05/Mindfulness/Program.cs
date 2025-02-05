using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.Write("");
       /*
        Thread.Sleep(1500);
        Console.Write("\b \b"); // Erase the + character
        Thread.Sleep(500);
        Console.Write("-"); // Replace it with the - character
        */
        string input = "";
        
        while(true)
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            switch(input)
            {
                case "1":
                break;
            

            
                case "2":
                break;
            

            
                case "3":
                break;
            

            
                case "4":
                return;
                default:
               Console.WriteLine("Invalid please enter between 1 - 4 ");
               break;
            }
        }


    }
}