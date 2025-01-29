using System;
using System.Transactions;

public class Video
{
    public string _title = "";
    public string _author = "";
    public int _length = 0;

    public List<Video> _videos = new();

    public List <Comment> _comments = new();
    
  /*  public void WriteCommentOnAVideo()
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
      
        
    }*/
    public void DisplayVideoInfo()
    {
        foreach(var video in _videos)
         {
             Console.WriteLine($"{video._title} by {video._author}.  {video._length} seconds");
             Console.Write("Number of comment: ");
             Console.WriteLine(video.GetNumberOfComment());
             Console.WriteLine("***Comments***");
             video.DisplayAllComment();
             Console.WriteLine();
         }
       
    }

    public int GetNumberOfComment()
    {
        int number = 0;
        foreach(var video in _videos)
        {
          // number += video._comments.Count;
           
        }
        return number;
    }
    public void DisplayAllComment()
    {
        foreach(var comment in _comments )
        {   
            
            comment.DisplayComment();
        }
    }



}