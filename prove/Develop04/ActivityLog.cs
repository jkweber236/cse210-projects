class ActivityLog : Activity
{
    private int _breathing;
    private int _reflecting;
    private int _listing;

    public ActivityLog(string name, string description, int breathing, int reflecting, int listing)
        : base(name, description)
    {
        _breathing = breathing;
        _reflecting = reflecting;
        _listing = listing;

    }

    public void RunActivity()
    {

        Console.Clear();
        Console.WriteLine("\nNumber of times each activity was performed: ");
        Console.WriteLine($"  -Breathing: {_breathing}");
        Console.WriteLine($"  -Reflecting: {_reflecting}");
        Console.WriteLine($"  -Listing: {_listing}\n");
        Console.WriteLine("Press enter to continue.");
        string userInput = Console.ReadLine();
    }

}