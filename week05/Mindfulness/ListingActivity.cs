using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>()
    {
       "** What made the best part of your day **",
       "** How did you see the hand of the Lord in your life this month ? **",
       "** When have you felt the Holy Ghost this month ? **",
       "** Are you proud of all the decision you have made this month ? **",
       "** What are some strong emotion you have felt this past weeks **",
       "** What are some little things that made you smile this month **",
       "** What kind of places do you like going to reflect and reset **"
    };
    private List<string> _prompts02;

public ListingActivity(string name, int duration) :base (name, duration)
{

    _startingMessage = "This activity will help you reflect on the good things in your life by havng you list as many thing as you can in a certain area."; 
    _prompts02 = new(_prompts);

}
public Random random = new();
private List<string>response ;
/*
public void GetRandomPrompt() // change string to void and comment out return
{
    int index = random.Next(_prompts.Count);
    Console.WriteLine(_prompts[index]);
}*/
public string GetRandomPrompt()
{
    if(_prompts02.Count == 0)
    {
        _prompts02 = new(_prompts); // This is suppose to create a new list  
    }
    int index = random.Next(_prompts02.Count);
    string prompt = _prompts02[index];
    _prompts02.RemoveAt(index); // Remove the selected prompt from the list
    return prompt;
}
public void GetListFromUser()
{
    response = new();
    string userInput;
    //Console.WriteLine("You may begin:");
     Console.Write("> ");
    
       userInput = Console.ReadLine();
        response.Add(userInput);
        _count += response.Count;
    
}
public int GetCount()
{
    return _count;
}
public void Run()
{
 
  GetListFromUser();
}
}