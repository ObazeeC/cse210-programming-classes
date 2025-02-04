using System;
public class WrittingAssignment : Assignment
{
    private string _title = "";

    public WrittingAssignment(string studentName,string problems, string title) : base(studentName, problems)
    {
        _title = title;
    }

    public string GetWrittingInformation()
    {
        //return $"{GetStudentName()} - {GetTopic()}\n {_title}";
        return $"{_title} by {GetStudentName()}";
    }
}