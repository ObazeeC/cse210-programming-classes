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
       manager.DisplayPlayerInfo();
       while(true)
       {
        
        manager.Start();
        input = Console.ReadLine();
        switch(input)
        {
            case "1":
            Console.Clear();
            manager.CreateGoal();
            Console.Write("Which type of Goal do you want to create ");
            string chooseGoal = Console.ReadLine();

            switch(chooseGoal)
            {
                case "1":
                Console.Clear();
                Console.WriteLine("***Welcome to simple Goal***");
                Console.WriteLine();
                break;

                case "2":
                Console.Clear();
                Console.WriteLine("***Welcome to Eternal Goal***");
                Console.WriteLine();
                break;
             
                case "3":
                Console.Clear();
                Console.WriteLine("***Welcome to CheckList Goal***");
                Console.WriteLine();
                break;

            }
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