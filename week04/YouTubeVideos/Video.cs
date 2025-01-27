using System;
using System.Transactions;

public class Video
{
    public string _title = "";
    public string _author = "";
    public int _length = 0;

    public List <Comment> _comments = new();

    
    public void CommentOnAVideo()
    {
       
         Comment comment = new();
         Console.Write("Enter your name ");
          string name = Console.ReadLine();
          Console.Write("Enter your text ");
          string text = Console.ReadLine();
          comment._name = name;
          comment._text = text;
           _comments.Add(comment);
           // Console.WriteLine($"{video._name}");
           // Console.WriteLine($"{video._text}");
           // comment.DisplayComment();
      
        
    }

}