using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

public class Scripture
{
    private Reference _reference  ;
    private List<Word>_word;
    
    public Scripture(Reference scriptureRef, string text)
    {
       _reference = scriptureRef;
       _word = text.Split('|').Select(x => new Word(x)).ToList();
    }


public void GetDisplayText()
{
    Console.Write($"{_word}");
}
   
    
    


    

}