using System;

namespace Exercise
{
    public class ListingActivity : Activity
    {
        protected int _count;
        public List<string> _prompts;
        public ListingActivity(string name, string description, int duration, int count) : base(name, description, duration)
        {
            _count = count;
            _prompts = new  List<string>();
            _prompts =
            [
                "Who are people that you appreciate?",
                "What are peersonal strengths of yours",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heros?",
            ];

        }   
        protected string GetRandomPrompt()
        {
            Random randint = new Random();
            int RandomeIndice = randint.Next(0,_prompts.Count());
            return _prompts[RandomeIndice];

        }
        protected void GetListFromUser()
        {
            Console.WriteLine($"{GetRandomPrompt()}");
            ShowSpinner(_count);
            Console.WriteLine("Take a few seconds to answer the prompt. List several answers.");
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            
            while (DateTime.Now < endTime)
            {
                Console.ReadLine();
            }
        }
        public void Run()
        {
            Console.WriteLine("This activity will help you reflect on the good things \nin your life by having you list as many things as you \ncan in a certain area.\n");
            
            // foreach (string i in _prompts) {Console.WriteLine($"{i} \n");}

            GetRandomPrompt();
            GetListFromUser();
        }
    }
}