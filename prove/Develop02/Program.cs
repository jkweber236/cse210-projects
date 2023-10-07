using System;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string user_input = "";
        List<Entry> entries = new List<Entry>();
        Journal journal = new Journal();

        while (user_input != "6")
        {
            // Display menu items
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Motivational Message");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? "); 
           
            user_input = Console.ReadLine();
            if (user_input == "1") 
            {
                journal.AddEntry(entries);
            }

            else if (user_input == "2")
            {
                journal.DisplayEntries(entries);
            }

            else if (user_input == "3")
            {
                journal.LoadFromFile(entries);
            }

            else if (user_input == "4")
            {
                journal.SaveToFile(entries);
            }

            else if (user_input == "5")
            {
                journal.DisplayMotivator();
            }
        }
    }
}