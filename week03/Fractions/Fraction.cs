using System;
public class Fraction
{
private int _top = 0;
private int _bottom = 0;

//CREATE THE CONSTRUCTORS
public Fraction()
{
    _top = 1;
    _bottom = 1;
}
public Fraction(int top)
{
    _top = top;
    _bottom = 1;
}
public Fraction(int top, int bottom)
{
    _top = top;
    _bottom = bottom;
}

//CREATE THE GETTERS AND SETTERS
public int GetNumerator()
{
    return _top;
}

public int SetNumerator(int top)
{
    _top = top;
    return _top;
    
}

public int SetDenominator(int bottom)
{
    _bottom = bottom;
    return _bottom;
    
}
public int GetDenominator()
{
    return _bottom;
}
public string GetFractionString()
{
    string fraction = ($"{_top}/{_bottom}") ;
    return fraction;
}
public double GetDecimalValue()
{
    double top = _top;
    double bottom = _bottom; 
    return top / bottom;
}
}