class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps)
        : base (date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetDuration() * 60;
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }

    public override string GetSummary()
    {
        return$"> {GetDate()} Swimming ({GetDuration()} min)- Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}