using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***Hello World! This is the Mindfulness Project.***");
        Console.Write("");
       /*
        Thread.Sleep(1500);
        Console.Write("\b \b"); // Erase the + character
        Thread.Sleep(500);
        Console.Write("-"); // Replace it with the - character
        */
        string input = "";
       // Activity s = new("breathing", "Description", 3);
    
        
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
                 int time = 0;
                 string activity = "Breathing";
                 BreathingActivity b = new(activity,"This activity will help you relax by walking your through breathing in and out slowly. Clear you mind and focus on your breathing", time);
                 Console.WriteLine();
                 Console.WriteLine($"Welcome to the {activity} Activity. ");
                 b.DisplayStartingMessage();
                 Console.WriteLine();
                 Console.Write("How long, in seconds would you like for your session?");
                 string UserInput = Console.ReadLine();
                 //int timeInSec = int.Parse(UserInput);
                 time = int.Parse(UserInput);
                 Console.Clear();
                 Console.WriteLine("Get ready...");
                 b.ShowSpinner(10) ;
                 DateTime startTime = DateTime.Now;
                 DateTime endTime = startTime.AddSeconds(time);
                 Console.Clear();
                 while(DateTime.Now < endTime)
                 {
                   b.Run();
                 }
                 Console.WriteLine("Done!!!");
                 Console.WriteLine($"You have completed {time} seconds exercise.");
                 b.ShowSpinner(10);
                break;
            
                case "2":
               ListingActivity L = new("","",5);
               Console.WriteLine();
                 
                 L.DisplayStartingMessage();
                 Console.WriteLine();
                 Console.Write("How long, in seconds would you like for your session?");
                  UserInput = Console.ReadLine();
                 //int timeInSec = int.Parse(UserInput);
                 time = int.Parse(UserInput);
                 Console.Clear();
                 Console.WriteLine("Get ready...");
                 L.ShowSpinner(10) ;
                
                 Console.Write("You may begin in : ");
                  L.ShowCountDown(6);
                  startTime = DateTime.Now;
                  endTime = startTime.AddSeconds(time);
                 Console.Clear();
                 L.GetRandomPrompt();
                 Console.WriteLine("You may begin:");
                 while(DateTime.Now < endTime)
                 {
                   L.Run();
                 }
                 Console.WriteLine("Weldone!!!");
                 //int total = L.GetCount
                 Console.WriteLine($"You have listed {L.GetCount()} item ");
               //L.GetRandomPrompt();

               
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