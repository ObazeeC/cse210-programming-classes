using System;

public class Entry

{
    public string _date = "" ; 
    public string _promptText  = "";
    public string _entryText = "";
    public string _quotes = "";
    public string _summary = "";

    // Save other information in the Journal entry

    public void DisplayEntry()
    {
       Console.WriteLine($"Date:{_date} -Prompt:{_promptText}\n{_entryText} \n Quotes/Inspiration: {_quotes} \n{_summary}");
    }
}