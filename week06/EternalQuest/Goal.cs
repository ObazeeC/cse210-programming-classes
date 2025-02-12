using System;
public class Goal
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

    

}