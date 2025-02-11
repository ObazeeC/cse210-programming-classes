using System;
public class Circle : Shape
{
    private double _radius = 0;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double pi = Math.PI;
        return pi * Math.Pow(_radius, 2);
        //return 3.14159 * _radius * _radius;
        // both equation are correct, return same values
    }
}