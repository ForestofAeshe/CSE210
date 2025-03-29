using System;
using System.Security.Cryptography.X509Certificates;

namespace YTVid
{
    class Comment
    {
        private string[] _commentAuthor;
        private string[] _comments;
        private int _commentCount;

        public Comment(List<string> commentList, string[] comments)
        {

            GetCommentList(commentList);
            GetCommentCount(comments);

        }


        public void GetCommentList(List<string> commentText)
        {
            for (int i = 0; i<commentText.Count(); i++)
            {
                string[] _temp = commentText[i].Split(':');

                _commentAuthor.Append(_temp[0]);
                _comments.Append(_temp[1]);

            }
        }

        public int GetCommentCount(string[] _comments)
        {
            return _comments.Count();
        }




    }
}