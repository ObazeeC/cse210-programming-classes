using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("*******************************************");

        string input;
        int number = 0;
        List<int> numbers = new List<int>();
        
       Console.WriteLine("Enter a  list of numbers, type 0 when finished.");
        
        do
        {
            Console.Write("Enter number: ");
            input = Console.ReadLine();
            number = int.Parse(input);
            if(number == 0)
            {
                break;
            }
            else{

                numbers.Add(number);
            }
        }while(number != 0);
        
        //Compute sum of numbers
        float sum = 0;
        float average = 0;
        int len  = 0;
        int largestNumber = numbers[0];

        
        foreach (int x in numbers)
        {
            Console.WriteLine(x);
            sum += x;  

            // find largest number
            if (x > largestNumber)
            {
                largestNumber = x;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        len = numbers.Count;
         //Console.WriteLine($"The size is: {len}");
         average = sum / len; 
         Console.WriteLine($"The average is: {average}");
         Console.WriteLine($"The largest number is: {largestNumber}");
      
    }
}