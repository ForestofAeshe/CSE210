using System;
using JournalSystem;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal MyJournal = new Journal();
        Console.WriteLine("Hello World! This is the Journals Project.");
        MyJournal.GetEntry();
}
}