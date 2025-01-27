using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        Console.WriteLine("Scripture Memorizer! This is the ScriptureMemorizer Project.");

        Reference reference01 = new ("John", 3, 4);
        string text = "For God so love the word that He gave His only begotten Son, that whosoever beliveth in Him shall not perish but have everlasting life";
        Scripture scripture01 = new (reference01, text);
       

        Reference reference02 = new ("Romans", 10, 13, 14 );
        text = "For Whosover shall call upon the name of the Lord shall be saved. How then shall they call on him whom they have not believed? and how shall they believe in him of whom they have not heard? and how shall they hear without a preacher?";
        Scripture scripture02 = new (reference02, text);
        Console.Write("");
        reference01.GetDisplayTextOne();
        scripture01.GetDisplayText();
       // Console.WriteLine("");
       // Console.WriteLine("");

       // Console.Write("");
       // reference02.GetDisplayText();
       // scripture02.GetDisplayText();
       // while(!scripture01.IsCompletelyHidden())
       // {  // }
            string input = "";
            //while(true)
            while(scripture01.HideRandWords(1))
            {
              //if(scripture01.HideRandWords(1) == true)
              // { // THIS

              
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Press enter to continue or type 'quite' to finish: ");
                input = Console.ReadLine();
             if(input == "")
             {
                scripture01.HideRandWords(1);
                Console.Clear();
                Console.Write("");
                reference01.GetDisplayTextOne();
                scripture01.GetDisplayText();
                
        
             }
             else if(input == "quite" || input == "Quite" || input == "QUITE")
             {
                break;
             }
           
             // }else
              //{
                break;
             // }
            }// the block
            
         

        
    }
}