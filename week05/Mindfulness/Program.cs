using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***Hello World! This is the Mindfulness Project.***");
        Console.Write("");
       
        string input = "";
        int time = 0;
       
        
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
                 
                 string activity = "Breathing";
                 BreathingActivity b = new(activity, time);
                 Console.WriteLine();
                 Console.WriteLine($"Welcome to the {activity} Activity. ");
                 b.DisplayStartingMessage();
                 Console.WriteLine();
                 Console.Write("How long, in seconds would you like for your session?");
                 string UserInput = Console.ReadLine();
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
                 activity = "Listing Activity";
                 ListingActivity listing = new(activity,time);
                 Console.WriteLine();
                 Console.WriteLine($"Welcome to the {activity} . ");
                 listing.DisplayStartingMessage();
                 Console.WriteLine();
                 Console.Write("How long, in seconds would you like for your session?");
                 UserInput = Console.ReadLine();
               
                 time = int.Parse(UserInput);
                 Console.Clear();
                 Console.WriteLine("Get ready...");
                 listing.ShowSpinner(10) ;
                
                 Console.Write("You may begin in : ");
                 listing.ShowCountDown(6);
                 startTime = DateTime.Now;
                 endTime = startTime.AddSeconds(time);
                 Console.Clear();

                 Console.WriteLine("List as many response you can to the following prompt: ");
                 listing.GetRandomPrompt();
                 Console.WriteLine("You may begin:");
                 while(DateTime.Now < endTime)
                 {
                   listing.Run();
                 }
                 Console.WriteLine("Weldone!!!");
             
                 Console.WriteLine($"You have listed {listing.GetCount()} item ");
                 listing.ShowSpinner(10) ;
                 Console.Clear();
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