using System;
using System.ComponentModel;

namespace Activity
{
    public class ReflectingActivity : Activity
    {
        public List<string> _prompts;
        public List<string> _questions;
        public ReflectingActivity(string name,string description,int duration) : base(name,description,duration)
        {
            _prompts = new List<string>();
            _questions = new List<string>();
            _prompts = 
                [
                "Think of a time when you stood up for someone else.\n",
                "Think of a time when you did something really difficult.\n",
                "Think of a time when you helped someone in need.\n",
                "Think of a time when you did something truly selfless\n"
                ];
            _questions = 
                [
                "Why was this experience meaningful to you?\n",
                "Have you ever done anything like this before?\n",
                "How did you get started?\n",
                "How did you feel when it was complete?\n",
                "What made this time different than other times when you were not as successful?\n",
                "What is your favorite thing about this experience?\n",
                "What could yo ulearn from this experience that applies to other situations?\n",
                "What did you learn about yourself through this experience?\n",
                "How can you keep this experience in mind in the future?\n"
                ];
        }
        public string GetRandomPrompt()
        {
            Random randint = new Random();
            int RandomeIndice = randint.Next(0,_prompts.Count());
            return _prompts[RandomeIndice];
        }
        public string GetRandomQuestion()
        {
            Random random = new Random(); 
            int RandomeIndice = random.Next(0,_questions.Count());
            return _questions[RandomeIndice];
        }
        public void Run()
        {   
            Random random = new Random(); 
            int RandomAmount = random.Next(1,4);
            Console.WriteLine("This activity will help you reflect on times in your life \nwhen you have shown strength and resilience. \nThis will help you recognize the power you have \nand how you can use it in other aspects of your life.\n");
            for (int i = 0; i < RandomAmount; i++)
            {
            Console.WriteLine($"{GetRandomPrompt()}\n");
            ShowSpinner(_duration/RandomAmount);
            }

        }
    }
}