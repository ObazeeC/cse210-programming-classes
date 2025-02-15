using System;
public class ChecklistGoal :Goal 
{
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;

    public ChecklistGoal(string name, string description, string point, int target, int bonus) :base(name, description, point)
    {
        
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        
    }
    public  override bool IsComplete()
    {
       return true; // 
    }

    public override string GetDetailsString()
    {
        string name = GetGoalName();
        string description = GetGoalDescription();
        string points = GetGoalPoints();
        string goal = $"[ ] ({name} {description}  {points}) -- Currently completed {_amountCompleted}/{_target}";
        return goal;
    }
    public override string GetStringRepresentation()
    {
       
        return "";
    }
}