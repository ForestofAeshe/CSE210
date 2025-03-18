

// Display(): void ||| display entry

using System;


namespace JournalSystem
{

    public class Journal
    {
        //Member Variable Declaration
        PromptGenerator _generator;
        DateTime _timeDateNow;
        List<JournalEntry> _entries;
        public struct JournalEntry()
        {
            // _date: string ||| get date time now. simple time. full date yyyy/mm/dd
            public string _date;
            // _promptText: string ||| pull random prompt from PromptGenerator.cs
            public string _prompt;
            // _entryText: string ||| user inputs response.
            public string _input;
        }

        //Constructor
            public Journal()
        {
            _entries = new List<JournalEntry>();
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
        public void DisplayEntries()
        {
            for (int i = 0;i < _entries.Count(); i++)
                {
                    Console.WriteLine($"{_entries[i]._date}: {_entries[i]._prompt}");
                    Console.WriteLine($"> {_entries[i]._input}");
                    Console.WriteLine(); 
                }
        }

        public void LoadEntry(string inDate, string inPrompt, string inInput)
        {
            JournalEntry loadedEntry = new JournalEntry();
            loadedEntry._date = inDate;
            loadedEntry._prompt = inPrompt;
            loadedEntry._input = inInput;

            _entries.Add(loadedEntry);
        }
        
        public void SaveFile()
        {

            
            using (StreamWriter writer = new StreamWriter("journalFile.txt"))
            {
                for (int index = 0; index < _entries.Count(); index++)
            {
                writer.WriteLine(_entries[index]._date);
                writer.WriteLine(_entries[index]._prompt);
                writer.WriteLine(_entries[index]._input);
            }
            }  
        }

        public void LoadFile()
        {   
            _entries = new List<JournalEntry>();
            using (StreamReader  reader = new StreamReader("journalFile.txt"))
            {   
            
                string buffer_date = "";
                string buffer_prompt = "";
                string buffer_input = "";
                string line;
                List<string> MyFileList = new List<string>();

                while ((line = reader.ReadLine()) != null)
                {
                    MyFileList.Add(line);

                }

                for (int index = 0; index < MyFileList.Count();index = index + 3)
                {
                    buffer_date = MyFileList[index];
                    buffer_prompt = MyFileList[index+1];
                    buffer_input = MyFileList[index+2];

                    LoadEntry(buffer_date, buffer_prompt, buffer_input);
                }
                    buffer_date = "";
                    buffer_prompt = "";
                    buffer_input = "";
                    line = "";
            }
        }
    }
}




//             // Read and show each line from the file.
//             string line = "";
//             using (StreamReader sr = new StreamReader("CDriveDirs.txt"))
//             {
//                 while ((line = sr.ReadLine()) != null)
//                 {
//                     Console.WriteLine(line);
//                 }
//             }
//         }
//     }
// }