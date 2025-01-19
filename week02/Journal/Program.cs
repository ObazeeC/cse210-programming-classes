using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
         
        Console.WriteLine("Abstraction! This is the Journal Project.");
        Console.WriteLine("*****************************************");
      
        Journal j1 = new Journal();
   
    while(true)
    {


        
    
        Console.WriteLine("");
        Console.WriteLine("Please select one of the following options");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        Console.Write("What will you like to do ?");
        userInput = Console.ReadLine();

        switch(userInput)
        {
           
            case "1":
            Console.WriteLine("Do you want to answer to a random prompt or write a brief summary of your day ?");
            Console.WriteLine("Answer 'Yes' to use random prompt, 'No' to summarize your day ?");
            Console.Write(">>");
            string input = Console.ReadLine();
            if(input == "yes" || input == "Yes" || input == "YES")
            {
              j1.AddEntry();
            }
            else
            {
               j1.WriteSummary();
            }
            
             // This line of code work well...
             // Created the Entry and Prompt Generetor Object in the program file
         
             /* Entry enter = new Entry();
             PromptGenerator promp01 = new PromptGenerator();
             //Journal j1 = new Journal();

             enter._date = DateTime.Now.ToString();
             enter._promptText = promp01.GetRandomPrompt();
             string prompt = enter._promptText;
             Console.WriteLine(prompt);
             Console.Write(">>");
             enter._entryText = Console.ReadLine();
             j1.AddEntry(enter); */
            break;

            case "2":
            Console.WriteLine();
            j1.DisplayAll();
            //string test = promp01.GetRandomPrompt();
            //Console.WriteLine(test);
            break;
        
            case "3":
            Console.Write("Enter filename to save: ");
            string myFileName = Console.ReadLine();
            j1.SaveToFile(myFileName);
            break;

            case "4":
            Console.Write("Enter filename to load: ");
            string loadFileName = Console.ReadLine();
            j1.LoadFromFile(loadFileName);
            break;

            case "5":
            return;
            default:
            Console.WriteLine("Invalid, Please enter between 1 - 5 ");
            break;
        }
    }
   

    }
}