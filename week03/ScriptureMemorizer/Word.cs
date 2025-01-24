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

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }
}