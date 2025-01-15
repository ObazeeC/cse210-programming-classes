using System;
using System.Collections.Generic;
public class PromptGenerator 
{
  public Random random = new Random ();
  public List<string> _prompt = new List<string>()
  { "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "Would you like to live a day like today in the future?",
    "Do you feel you moved one step closer to your goal today ?",
    "Are you proud of all the decisions you made to today ?",
    "Did you lift anyone up ?",
    "Is there any chance that you have offended anyone on your way?",
    "What angered you the most today?",
    "What made you smile the most today ?",

  };
  
  public string GetRandomPrompt()
  {
    int index = random.Next(_prompt.Count);
    return _prompt[index];
  }
   
}