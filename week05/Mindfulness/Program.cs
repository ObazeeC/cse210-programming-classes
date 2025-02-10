using System;
using System.Runtime.CompilerServices;

/*
  For creativity I have added:
 1. Keeping a log of how many times activities were performed.
 2. Making sure no random prompts/questions are selected until they have all been used at least once in that session.
*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***Hello World! This is the Mindfulness Project.***");
        Console.Write("");
       Activity a = new("",1);
        string input = "";
        int time = 0;
        int breathingCount = 0;
        int listingCount = 0;
        int reflectionCount = 0;
       
        
        while(true)
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start listing activity");
            Console.WriteLine("3. Start reflection activity");
            Console.WriteLine("4. Display Log");
            Console.WriteLine("5. Quit"); 
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            switch(input)
            {
                case "1":
                 
                    string activity = "Breathing";
                    BreathingActivity breathing = new(activity, time);
                    Console.WriteLine();
                    breathing.DisplayStartingMessage();
                    Console.Clear();
                    Console.WriteLine($"Welcome to the {activity} Activity. ");
                    Console.WriteLine();
                    breathing.DisplayStartingMessage();
                    Console.WriteLine();
                    Console.Write("How long, in seconds would you like for your session : ");
                    string UserInput = Console.ReadLine();
                    time = int.Parse(UserInput);
                    Console.Clear();
                    Console.WriteLine("Get ready...");
                    breathing.ShowSpinner(10) ;
                    DateTime startTime = DateTime.Now;
                    DateTime endTime = startTime.AddSeconds(time);
                    Console.Clear();
                    while(DateTime.Now < endTime)
                    {
                    breathing.Run();
                    }
                    breathing.DisplayEndingMessage();
                    breathing.ShowSpinner(6);
                    Console.WriteLine($"You have completed {time} seconds exercise.");
                    breathing.ShowSpinner(6);
                    Console.Clear();
                    breathingCount ++;
                break;
            
                case "2":
                    activity = "Listing Activity";
                    ListingActivity listing = new(activity,time);
                    Console.WriteLine();
                    listing.DisplayStartingMessage();
                    Console.Clear();
                    Console.WriteLine($"Welcome to the {activity} Activity. ");
                    Console.WriteLine();
                    listing.DisplayStartingMessage();
                    Console.WriteLine();
                    Console.Write("How long, in seconds would you like for your session : ");
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
                    Console.WriteLine(listing.GetRandomPrompt());
                    Console.WriteLine("You may begin:");
                    while(DateTime.Now < endTime)
                    {
                    listing.Run();
                    }
                    Console.WriteLine($"You have listed {listing.GetCount()}");
                    listing.DisplayEndingMessage();
                    listing.ShowSpinner(6);
                    Console.WriteLine($"You have completed {time} seconds exercise.");
                    listing.ShowSpinner(6);
                    Console.Clear();
                    listingCount++;
                break;

                case "3":
                activity = "Reflection";
                    ReflectionActivity reflection = new(activity, time);
                    Console.WriteLine();
                    reflection.DisplayStartingMessage();
                    Console.Clear();
                    Console.WriteLine($"Welcome to the {activity} Activity. ");
                    Console.WriteLine();
                    reflection.DisplayStartingMessage();
                    Console.WriteLine();
                    Console.Write("How long, in seconds would you like for your session : ");
                    UserInput = Console.ReadLine();
                    time = int.Parse(UserInput);
                    Console.Clear();
                    Console.WriteLine("Get ready...");
                    reflection.ShowSpinner(10) ;
                    Console.WriteLine();
                    Console.WriteLine("Consider the following prompt:");
                    Console.WriteLine();
                    reflection.DisplayPrompt();
                    Console.WriteLine("When you have something in mind, press enter to continue");
                    string enter = Console.ReadLine();
                    if(enter == "")
                    {
                        Console.WriteLine("Now ponder on each of the following question as they related to this experience.");
                        Console.Write("You may begin in : ");
                        reflection.ShowCountDown(6);
                        startTime = DateTime.Now;
                        endTime = startTime.AddSeconds(time);
                        Console.Clear();
                         while(DateTime.Now < endTime)
                         {
                             reflection.Run();
                         }
                    }
                    Console.WriteLine();
                    reflection.DisplayEndingMessage();
                    reflection.ShowSpinner(6);
                    Console.WriteLine($"You have completed {time} seconds exercise.");
                    reflection.ShowSpinner(6);
                    Console.Clear();
                    reflectionCount++;
                break;
            
                case "4":
                    Console.Clear();
                    Console.WriteLine($"You have played breathing activity {breathingCount} times");
                    Console.WriteLine($"You have played listing activity {listingCount} times");
                    Console.WriteLine($"You have played reflection activity {reflectionCount} times");
                    a.ShowSpinner(10);
                    Console.Clear();
                    
                 break;
            
                case "5":
                    Console.WriteLine(" << See again soon >>");
                    Console.Write("Program will close in: ");
                    a.ShowCountDown(5);
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!!!");
                return;

                default:
                    Console.WriteLine("Invalid! Please enter between 1 - 5 ");
               break;
            }
        }


    }
}