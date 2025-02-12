using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("The Eternal Quest! This is the EternalQuest Project.");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("[x]");
        */
        GoalManager manager = new();
        string input = "";
       
       while(true)
       {
        manager.Start();
        input = Console.ReadLine();
        switch(input)
        {
            case "1":
            manager.CreateGoal();
            break;

            case "2":
            manager.ListGoalDetails();
            break;

            case "3":
            manager.SaveGoals();
            break;

            case "4":
            manager.LoadGoals();
            break;

            case "5":
            manager.RecordEvent();
            break;

            case "6":
            Console.WriteLine("Goodbye!!!");
            return;

            default:
            Console.WriteLine("Invalid input. Enter 1 - 6");
            break;

        }
       }
        

        
    }
}