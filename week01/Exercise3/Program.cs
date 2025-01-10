using System;

class Program
{
    static void Main(string[] args)
    {
        string ans = "";
        //int magicNumber;
        int guessNumber;
        int number ;
        int guessCount = 0;
        bool playAgain = true;
        Console.WriteLine("The guessing game! This is the Exercise3 Project.");
        Console.WriteLine("*******************************************");
        Console.WriteLine("");

 do
 {
    // Play Again loop
        Random r = new Random();
        number = r.Next(1, 101);
        
        guessNumber = -1;

    
     do
      {
        
    
            //Console.Write("What is the magic number: ");
            //ans = Console.ReadLine();
            //magicNumber = int.Parse(ans);
            Console.Write("What is your guess: ");
            ans =   Console.ReadLine();
            guessNumber = int.Parse(ans);
            if (guessNumber > number)
            {
                Console.WriteLine("Guess lower");

            }
            else if ( guessNumber < number)
            {
                Console.WriteLine("Guess higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
          guessCount ++;
        } while (guessNumber != number); 
       
        Console.WriteLine($"You have guessed {guessCount} times");

    

// PLAY AGAIN
       Console.WriteLine("Do you want to play again: ?");
       ans = Console.ReadLine();

       if (ans == "YES" || ans == "yes" || ans == "Yes")
       {
         playAgain = true;
       }
       else
       {
        playAgain = false;
       }
    
     }while (playAgain);
}

}