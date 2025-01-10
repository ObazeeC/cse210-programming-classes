using System;
using System.Globalization;

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
        int smallestPositive = int.MaxValue;
    

        
        foreach (int x in numbers)
        {
            Console.WriteLine(x);
            sum += x;  

            // find largest number
            if (x > largestNumber)
            {
                largestNumber = x;
            }

           // find the smallest positive number
            if ( x > 0 && x < smallestPositive)
            {
                smallestPositive = x;
            }

        }   
         Console.WriteLine($"The sum is: {sum}");
         len = numbers.Count;
         //Console.WriteLine($"The size is: {len}");
         average = sum / len; 
         Console.WriteLine($"The average is: {average}");
         Console.WriteLine($"The largest number is: {largestNumber}");

         if( smallestPositive == int.MaxValue)
           {
              Console.WriteLine("There are no positive numbers in the list");
           }
           else
           {
              Console.WriteLine($"The smallest positive number is : {smallestPositive}");
           }
         numbers.Sort();
         Console.WriteLine($"The sorted list in ascending order is: ");
         foreach (int x in numbers)
         {
            Console.WriteLine(x);
         }

         // To sort in descending order, you can use reverese method after so
        Console.WriteLine($"The sorted list in descending order is: ");
         numbers.Reverse();
         foreach (int x in numbers)
         {
            Console.WriteLine(x);
         }
         
    }
}


