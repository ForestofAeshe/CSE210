using System;

namespace YTVid
{
    class YouTubeVideos
    {
        private string[] _videoData;
        private string _title;
        private string _author;
        private int _length;


        public YouTubeVideos(string videoString, List<string> commentText)
        {
            GetVideo(videoString);

        }

        public void GetVideo(string text)
        {
            this._videoData = text.Split(':');
            for (int i = 0; i < _videoData.Count();i++)
            {
                _title = _videoData[i];
                _author = _videoData[i+1];
                _length = int.Parse(_videoData[i+2]);
                i = i+3;
            }
        }

        public void PrintVideo(string title, string author, int length)
        {
            Console.WriteLine($"Title: {title} | Author: {author} | Length: {length}");
        }


    }
}