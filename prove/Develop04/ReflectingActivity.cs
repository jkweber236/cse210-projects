using System.Diagnostics;

public class ReflectingActivity : Activity 
{
    private List<string> _prompts = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of at time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

        public ReflectingActivity(string name, string description)
            : base(name, description)
        {}

    public void RunActivity()
    {
        int duration = DisplayStartMessage();

        Console.WriteLine($"\nConsider the following prompt:");
        Console.WriteLine($"\n --- {GetRandomPrompt()} --- ");
        Console.WriteLine($"\nWhen you have something in mind, press enter to continue.");
        string userInput = Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        PauseWithTimer(5);
        Console.Clear();

        while (duration > 0)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            if (duration >= 10) {
                PauseWithSpinner(10);
                duration -= 10;
            }

            else if (duration < 10) {
                PauseWithSpinner(duration);
                duration -= duration;
            }
            Console.Write("\n");
        }

        DisplayEndMessage();
    }

    public string GetRandomPrompt() 
    {
        Random random = new Random();
        int list_index = random.Next(_prompts.Count);
        return _prompts[list_index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int list_index = random.Next(_questions.Count);
        return _questions[list_index];
    }
}