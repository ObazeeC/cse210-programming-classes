using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inheritance ! This is the Homework Project.");
        Console.WriteLine("");

        Assignment a1 = new("Esosa Obazee", "Physics");
       // Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new("Esosa Obazee", "Biology", "12.1", "Anatomy");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeWorkList());

        WrittingAssignment wrA = new("Esosa C.", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(wrA.GetSummary());
        Console.WriteLine(wrA.GetWrittingInformation());

    }
}