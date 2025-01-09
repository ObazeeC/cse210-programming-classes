using System;

class Program
{
    static void Main(string[] args)
    {
        string ans = "";
        int magicNumber;
        int guessNumber;
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.Write("What is the magic number: ");
        ans = Console.ReadLine();
        magicNumber = int.Parse(ans);
        Console.Write("What is your guess: ");
        ans =   Console.ReadLine();
        guessNumber = int.Parse(ans);
        if (guessNumber > magicNumber)
        {
            Console.WriteLine("Guess lower");

        }
        else if ( guessNumber < magicNumber)
        {
            Console.WriteLine("Guess higher");
        }

        else
        {
            Console.WriteLine("You guessed it!");
        }
        
        

    }
}