using System;
// this base class is not an abstract class
// hence we are using the virtual method

// if it was abstract class, we would use abstract methods 
// abstract class takes the keyword, 'abstract'. e.g, public abstract class name
// abstract method takes the keyword 'abstract'. e.g, public abstract double GetColor(){}
// you can not create instances of abstract class but can only inherit it in child classes

// There is also interface class
// interface class does not accept member variable
// interface methods does not have a body
// you can not create instances of interface class but can only inherit it in child classes

public  class Shape
{
private string _color = "";

//Constructor, accept color and set it
public Shape(string color)
{
    _color = color;
}
public string GetColor()
{
    return _color;
}
public void SetColor(string color)
{
    _color = color;
}
public virtual double GetArea()
{
    double area = 0;
    return area;
}
}