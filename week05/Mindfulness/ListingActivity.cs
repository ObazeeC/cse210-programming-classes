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

public ListingActivity(string name, int duration) :base (name, duration)
{

    _startingMessage = "This activity will help you reflect on the good things in your life by havng you list as many thing as you can in a certain area."; 

}
public Random random = new();
private List<string>response ;
public void GetRandomPrompt() // change string to void and comment out return
{
    int index = random.Next(_prompts.Count);
  //  return _prompts[index];
    Console.WriteLine(_prompts[index]);
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