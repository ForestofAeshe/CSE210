using System;
using JournalSystem;

class Program
{
    //Function Declarations
    void SaveJournalToDisk(Journal Journal)
    {

    }
    void LoadJournalFromDisk(Journal Journal)
    {

    }

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
                MyJournal.DisplayEntries();

            }

            //save to file
            else if (menuInput == "saveToFile")
            {
                MyJournal.SaveFile();

            }

            //load from file
            else if (menuInput == "loadFromFile")
            {
                MyJournal.LoadFile();
                
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