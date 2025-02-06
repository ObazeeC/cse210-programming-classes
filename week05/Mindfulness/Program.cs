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
        Activity s = new("breathing", "Description", 3);
    
        
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
             
                //Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear you mind and focus on your breathing");
                Console.WriteLine("");
                Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear you mind and focus on your breathing");
                Console.WriteLine("");
                s.ShowSpinner();
                //Console.WriteLine("How long, in seconds would you like for your session?");
                //string Userinput = Console.ReadLine();
                //int timeInSec = int.Parse(Userinput);
                //s.ShowSpinner(timeInSec);
               // s.ShowCountDown(3);
                
               // s.ShowSpinner(timeInSec);
               
                
                break;
            

            
                case "2":
               // Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recongnize the power you have and how you can use it in others aspect of your life. ");
                break;
            

            
                case "3":
               // Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you ca in a certain area.");
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