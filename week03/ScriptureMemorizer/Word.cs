using System;
namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        bool _isHidden;


        public Word(string text)
        {

        }

        //set hidden to true
        public void Hide()
        {

        }

        // set hidden to false
        public void Show()
        {

        }

        // get hidden state
        // public bool IsHidden()
        // {
            
        // }
        // public string GetDisplayText() 
        // {
        
        // }
        public void SetWord(string text)
        {
            this._text = text;
        }
    }
}