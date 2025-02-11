using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Shapes program! This is the Shapes Project.");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine();
        
        // test the square class
        
        Square sq = new("Blue", 5);
           Square sq01 = new("Blue", 8);
              Square sq02 = new("Blue", 10);
        //Console.WriteLine($"The area of the square is : {sq.GetArea()}");
       // Console.WriteLine($"The color is : {sq.GetColor()}");

        Rectangle rec = new("Green", 5, 4);
         Rectangle rec01 = new("Green", 3, 4);
          Rectangle rec02 = new("Green", 5, 8);
       // Console.WriteLine($"The area of the rectangle is : {rec.GetArea()}");
      //Console.WriteLine($"The color is : {rec.GetColor()}");

        Circle circle = new("White", 5);
          Circle circle01 = new("White", 8);
            Circle circle02 = new("White", 9);
       // Console.WriteLine($"The area of the Circle is : {circle.GetArea()}");
       // Console.WriteLine($"The color is : {circle.GetColor()}");
              
       List<Shape>_shapes = new();
       _shapes.Add(sq);
       _shapes.Add(sq01);
       _shapes.Add(sq02);
       _shapes.Add(rec);
       _shapes.Add(rec01);
       _shapes.Add(rec02);
       _shapes.Add(circle);
       _shapes.Add(circle01);
       _shapes.Add(circle02);

       foreach(Shape x in _shapes)
       { 
        Console.WriteLine($"The area  : {x.GetArea()}");
        Console.WriteLine($"The color is : {x.GetColor()}");

         
       }

       
    }
}