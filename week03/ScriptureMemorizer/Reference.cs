using System;
using System.Data;
public class Reference
{
    private string _book = "";
    private int _chapter = 0;
    private int _verse = 0;
    private int _endVerse = 0;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse , int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }



    public void GetDisplayTextOne()
    {
      Console.WriteLine($"{_book} {_chapter}:{_verse}");
      
    }
    public void GetDisplayText()
    {
      Console.WriteLine($"{_book} {_chapter}:{_verse}-{_endVerse}");
      
    }

}