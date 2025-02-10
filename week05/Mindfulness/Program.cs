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
                    b.DisplayStartingMessage();
                    Console.Clear();
                    Console.WriteLine($"Welcome to the {activity} Activity. ");
                    Console.WriteLine();
                    b.DisplayStartingMessage();
                    Console.WriteLine();
                    Console.Write("How long, in seconds would you like for your session : ");
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
                    b.DisplayEndingMessage();
                    b.ShowSpinner(6);
                    Console.WriteLine($"You have completed {time} seconds exercise.");
                    b.ShowSpinner(6);
                    Console.Clear();
                    
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
                    listing.GetRandomPrompt();
                    Console.WriteLine("You may begin:");
                    while(DateTime.Now < endTime)
                    {
                    listing.Run();
                    }
                    listing.DisplayEndingMessage();
                    listing.ShowSpinner(6);
                    Console.WriteLine($"You have completed {time} seconds exercise.");
                    listing.ShowSpinner(6);
                    Console.Clear();
                    
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
                    //test getrandom prompt
                    Console.WriteLine();
                    Console.WriteLine("Consider the following prompt:");
                    Console.WriteLine();
                    Console.WriteLine();
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
                    //reflection.DisplayQuestion();
                

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