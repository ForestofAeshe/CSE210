using System;
namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        bool _isHidden;


        public Word(string text)
        {
            SetWord(text);
        }

        //set hidden to true
        public void Hide()
        {
            _isHidden = true;
        }

        // set hidden to false
        public void Show()
        {
            _isHidden = false;
        }

        //get hidden state
        public bool IsHidden()
        {
            return _isHidden;
        }
        public string GetWord()
        {
            if (_isHidden)
            {
                string Buffer = "";
                for (int i = 0; i < _text.Length; i++)
                {
                    Buffer += "_";
                }
                return Buffer;
            }
            else
            {
                return _text;
            }
        }
        public void SetWord(string text)
        {
            this._text = text;
        }
    }
}