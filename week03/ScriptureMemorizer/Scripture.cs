
using System;
using System.Collections.Generic;
public class Scripture

{
    private Reference _reference  ;
    private List<Word> _words = new List<Word>();
    private Random _random = new ();
    
    public Scripture(Reference scriptureRef, String text )
    {
        _reference = scriptureRef;
        string[] textWord = text.Split(' ');
      
        foreach(string eachWord in textWord)
        {
            _words.Add(new Word(eachWord));
        }
       
        
       
    }



public void HideRandWords(int numberToHide)
{
    // the hide method on the Word object
    // get display method on the Scripture object
    int num = 0;
    while (num < numberToHide)
    {
        int index = _random.Next(_words.Count);
         if (_words[index].Hide())
         {
            _words[index].Hide();
            num++;
         }

    }

}

public void GetDisplayText()
{
     foreach(var eachWord in _words)
        {
            
            Console.Write($" {eachWord}");
            
        }
  
}

public bool IsCompletelyHidden()
{
    foreach (var eachword in _words)
    {
       if(!eachword.Hide())
       {
        return false;
       }
    }
    return true;
    
}
    
    


    

}