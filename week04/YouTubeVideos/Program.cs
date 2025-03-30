using System;

using YTVid;
class Program
{
    static void Main(string[] args)
    {
        string[] video1 = 
            ["roblox_oof", "monke", "10"];
        string[] video2 = 
            ["on_a_scale_from_1_to_10", "monke", "15"];
        string[] video3 = 
            ["peace_out", "yoloer","30"];

        string[] commentList1 = 
        [
            "author1:commentloremipsum","author2:commentloremipsum","author3:commentloremipsum","author4:commentloremipsum"
        ];
        string[] commentList2 =
        [
            "author1:commentloremipsum","author2:commentloremipsum","author3:commentloremipsum","author4:commentloremipsum","author3:commentloremipsum"
        ];
        string[] commentList3 =
        [
            "author1:commentloremipsum","author2:commentloremipsum","author3:commentloremipsum","author4:commentloremipsum","author1:commentloremipsum","author2:commentloremipsum"
        ];

        YouTubeVideo VideoData1 = new YouTubeVideo(video1);
        VideoData1.AddComment(commentList1);
        VideoData1.PrintVideo();
        Console.WriteLine($"Comment Count: {VideoData1.GetCommentCount()}");
        VideoData1.PrintCommentsList();

        YouTubeVideo VideoData2 = new YouTubeVideo(video2);
        VideoData2.AddComment(commentList2);    
        VideoData2.PrintVideo();  
        Console.WriteLine($"Comment Count: {VideoData2.GetCommentCount()}");    
        VideoData2.PrintCommentsList();
        
        YouTubeVideo VideoData3 = new YouTubeVideo(video3);
        VideoData3.AddComment(commentList3);
        VideoData3.PrintVideo();
        Console.WriteLine($"Comment Count: {VideoData3.GetCommentCount()}");
        VideoData3.PrintCommentsList();
    }
}    

