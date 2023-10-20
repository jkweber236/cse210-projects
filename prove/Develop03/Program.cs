using System;

Reference reference = new Reference("Proverbs", 3, 5, 6);

Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean "
+ "not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

string userInput = "";

while (userInput != "quit" && scripture.IsCompletelyHidden() == false)
{
    Console.Clear();
    Console.WriteLine($"{reference.GetReference()} {scripture.GetRenderedText()}");

    // To exceed requirements, I made it so that pressing enter hides three new words
    // each time, rather than hiding some words that are already hidden. 
    Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");

    userInput = Console.ReadLine();

    scripture.HideWords();
}

if (userInput != "quit")
{
    Console.Clear();
    Console.WriteLine($"{reference.GetReference()} {scripture.GetRenderedText()}");

    Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
    Console.ReadLine();
}


