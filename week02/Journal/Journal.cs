using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    //PromptGenerator p2 = new PromptGenerator();
  public List<Entry> _entries = new List<Entry>();

   
// This line of code works well, passing Entry as Parameter
/*  public void AddEntry(Entry newEntry)
  {
   
   
    //newEntry._date = DateTime.Now.ToString();
   // newEntry._promptText = p2.GetRandomPrompt();
  //  string prompt = newEntry._promptText;
   // Console.WriteLine(prompt);
   // newEntry._entryText = Console.ReadLine();
   
    _entries.Add(newEntry);
    
  }
  */


// New Approach after tutor guide. Works fine too
public void AddEntry()
{
  PromptGenerator prompt = new();

  string promptUser = prompt.GetRandomPrompt();
  Console.WriteLine(promptUser);
  Console.Write(">>");
  string userInput = Console.ReadLine();
  Console.WriteLine("Enter Quotes/Inspirational Message");
  Console.Write(">>");
  string userQuote = Console.ReadLine();
  Entry entry = new ();
  entry._date = DateTime.Now.ToString();
  entry._promptText = promptUser;
  entry._entryText = userInput;
  entry._quotes = userQuote;
  _entries.Add(entry);
}

public void WriteSummary()
{
Console.WriteLine("Write a summary of your day");
Console.Write(">>");
string userInput = Console.ReadLine();
Console.WriteLine("Enter Quotes/Inspirational Message");
Console.Write(">>");
string userQuote = Console.ReadLine();
Entry entry = new();
entry._date = DateTime.Now.ToString();
entry._summary = userInput;
entry._quotes = userQuote;
_entries.Add(entry);

}
public void DisplayAll()
{
    foreach(Entry x in _entries)
    {
         Console.WriteLine();
         x.DisplayEntry();
        //Console.WriteLine(x._date);
        //Console.WriteLine(x._promptText);
        //Console.WriteLine(x._entryText);
    }
}

public void SaveToFile(string fileName)
{
 using (StreamWriter myWriter = new StreamWriter (fileName))
 {
    foreach(Entry x in _entries)
    {
        myWriter.WriteLine($"{x._date}|{x._promptText}|{x._entryText}|{x._quotes} |{x._summary}");
       // myWriter.WriteLine(x._promptText);($"Date: {_date} -Prompt: {_promptText} \n{_entryText}");
       // myWriter.WriteLine(x._entryText);
    }
 }
}

public void LoadFromFile(string fileName)
 {
    // Read all files to an array of strings
    string [] lines = System.IO.File.ReadAllLines(fileName); 

    // Iterate though each strings and split into parts by a seperator |
    foreach (string x in lines)
    {
     string[] parts = x.Split('|');

     // Create new entry object and add the splitted strings, accessing them by index
     Entry entry = new Entry();

     entry._date = parts[0];
     entry._promptText = parts[1];
     entry._entryText = parts[2];
     entry._quotes = parts[3];
     entry._summary = parts[4];
     // Add entry to list
     _entries.Add(entry);
      
    }
    /*_Attempts to read line by line

    using (StreamReader myReader = new StreamReader(fileName))
    {
       string line;
        while ((line = myReader.ReadLine()) != null)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3) // Ensures the line has the correct number of parts
            {
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2]
                };
                _entries.Add(entry);
            }
      
        }
    
    }*/
  }
  
}



