using System;
using JournalSystem;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal MyJournal = new Journal();
        Console.WriteLine("Hello World! This is the Journals Project.");
        string menuInput = "";

        do
        {
            //menu list
            Console.WriteLine("Please select one of the below options.");
            Console.WriteLine("newEntry");
            Console.WriteLine("displayEntries");
            Console.WriteLine("saveToFile");
            Console.WriteLine("loadFromFile");
            Console.WriteLine("quit");
            Console.WriteLine();
            Console.Write("Selection > ");
            menuInput = Console.ReadLine();
            Console.WriteLine();

            //new entry
            if (menuInput == "newEntry")
            {
                MyJournal.GetEntry();
            }

            //display all
            else if (menuInput == "displayEntries")
            {
                // for (int i = 0;i < Journal._entries.Count(); i++)
                // {
                //     Console.WriteLine(Journal._entries[i]);
                //     Console.WriteLine();
                // }

                // OR

                // foreach (string i in _entries)
                // {
                //     Console.WriteLine(Journal._entries[i]);
                //     Console.WriteLine();  
                // }

                Console.WriteLine("show things");
                Console.WriteLine();
            }

            //save to file
            else if (menuInput == "saveToFile")
            {
                Console.WriteLine("save things");
                Console.WriteLine();
            }

            //load from file
            else if (menuInput == "loadFromFile")
            {
                Console.WriteLine("load things");
                Console.WriteLine();
            }

            //quit
            else if (menuInput == "quit")
            {
                break;
            }

            else
            {
                Console.WriteLine("Inputs are case sensitive. Please check your inputs and try again.");
            }

        } while (menuInput != "quit");

}
}