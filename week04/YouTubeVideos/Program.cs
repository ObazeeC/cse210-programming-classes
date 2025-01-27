using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("YoutubeVideos! This is the YouTubeVideos Project.");
        Console.WriteLine();
        
        Video v1 = new();
        v1._author ="ESOSA";
        v1._title = "COMMENTS FOR VIDEO ONE";
        v1._length = 55;
        v1.CommentOnAVideo();
        
        //Comment com1 = new();
        //com1._name = "Esosa";
        //com1._text = " I am learning Abstraction";

        


    }
}