using System;
public class Activity
{
 private string _activityName = "";
 private string _description = "";
 private int _duration = 0;

 protected string _startingMessage = "";

// constructor
 public Activity(string name, int duration)
  {
    _activityName = name;
 
    _duration = duration;
    
  }
//int timeInSec = 0;
public string GetActivityName()
{
    return _activityName;
}
  // methods
  public void DisplayStartingMessage()
  {  
    Console.WriteLine(_startingMessage);
  
     
     
  }
  public void DisplayEndingMessage()
  {
     Console.WriteLine("Well done!!!");

  }
 // public void ShowSpinner(int seconds)

  //{
    // The waiting interval 
    // here you display useful messages on intervalsss
    // get readt ...
    // breathe in...
    // breathe out :::
   //  Console.WriteLine("Get ready...");
   // for (int i = 5; i > 0; i--) // get a countdown of 5 downwards
   // {
       // Console.Write(i);    // Write out the value of i on same line
      //  Thread.Sleep(2000); // 2000 equals 2 seconds pause
      //  Console.Write("\b \b"); //Overwrite previously written number with new number. back arrow, space, back arrow syntax.  for double digi, use two back arrows and two spaces syntax like this  \b\b  \b\b

        /*
        Console.Write("."); // print ..... while the program is waiting
        Thread.Sleep(2000); 

       // THE SPINNAR LOOP
      //  |/-\/-\| // put this character into a list
        List<string> animationString = new List<string>();

        animationString.Add("|");  // add the character to the list
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");  // note use double back slash to do the back slash character, else you will have error
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\")
        animationString.Add("|")
        
        foreach (string s in animaltionString)
        {
            Console.Write(s);    // Write out the value of i on same line
            Thread.Sleep(2000); // 2000 equals 2 seconds pause
            Console.Write("\b \b"); //Overwrite previously written number with new number. back arrow, space, back arrow syntax.  for double digi, use two back arrows and two spaces syntax like this  \b\b  \b\b

            This animation will run for 8 secs by default.
            Use the Date class to make adjustment
            
            DateTime startTime  = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(10); // How many seconds I want to wait
            
            int  i = 0;
            while(DateTime.Now < endTime)
            {
                  string s = animationString[i];
                  Console.Write(s);
                  Thread.Sleep(1000);
                  Console.Write("\b \b");

                  i++;
                  if(i >= animationString.Count)
                  {
                     i = 0;
                  }             
            }

        }
*/

        
   // }
  // Console.WriteLine("Done");


  //}
  public void ShowSpinner(int timer)
  {
    List <string> spinner = new();
    spinner.Add("|");
    spinner.Add("/");
    spinner.Add("-");
    spinner.Add("\\");
    spinner.Add("|");
    spinner.Add("/");
    spinner.Add("-");
    spinner.Add("\\");
  
   DateTime startTime = DateTime.Now;
   DateTime endTime = startTime.AddSeconds(timer);
   int i = 0;
   while(DateTime.Now < endTime)
   {
        string x = spinner[i];
        Console.Write(x);
        Thread.Sleep(1000);
        Console.Write("\b \b");

        i++;
        
        if(i >= spinner.Count)
        {
            i = 0;
        }


   }

  }
  public void ShowCountDown(int seconds)
  {
    // how long you want to play
   // Console.Write("How long, in seconds would you like for your session?");
    // string duration = Console.ReadLine();
    // seconds = int.Parse(duration);
     //_duration = int.Parse(duration);
     for(int i = 6; i > 0; i--)
     {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
     }
     //Console.WriteLine("Done");

  }
}