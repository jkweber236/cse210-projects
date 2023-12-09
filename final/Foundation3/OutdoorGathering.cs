class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base (title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override void GetFullDetails()
    {
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Description: {GetDescription()}");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine($"Time: {GetTime()}");
        Console.WriteLine($"Address: {GetAddress()}");
        Console.WriteLine($"Weather Forecast: {_weatherForecast}\n");
    }

    public override void GetShortDescription()
    {
        Console.WriteLine($"Event Type: Outdoor Gathering");
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Date: {GetDate()}\n");
    }
}