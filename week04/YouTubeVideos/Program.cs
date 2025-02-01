using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        
        
       
    
        Console.WriteLine("YoutubeVideos! This is the YouTubeVideos Project.");
        Console.WriteLine();
            Video videos = new();
        
         
             Video v1 = new();
             Comment c = new();
             Comment c1 = new();
             Comment c2 = new();
             Comment c3 = new();
             v1._author ="Esosa";
             v1._title = "How to code in one month";
             v1._length = 55;
             
             c._name = "Gospower";
             c._text = "You should do this oftern";
             c1._name = "Wisdom";
             c1._text ="Greate video, I love it !!!";
             c2._name= "Charles";
             c2._text = "Shot and enlightening";
             c3._name = "Festus";
             c3._text = "Exactly what I was looking for ";

             v1._comments.Add(c);
             v1._comments.Add(c1);
             v1._comments.Add(c2);
             v1._comments.Add(c3);
             videos._videos.Add(v1);
             
             
             Video v2 = new();
             Comment cc1 = new();
             Comment cc2 = new();
             Comment cc3 = new();
             Comment cc4 = new();
             Comment cc5 = new();

             v2._author = "Penpower";
             v2._title = "How to learn coding in less than 6 months";
             v2._length = 500;
             cc1._name = "Aise";
             cc1._text = " Simple and rich video, thank you";
             cc2._name = "Osas";
             cc2._text = " Exactly what I was looking for";
             cc3._name = "Aisosa";
             cc3._text = " I wish the video was longer, nice work.";
             cc4._name = "Emmanuel";
             cc4._text = " could you please do another video, on how to use python ?";
             cc5._name = "Eseiwi";
             cc5._text = "Do I have to learn all languages";

             v2._comments.Add(cc1);
             v2._comments.Add(cc2);
             v2._comments.Add(cc3);
             v2._comments.Add(cc4);
             v2._comments.Add(cc5);

             Video v3 = new();
             Comment cb1 = new();
             Comment cb2 = new();
             Comment cb3 = new();
             Comment cb4 = new();
             v3._author = "Ensign College";
             v3._title = "How to register for online courses";
             v3._length = 1000;
             cb1._name = "Godstime";
             cb1._text = "Are the courses free?";
             cb2._name = "Dennis";
             cb2._text = "How long will study to earn a BSC";
             cb3._name = "Favour";
             cb3._text = "How many hours a week is required to study ?";
             cb4._name = "Barbara";
             cb4._text = "Are the course completely online? ";

             v3._comments.Add(cb1);
             v3._comments.Add(cb2);
             v3._comments.Add(cb3);
             v3._comments.Add(cb4);


             Video v4 = new();
             Comment cd1 = new();
             Comment cd2 = new();
             Comment cd3 = new();
             Comment cd4 = new();
             v4._author = "MCgill";
             v4._title = "5 exercise tips to begin your day";
             v4._length = 760;
             cd1._name ="Grace";
             cd1._text = "Is it good to eat apple in the morning ?";
             cd2._name ="Innocent";
             cd2._text = "Please make the next one longer ";
             cd3._text = "Is 30 minutes enough in the morning ?";
             cd4._name ="Timaya";
             cd4._text = "I love it !!!";

             v4._comments.Add(cd1);
             v4._comments.Add(cd2);
             v4._comments.Add(cd3);
             v4._comments.Add(cd4);
             
             
             videos._videos.Add(v2);
             videos._videos.Add(v3);
             videos._videos.Add(v4);
            

             //Console.WriteLine("___Video info___ ");
             videos.DisplayVideoInfo();
             Console.WriteLine("____Total number of Comments____");
             Console.WriteLine(videos.GetTotalNumberOfComment());
             


    }
}