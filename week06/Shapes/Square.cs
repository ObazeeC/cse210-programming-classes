using System;
public class Square : Shape
{
    private double _side = 0;
    
    // constructor
    public Square(string color, double side) : base (color)
    {
        _side = side;

    }

    // override the base method
    public override double GetArea()
    {
        return _side * _side;
    }
}