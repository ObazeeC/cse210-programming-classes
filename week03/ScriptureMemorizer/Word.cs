using System;
public class Word
{
    private string _text = "";
    private Boolean _isHidden = false;

    public Word( string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool Hide()
    {
        _isHidden = true;
        return true;
    }

    public bool Show()
    {
        _isHidden = false;
        return false;
    }

    // public override string ToString() --> override means it replaces the ToString method inherited in base class, the return type is string
    // return _isHidden ? new string('_', _text.Length):_text; --> this line uses the ternary conditional ? to decide what to return.
    // _isHidden --> This is a boolean property from our class, if the is 'true' the returns a string of underscores(_) with the same length as _text
    // new string('_', _text.Length) --> creates a new string consisting of underscores with the same length as _text
    //_text --> if _IsHidden is false, it simply returns the value of the _text property 
    public override string ToString()
    {
       return _isHidden ? new string('_', _text.Length):_text;
    }
}