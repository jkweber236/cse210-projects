using System;
using System.IO;

class Journal
{
    public void AddEntry(List<Entry>entries)
    {
        // Selects prompt
        Prompt randomPrompt = new Prompt();
        string prompt = randomPrompt.SelectPrompt();
        Console.WriteLine(prompt);

        // Gets response
        Console.Write("> ");
        string response = Console.ReadLine();

        // Gets time
        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToShortDateString();

        // Get complete entry
        Entry fullEntry = new Entry(dateText, prompt, response);

        // Adds new entry to list
        entries.Add(fullEntry);
    }

    public void DisplayEntries(List<Entry>entries) 
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.NewEntry());
            Console.WriteLine("");
        }
    }

    public void LoadFromFile(List<Entry>entries)
    {
        Console.Write("What is the filename?\n");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        entries.Clear();

        string prompt = "";
        string date = "";
        string response = "";

        foreach(string line in lines)
        {
            string[] getPrompt = line.Split("Prompt: ");
            string[] getDate = line.Split(" ");
            string[] isResponse = line.Split(" ");

            if (isResponse[0] == "Date:")
            {
                prompt = getPrompt[1];
                date = getDate[1];
            }

            else if (isResponse[0] != "")
            {
                response = line;
                Entry newEntry = new Entry(date, prompt, response);
                entries.Add(newEntry);
            }
        }
    }

    public void SaveToFile(List<Entry>entries)
    {
        Console.Write("What is the filename?\n");

        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("");
        }    

        foreach (Entry entry in entries)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName, true))
            {
                outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}\n{entry._response}");
            }
        }
    }

    public void DisplayMotivator()
    {
        // Selects random motivator
        Motivator randomMotivator = new Motivator();
        string motivator = randomMotivator.SelectMotivator();
        Console.WriteLine($"{motivator}\n");
    }
   
}
