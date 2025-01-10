using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Function Review ! This is the Exercise5 Project.");
        Console.WriteLine("**********************************************");
        string userName = "";
        int userNumber = 0 ;
    
        
        DisplayWelcome();
        string name = PromptUserName(userName);
        int numReturnd = PromptUserNumber(userNumber);
        int squeredReturndNumber = SquareNumber(numReturnd);
        DisplayResult(name, squeredReturndNumber);
       
       //  DisplayResult(userName, sqNumber);
       // Console.WriteLine(numReturnd);
       // Console.WriteLine(squeredReturneNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName(string name)
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber(int number)
        {
            Console.Write("Please enter your favorite number:");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            //Console.WriteLine(number);
            //Console.WriteLine(number);
            //Console.WriteLine("******");
            return number;
         
            
        }
        static int SquareNumber(int number)
        {
            int sqNum = number * number;
            return sqNum;

        }

        static void DisplayResult (string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number} ");
        }
    
    }
    }
