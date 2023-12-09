class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base (title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override void GetFullDetails()
    {
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Description: {GetDescription()}");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine($"Time: {GetTime()}");
        Console.WriteLine($"Address: {GetAddress()}");
        Console.WriteLine($"Email: {_rsvpEmail}\n");
    }

    public override void GetShortDescription()
    {
        Console.WriteLine($"Event Type: Reception");
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Date: {GetDate()}\n");
    }
}