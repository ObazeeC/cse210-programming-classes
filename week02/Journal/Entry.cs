using System;

public class Entry

{
    public string _date = "" ; 
    public string _promptText  = "";
    public string _entryText = "";

    // Save other information in the Journal entry

    public void DisplayEntry()
    {
       Console.WriteLine($"Date:{_date} -Prompt:{_promptText}\n{_entryText}");
    }
}