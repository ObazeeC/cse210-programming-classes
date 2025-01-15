using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        //Boolean choice = false;
        Console.WriteLine("Abstraction! This is the Journal Project.");
        Console.WriteLine("*****************************************");
        Entry enter = new Entry();
        PromptGenerator promp01 = new PromptGenerator();
        Journal j1 = new Journal();
   // do
    //{
    while(true)
    {


    

    
        Console.WriteLine("");
        Console.WriteLine("Please select one of the following options");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What will you like to do ?");
        userInput = Console.ReadLine();

        switch(userInput)
        {
            case "1":
            enter._date = DateTime.Now.ToString();
            enter._promptText = promp01.GetRandomPrompt();
            string prompt = enter._promptText;
            Console.WriteLine(prompt);
            enter._entryText = Console.ReadLine();
            j1.AddEntry(enter);
            
          
            /* 
            enn1._date = "21/03/2024";
            enn1._entryText = "Cooking rice and beans";
            enn1._promptText = "When was that ?";
            enn1.DisplayEntry();*/
            break;

            case "2":
            j1.DisplayAll();
           //string test = promp01.GetRandomPrompt();
           //Console.WriteLine(test);
            break;
        
            case "3":
            
            break;

            case "4":
            break;

            case "5":
            return;
            default:
            Console.WriteLine("Invalid option....");
            //choice = true;
            break;
        }
    }
    //}while(!choice);

    }
}