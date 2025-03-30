using System;

namespace YTVid
{
    class YouTubeVideo
    {
  
        private string _title;
        private string _author;
        private int _length;
        private List<Comment> _comments;
        public YouTubeVideo(string[] videoString)
        {
            _title = videoString[0];
            _author = videoString[1];
            _length = int.Parse(videoString[2]);
            _comments = new List<Comment>();
        }

        public void PrintVideo()
        {
            Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_length} \n");
        }
        public int GetCommentCount()
        {
            return _comments.Count();
        }
        public void AddComment(string[] commentList)
        {
            for (int i = 0; i < commentList.Count(); i++)
            {
                _comments.Add(new Comment(commentList[i]));
            }
        }
        public void PrintCommentsList()
        {
            foreach (Comment comment in _comments)
            {
                comment.PrintComment();
            }
        }
    }
}