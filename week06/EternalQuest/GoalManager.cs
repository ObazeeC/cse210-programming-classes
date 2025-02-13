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
       



       
    }

    public void DisplayPlayerInfo()
    {
       Console.WriteLine("You have no point yet");
       Console.WriteLine();
    }
    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {
       Console.WriteLine("The types of Goals are :");
       Console.WriteLine("1. Simple Goal");
       Console.WriteLine("2. Eternal Goal");
       Console.WriteLine("3. Checklist Goal");
       Console.WriteLine("");
    }
    public void CreateGoal()
    {
     ListGoalDetails();
     

    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }
}