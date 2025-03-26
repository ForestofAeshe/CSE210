using System;

namespace ScriptureMemorizer
{
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int _endVerse;
        List<Scripture> _Verses = new List<Scripture>();

        private string verse1 = "For my soul delighteth in the song of the heart; yea, the song of the righteous is a prayer unto me, and it shall be answered with a blessing upon their heads.";
        private string verse2 = "For as death hath passed upon all men, to fulfil the merciful plan of the great Creator, there must needs be a power of resurrection, and the resurrection must needs come unto man by reason of the fall; and the fall came by reason of transgression; and because man became fallen they were cut off from the presence of the Lord.";
        private string verse3 = "Wherefore, it must needs be an infinite atonement�save it should be an infinite atonement this corruption could not put on incorruption. Wherefore, the first judgment which came upon man must needs have remained to an endless duration. And if so, this flesh must have laid down to rot and to crumble to its mother earth, to rise no more.";
        private string verse4 = "O the wisdom of God, his mercy and grace! For behold, if the flesh should rise no more our spirits must become subject to that angel who fell from before the presence of the Eternal God, and became the devil, to rise no more.";

        List<string> refdVerses;
        public Reference()
        {
            _book = "";
            _chapter = 0;
            _verse = 0;
            _endVerse = 0;
            _Verses = [];
        }
        public Reference(string book, int chapter, int verse, string verseData)
        {
            SetReference(book, chapter, verse, verseData);
        }

        public Reference(string book, int chapter, int verse, int endVerse, List<string> verseData)
        {
            SetReference(book, chapter, verse, endVerse, verseData);
        }
        public void SetReference(string book, int chapter, int verse, string verseData)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _Verses.Add(new Scripture(verseData));
        }
        public void SetReference(string book, int chapter, int verse, int endVerse, List<string> verseData)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = endVerse;
            
            
            for (int i = 0; i < verseData.Count; i++)
            {
                _Verses.Add(new Scripture(verseData[i]));
            }

          

        }

        public void PrintVerses()
        {
            for (int i = 0; i < _Verses.Count; i++)
            {
                Console.Write($"{_verse + i} ");
                _Verses[i].Print();

            }
        }

        public void HideVerses()
        {
            for (int i = 0; i < _Verses.Count; i++)
            {
                Console.Write($"{_verse + i} ");
                _Verses[i].HideRandom();

            }
        }

        public bool IsAllHidden()
        {
            bool tempBool = true;
            for (int i = 0; i < _Verses.Count; i++)
            {
                tempBool = tempBool && _Verses[i].IsAllHidden();
            }
            return tempBool;
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