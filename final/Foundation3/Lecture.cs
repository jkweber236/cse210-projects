class Lecture : Event
{
    private string _speakerName;
    private int _capacity;
    

    public Lecture(string eventTitle, string description, string date, string time, Address address, string speakerName, int capacity)
        : base (eventTitle, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity; 
    }

    public override void GetFullDetails()
    {
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Description: {GetDescription()}");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine($"Time: {GetTime()}");
        Console.WriteLine($"Address: {GetAddress()}");
        Console.WriteLine($"Speaker Name: {_speakerName}");
        Console.WriteLine($"Capacity: {_capacity}\n");
    }

    public override void GetShortDescription()
    {
        Console.WriteLine($"Event Type: Lecture");
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Date: {GetDate()}\n");
    }

}