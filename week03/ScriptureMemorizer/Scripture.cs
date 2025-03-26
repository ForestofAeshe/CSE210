using System;
using System.Security.Cryptography.X509Certificates;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        List<Word> _words;
        Random _RndNum;
        public Scripture(string verse)
        {

            _words = new List<Word>();

            string[] verseList = verse.Split(' ');
            for (int i = 0; i < verseList.Count(); i++)
            {
                _words.Add(new Word(verseList[i]));
            }

            _RndNum = new Random();

        }

        public void HideRandom()
        {
            // Number of Verses to Hide
            for (int i = 0; i<_RndNum.Next(3,4);i++)
            {
                int stretch = _RndNum.Next(0, _words.Count());

                if (_words[stretch].IsHidden() && !IsAllHidden() )
                {
                    i--;
                }
                else
                {
                    _words[stretch].Hide();
                }
            }

        }

        public bool IsAllHidden()
        {
            bool tempBool = true;
            for (int i = 0; i<_words.Count; i++)
            {
                tempBool = tempBool && _words[i].IsHidden();
            }
            return tempBool;
        }


        public void Print()
        {
            for (int i = 0; i < _words.Count(); i++)
            {
                Console.Write(_words[i].GetWord());
                Console.Write(" ");
                if ((i + 1) % 11 == 0)
                {
                    Console.WriteLine(' ');
                }
            }
            Console.WriteLine(' ');
        }

    }

}
