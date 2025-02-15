using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("The Eternal Quest! This is the EternalQuest Project.");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("[x]");
        
        GoalManager manager = new();
       /* string simple = "";
        string description = "";
        string points = "";
        string input = "";
       manager.DisplayPlayerInfo();*/
       //string start = Console.ReadLine();
       string input = "";
       manager.DisplayPlayerInfo();
       
       while(true)
       {
        manager.Start();
       input = Console.ReadLine();
        switch(input)
        {
            case "1":
            Console.WriteLine("create");
            Console.Clear();
            manager.CreateGoal();
            //Console.Write("Which type of Goal do you want to create ");
           // string chooseGoal = Console.ReadLine();
          /*
            switch(chooseGoal)
            {
                case "1":
                Console.Clear();
                Console.WriteLine("***Welcome to simple Goal***");
                SimpleGoal s = new(simple, description, points);
                Console.WriteLine("What is the name of the goal");
                simple = Console.ReadLine();

                
                Console.WriteLine("What is the description of the goal");
                description = Console.ReadLine();

                Console.WriteLine("How many points are associated with the goal");
                points = Console.ReadLine();
                int numberPoints = int.Parse(points);
                Console.WriteLine($"The {simple}, description : {description} points : {points}");
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
                

            }*/
            break;

            case "2":
            Console.WriteLine("List");
            manager.ListGoalDetails();
            break;

            case "3":
            Console.WriteLine("Save");
            manager.SaveGoals();
            break;

            case "4":
            Console.WriteLine("Load");
            manager.LoadGoals();
            break;

            case "5":
            Console.WriteLine("Record");
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