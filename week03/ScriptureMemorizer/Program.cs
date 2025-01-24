using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scripture Memorizer! This is the ScriptureMemorizer Project.");

        Reference ref1 = new Reference("John", 3, 4);
        string text = "For God so love the word that He gave His only begotten ...";
        Scripture scripture = new Scripture(ref1, text);
         
        Console.Write("");
        ref1.GetDisplayTextOne();
        //scripture.GetDisplayText();
        Console.WriteLine(scripture);
        

        
    }
}