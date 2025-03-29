using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using YTVid;
class Program
{
    static void Main(string[] args)
    {
        string video1 = "roblox_oof:monke:10";
        string video2 = "on_a_scale_from_1_to_10:monke:15";
        string video3 = "peace_out:yoloer:30";

        List<string> commentList1 = 
        [
            "author1:commentloremipsum","author2:commentloremipsum","author3:commentloremipsum","author4:commentloremipsum"
        ];
        List<string> commentList2 =
        [
            "author1:commentloremipsum","author2:commentloremipsum","author3:commentloremipsum","author4:commentloremipsum"
        ];
        List<string> commentList3 =
        [
            "author1:commentloremipsum","author2:commentloremipsum","author3:commentloremipsum","author4:commentloremipsum"
        ];

        string[] VideoData1 = YouTubeVideos.GetVideo(video1);
    
    }
        
}    

