using System;
using System.Reflection.Metadata.Ecma335;
public abstract class Goal
{
    private string _shortName = "";
    private string _description = "";
    private string _points = ""; // isn't this suppose be int 

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
public string GetGoalName()
{
    return _shortName;
}

public string GetGoalDescription()
{
    return _description;
}

public string GetGoalPoints()
{
    return _points;
}
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        // return the details of a goal that could be shown in a list
        // include the checkbox,the short name, the description
        string goal = $"[ ] {_shortName} {_description}  {_points}";
        return goal;
        
    }
    public abstract string GetStringRepresentation();

}