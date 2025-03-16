

// Display(): void ||| display entry

using System;

namespace JournalSystem
{

    public class Journal
    {
        PromptGenerator _generator;
        DateTime _timeDateNow;
        List<JournalEntry> _entries;
        struct JournalEntry()
        {
            // _date: string ||| get date time now. simple time. full date yyyy/mm/dd
            public string _date;
            // _promptText: string ||| pull random prompt from PromptGenerator.cs
            public string _prompt;
            // _entryText: string ||| user inputs response.
            public string _input;
        }
                public Journal()
        {
            _generator = new PromptGenerator();
            _timeDateNow = new DateTime();
        }
        public void GetEntry()
        {
            JournalEntry currentEntry = new JournalEntry();
            currentEntry._date = _timeDateNow.ToString();
            currentEntry._prompt = _generator.GetPrompt();

            Console.WriteLine($"{currentEntry._date}: {currentEntry._prompt}");
            Console.Write($"> ");
            currentEntry._input = Console.ReadLine();  

            _entries.Add(currentEntry);
        }
    }
}