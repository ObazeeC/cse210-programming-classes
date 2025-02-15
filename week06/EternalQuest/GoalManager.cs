using System;
public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;
       public GoalManager()
    {

    }

    public void Start()
    {
       //Console.WriteLine();
       
       Console.WriteLine("Menu Options: ");
       Console.WriteLine("1. Create New Goal");
       Console.WriteLine("2. List Goals");
       Console.WriteLine("3. Save Goals");
       Console.WriteLine("4. Load Goals");
       Console.WriteLine("5. Record Event");
       Console.WriteLine("6. Quite");
       Console.Write("Select a choice from the menu: ");
       //Console.Write("Which type of Goal do you want to create ");
      // string start = Console.ReadLine();



       
    }

    public void DisplayPlayerInfo()
    {
       Console.WriteLine("You have no point yet");
       Console.WriteLine();
    }
    public void ListGoalDetails()
    {

    }
    public void ListGoalNames()
    {
       Console.WriteLine("The types of Goals are :");
       Console.WriteLine("1. Simple Goal");
       Console.WriteLine("2. Eternal Goal");
       Console.WriteLine("3. Checklist Goal");
       Console.WriteLine("");
    }
    public void CreateGoal()
    {
     ListGoalNames();
     Console.WriteLine("");
     Console.Write("Which type of Goal do you want to create ");
            string chooseGoal = Console.ReadLine();
            int goal = int.Parse(chooseGoal);
                
                string simple = "";
                string description = "";
                string points = "";
               
                int target = 0;
                int bonus = 0;
               
                /*
               if(goal == 1)
               {
                   Console.WriteLine("What is the name of the goal");
                   simple = Console.ReadLine();

                   Console.WriteLine("What is the description of the goal");
                   description = Console.ReadLine();

                     Console.WriteLine("How many points are associated with the goal");
                     points = Console.ReadLine();
                     int numberPoints = int.Parse(points);
                      
               }
               else if ( goal == 2)
               {

               }
               else if( goal == 3)
               {

               }
               else
               {
                  Console.WriteLine("Choose between 1-3 ");
               }*/
           
            switch(chooseGoal)
            {
               
                case "1":
               
                Console.Clear();
                Console.WriteLine("***Welcome to simple Goal***");
                
                Console.WriteLine("What is the name of the goal");
                simple = Console.ReadLine();

                Console.WriteLine("What is the description of the goal");
                description = Console.ReadLine();

                Console.WriteLine("How many points are associated with the goal");
                points = Console.ReadLine();
                int numberPoints = int.Parse(points);
                //Console.WriteLine($"The {simple}, description : {description} points : {points}");
                Console.WriteLine();
                //_goals.Add(simple01);
                
                SimpleGoal simple01 = new(simple, description, points);
                 _goals.Add(simple01);

                break;

                case "2":
                
                Console.Clear();
                Console.WriteLine("***Welcome to Eternal Goal***");
                
                Console.WriteLine("What is the name of the goal");
                simple = Console.ReadLine();

                Console.WriteLine("What is the description of the goal");
                description = Console.ReadLine();

                Console.WriteLine("How many points are associated with the goal");
                points = Console.ReadLine();
                numberPoints = int.Parse(points);
                //Console.WriteLine($"The {simple}, description : {description} points : {points}");
                Console.WriteLine();
                 EternalGoal eternal = new(simple, description, points);
                  _goals.Add(eternal);
                break;
             
                case "3":
                Console.Clear();
                Console.WriteLine("***Welcome to CheckList Goal***");
               
                Console.WriteLine("What is the name of the goal");
                simple = Console.ReadLine();

                Console.WriteLine("What is the description of the goal");
                description = Console.ReadLine();

                Console.WriteLine("How many points are associated with the goal");
                points = Console.ReadLine();
                numberPoints = int.Parse(points);
                //Console.WriteLine($"The {simple}, description : {description} points : {points}");
                Console.Write("How many times does this goal need to be accomplished for a bonus ? : ");
                string enterTarget = Console.ReadLine();
                target = int.Parse(enterTarget);

                Console.Write("What is the bonus for accomplishing it that many times?: ");
                String enterBonus = Console.ReadLine();
                bonus = int.Parse(enterBonus);
                Console.WriteLine();
               ChecklistGoal checkL = new(simple, description, points, target, bonus);
                _goals.Add(checkL);

                break;
            }
            
    
      

    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {
     foreach(Goal x in _goals)
     {
      Console.WriteLine(x.GetDetailsString());
     }
    }
}