class Running : Activity
{
    private float _distance;

    public Running(string date, int duration, float distance)
        : base (date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / GetDuration() * 60;
    }

    public override double GetPace()
    {
        return GetDuration() / _distance;
    }

    public override string GetSummary()
    {
        return$"> {GetDate()} Running ({GetDuration()} min)- Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
