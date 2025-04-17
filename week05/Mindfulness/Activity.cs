using System;

namespace Exercise
{
    public class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;
        List<string> _animationStrings;

        public Activity(string name, string description, int duration)
        {
            _name = name;
            _description = description;
            _duration = duration;
            _animationStrings= new List<string>();
            _animationStrings.Add("|");
            _animationStrings.Add("/");
            _animationStrings.Add("-");
            _animationStrings.Add("\\");
            _animationStrings.Add("|");
            _animationStrings.Add("/");
            _animationStrings.Add("-");
            _animationStrings.Add("\\");

        }

        public void DisplayStartingMessage()
        {
            Console.WriteLine("Here are some activities to help meditate and clear your mind.");
        }
        public void DisplayEndingMessage()
        {
            Console.WriteLine("\n- -Activity Complete- -");
        }
        public void ShowSpinner(int seconds)
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);

            int i = 0;
            while (DateTime.Now < endTime)
            {
                string s = _animationStrings[i];
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                i++;
                if (i >= _animationStrings.Count())
                {
                    i = 0;
                }
            }
        }
        public void ShowCountDown(int seconds)
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);

            while (DateTime.Now < endTime)
            {
                Console.Write(seconds);
                Thread.Sleep(1000);
                Console.Write("\b\b  \b\b");
                seconds--;
            }
        }
    }
}