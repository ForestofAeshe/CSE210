using System;
using System.Net.Quic;
using ScriptureMemorizer;

class Program
{
    static void Main(string[] args)
    {
        string menu = "";

        List<Reference> ref1 = new List<Reference>();
        ref1.Add(new Reference());
        ref1[0].SetReference("D&C", 25, 12);
        ref1.Add(new Reference());
        ref1[1].SetReference("2 Nephi", 9, 6, 8);

        do
        {
        Console.WriteLine("Please type a number below to select a Scripture. Then hit Enter.");
        Console.WriteLine("1. D&C 25:12");
        Console.WriteLine("2. 2 Nephi 9:6-8");
        if (menu == "1")
        {
            ref1[0].GetDisplayText();
        }
        else if (menu == "2")
        {
            ref1[1].GetDisplayText();
        }
        else
        {
            menu = "";
        }


        } while (menu != "quit");
    }
}