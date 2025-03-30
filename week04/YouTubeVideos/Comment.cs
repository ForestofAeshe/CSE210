using System;


namespace YTVid
{
    class Comment
    {
        private string _commentAuthor;
        private string _commentContent;
        

        public Comment(string commentList)
        {
            string[] strings= commentList.Split(':');
            _commentAuthor = strings[0];
            _commentContent = strings[1];
        }

        public void PrintComment()
        {
            Console.WriteLine($"Author: {_commentAuthor}");
            Console.WriteLine($"> {_commentContent}");
            Console.WriteLine();
        }
    }
}