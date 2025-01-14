using System;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Abstraction! This is the Resumes Project.");
        Console.WriteLine("*****************************************");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2012;
        job1._endYear = 2019;
        //job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2019;
        job2._endYear = 2024;
        //job2.DisplayJobDetails();
        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);
        

        Resume resume1 = new Resume();
        
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

       Console.WriteLine("******Job1 title******");
       //Console.WriteLine(resume1._jobs[0]._jobTitle );
       resume1._name = "Esosa Confidence Obazee";
       resume1.Display();
       
    }
}