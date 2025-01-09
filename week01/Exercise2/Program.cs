using System;

class Program
{
   
    static void Main(string[] args)
    {
        string input;
        int gradePercentage;
        string letter;
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("******************************************");
        Console.WriteLine("");
        Console.WriteLine("This program determines the letter grade for a course .");
        Console.WriteLine("");

        Console.Write("Please enter your grade percentage: ");
        input = Console.ReadLine();
        gradePercentage = int.Parse(input);
        if(gradePercentage >= 90)
        {
            //Console.WriteLine("You score 'A' ");
            letter = "A";
            if(gradePercentage >=70)
            {
                Console.WriteLine("Congratulations, You Passed!!!");
            }
            else
            {
                Console.WriteLine("Please try harder next time.");
            }
        }  

        else if (gradePercentage >= 80)
        {
          //  Console.WriteLine("You score 'B' ");
            letter = "B";
            if(gradePercentage >=70)
            {
                Console.WriteLine("Congratulations, You Passed!!!");
            }
            else
            {
                Console.WriteLine("Please try harder next time.");
            }
        }

         else if (gradePercentage >= 70)
        {
           // Console.WriteLine("You score 'C' ");
            letter = "C";
            if(gradePercentage >=70)
            {
                Console.WriteLine("Congratulations, You Passed!!!");
            }
            else
            {
                Console.WriteLine("Please try harder next time.");
            }
        }

         else if (gradePercentage >= 60)
        {
            //Console.WriteLine("You score 'D' ");
            letter = "D";
            if(gradePercentage >=70)
            {
                Console.WriteLine("Congratulations, You Passed!!!");
            }
            else
            {
                Console.WriteLine("Please try harder next time.");
            }
        }

        else{
           // Console.WriteLine("You score 'F'");
            letter = "F";
            if(gradePercentage >=70)
            {
                Console.WriteLine("Congratulations, You Passed!!!");
            }
            else
            {
                Console.WriteLine("Please try harder next time.");
            }
        }

        Console.WriteLine(letter);

    }
}