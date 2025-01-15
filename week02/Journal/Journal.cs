using System;
using System.Collections.Generic;

public class Journal
{
    //PromptGenerator p2 = new PromptGenerator();
  public List<Entry> _entries = new List<Entry>();

   
  public void AddEntry(Entry newEntry)
  {
   
   
    //newEntry._date = DateTime.Now.ToString();
   // newEntry._promptText = p2.GetRandomPrompt();
  //  string prompt = newEntry._promptText;
   // Console.WriteLine(prompt);
   // newEntry._entryText = Console.ReadLi ne();
   
    _entries.Add(newEntry);

    
  }

public void DisplayAll()
{
    foreach(Entry x in _entries)
    {
         x.DisplayEntry();
        //Console.WriteLine(x._date);
        //Console.WriteLine(x._promptText);
        //Console.WriteLine(x._entryText);
    }
}
}



