using System;

namespace ScriptureMemorizer
{
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int _endVerse;
        List<Verse> _Verses = new List<Verse>();
        public Reference()
        {
            _book = "";
            _chapter = 0;
            _verse = 0;
            _endVerse = 0;
            _Verses = [];
        }
        public Reference(string book, int chapter, int verse)
        {
            SetReference(book, chapter, verse);
        }

        public Reference(string book, int chapter, int verse, int endVerse)
        {
            SetReference(book, chapter, verse, endVerse);
        }
        public void SetReference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
        }
        public void SetReference(string book, int chapter, int verse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = endVerse;
            _Verses 

        }
        public string GetDisplayText()
        {
            if (_endVerse != 0)
            {
                return $"{_book} {_chapter}:{_verse}-{_endVerse}";
            }
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}