using System;
using System.IO;
public class Journal 
// Responsibility: 
// * to create, hold, and display entries.
// * to save the journal as a .txt file.
// * to load .txt files as journals.

{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
    }

    public void Add()
    {
        Entry newEntry = new Entry();

        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToShortDateString();
        newEntry._date = dateText;

        PromptGenerator newPrompt = new PromptGenerator();
        newEntry._prompt = newPrompt.New();

        Console.Write(newEntry._prompt);
        newEntry._message = Console.ReadLine();

        this._entries.Add(newEntry);

        Console.WriteLine("Your entry has been added successfully.");
    }

    public void DisplayAll()
    {
        foreach (Entry item in _entries)
        {
            item.Display();
        }
    }

    public void Load()
    {   
        this._entries.Clear();
        Console.Write("Please enter a filename: ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {   
            Entry newEntry = new Entry();
            int startIndex = 6;
            newEntry._date = line.Substring(startIndex, 10);

            string keyword = "Prompt: ";
            int startIndex2 = line.IndexOf(keyword) + keyword.Length;
            
            int questionMarkIndex = line.IndexOf("?");
            int characterNum = questionMarkIndex - startIndex2;

            newEntry._prompt = line.Substring(startIndex2, characterNum);

            string keyword2 = "Answer: ";
            int startIndex3 = line.IndexOf(keyword2) + keyword2.Length;
            newEntry._message = line.Substring(startIndex3);
                
            this._entries.Add(newEntry);
        }
        Console.WriteLine($"The journal named '{filename}' was loaded successfully.");
    }
    public void Save()
    {   
        Console.Write("Please enter a filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry item in _entries)
            {
                outputFile.WriteLine($"Date: {item._date} - Prompt: {item._prompt} - Answer: {item._message}");
            }

        }
        Console.WriteLine($"Your journal named '{filename}' has been saved successfully.");

    }

}
