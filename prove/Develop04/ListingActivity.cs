public class ListingActivity : Activity 
{
    private List<string> _prompts = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heros?"
    };

    public ListingActivity(string name, string description)
        : base(name, description)
    {}

    public void RunActivity()
    {
        int duration = DisplayStartMessage();

        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {GetPrompt()} --- ");
        Console.Write($"You may begin in: ");
        PauseWithTimer(5);
        Console.Write("\n");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        int numberOfEntries = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            numberOfEntries += 1;
        }
        Console.WriteLine($"You listed {numberOfEntries} item(s)!");

        DisplayEndMessage();
    }

    public string GetPrompt()
    {
        Random random = new Random();
        int list_index = random.Next(_prompts.Count);
        return _prompts[list_index];
    }
}