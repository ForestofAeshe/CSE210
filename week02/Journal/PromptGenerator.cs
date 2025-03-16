// _prompt_list: List<string> ||| store prompts in list

// GetRandomPrompt(): string ||| get random prompt from _prompt_list list

using System;
namespace JournalSystem
{
    public class PromptGenerator
{
    List<string> _prompt_list = new List<string>();
    Random _rnd = new Random();
    public string GetPrompt()
    {

        int randomNum = _rnd.Next(0, _prompt_list.Count());
        return  _prompt_list[randomNum];
    }

    public PromptGenerator()
    {
        _prompt_list.Add("Who was the most interesting person I interacted with today?");
        _prompt_list.Add("What was the best part of my day?");
        _prompt_list.Add("How did I see the hand of the Lord in my life today?");
        _prompt_list.Add("What was the strongest emotion I felt today?");
        _prompt_list.Add("If I had one thing I could do over today, what would it be?");
        _prompt_list.Add("What is a challenge I had today? And if I overcame it, how so?");


    }
}
}