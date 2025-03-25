using System;

namespace ScriptureMemorizer
{
    public class Verse
    {
        private string verse1 = "For my soul delighteth in the song of the heart; yea, the song of the righteous is a prayer unto me, and it shall be answered with a blessing upon their heads.";
        private string verse2 = "For as death hath passed upon all men, to fulfil the merciful plan of the great Creator, there must needs be a power of resurrection, and the resurrection must needs come unto man by reason of the fall; and the fall came by reason of transgression; and because man became fallen they were cut off from the presence of the Lord.";
        private string verse3 = "Wherefore, it must needs be an infinite atonement—save it should be an infinite atonement this corruption could not put on incorruption. Wherefore, the first judgment which came upon man must needs have remained to an endless duration. And if so, this flesh must have laid down to rot and to crumble to its mother earth, to rise no more.";
        private string verse4 = "O the wisdom of God, his mercy and grace! For behold, if the flesh should rise no more our spirits must become subject to that angel who fell from before the presence of the Eternal God, and became the devil, to rise no more.";

        public Verse(string verse)
        {
            List<Word> _words = new List<Word>();

            string[] verseList = verse.Split(' ');

            for (int i = 0; i < verseList.Count(); i++)
            {
                _words[i].SetWord(verseList[i]);
            }

        }

        public Verse(string[] verseCount)
        {
            for (int j = 0; j < verseCount.Count(); j++)
            {
                List<Word> _words = new List<Word>();

                string[] verseList = verseCount[j].Split(' ');

                for (int i = 0; i < verseList.Count(); i++)
                {
                    _words[i].SetWord(verseList[i]);
                }
            }
        }

    }


}

        // D&C 25:12
        // 12 For my soul delighteth in the song of the heart; yea, the song of the righteous is a prayer unto me, and it shall be answered with a blessing upon their heads.
        
        // 2 Nephi 9:6-8
        // 6 For as death hath passed upon all men, to fulfil the merciful plan of the great Creator, there must needs be a power of resurrection, and the resurrection must needs come unto man by reason of the fall; and the fall came by reason of transgression; and because man became fallen they were cut off from the presence of the Lord.
        // 7 Wherefore, it must needs be an infinite atonement—save it should be an infinite atonement this corruption could not put on incorruption. Wherefore, the first judgment which came upon man must needs have remained to an endless duration. And if so, this flesh must have laid down to rot and to crumble to its mother earth, to rise no more.
        // 8 O the wisdom of God, his mercy and grace! For behold, if the flesh should rise no more our spirits must become subject to that angel who fell from before the presence of the Eternal God, and became the devil, to rise no more.