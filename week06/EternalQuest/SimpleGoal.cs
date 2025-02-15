using System;
public class SimpleGoal : Goal 
{
    private bool _isComplete ;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        
    }
    public  override bool IsComplete()
    {
       return true; // 
    }

    public override string GetStringRepresentation()
    {
        /*
        string name = GetGoalName();
        string description = GetGoalDescription();
        string points = GetGoalPoints();
      //  Console.WriteLine($"[] goal Information: {name} {description} {points}" );
        return $"[] goal Information: {name} {description} {points}";
        */
        return "";
    }
}