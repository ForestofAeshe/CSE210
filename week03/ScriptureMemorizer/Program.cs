using System;
using System.Net.Quic;
using ScriptureMemorizer;

class Program
{
    private static string verse1 = "For my soul delighteth in the song of the heart; yea, the song of the righteous is a prayer unto me, and it shall be answered with a blessing upon their heads.";
    private static string verse2 = "For as death hath passed upon all men, to fulfil the merciful plan of the great Creator, there must needs be a power of resurrection, and the resurrection must needs come unto man by reason of the fall; and the fall came by reason of transgression; and because man became fallen they were cut off from the presence of the Lord.";
    private static string verse3 = "Wherefore, it must needs be an infinite atonement-save it should be an infinite atonement this corruption could not put on incorruption. Wherefore, the first judgment which came upon man must needs have remained to an endless duration. And if so, this flesh must have laid down to rot and to crumble to its mother earth, to rise no more.";
    private static string verse4 = "O the wisdom of God, his mercy and grace! For behold, if the flesh should rise no more our spirits must become subject to that angel who fell from before the presence of the Eternal God, and became the devil, to rise no more.";

    static void Main(string[] args)
    {
        string menu = "";

        List<string> verseList = new List<string>();
        verseList.Add(verse2);
        verseList.Add(verse3);
        verseList.Add(verse4);

        
    List<Reference> ref1 = new List<Reference>();
        ref1.Add(new Reference());
        ref1[0].SetReference("D&C", 25, 12,verse1);
        ref1.Add(new Reference());
        ref1[1].SetReference("2 Nephi", 9, 6, 8, verseList);


        Console.WriteLine("Please type a number below to select a Scripture. Then hit Enter.");
        Console.WriteLine("1. D&C 25:12");
        Console.WriteLine("2. 2 Nephi 9:6-8");
        menu = Console.ReadLine();

        if (menu == "1")
        {
            do
            {
                
                Console.Clear();
                //print scripture reference
                Console.WriteLine(ref1[0].GetDisplayText());
                ref1[0].PrintVerses();

                Console.WriteLine($"\n Please hit 'enter' to continue or type 'quit' to end program.");

                menu = Console.ReadLine();
                if (ref1[0].IsAllHidden())
                {
                    break;
                }
                ref1[0].HideVerses();
                

            } while (menu != "quit"); 

        }
        else if (menu == "2")
        {
            do
            {
                
                Console.Clear();
                //print scripture reference
                Console.WriteLine(ref1[1].GetDisplayText());
                ref1[1].PrintVerses();

                Console.WriteLine($"\n Please hit 'enter' to continue or type 'quit' to end program.");

                menu = Console.ReadLine();
                if (ref1[1].IsAllHidden())
                {
                    break;
                }
                ref1[1].HideVerses();
                

            } while (menu != "quit");
        }
        else
        {
            menu = "";
            
        }


    }
}