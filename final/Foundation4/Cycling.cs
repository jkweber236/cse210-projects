using System.Reflection.Metadata;

class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, int duration, float speed)
        : base (date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * GetDuration() / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return$"> {GetDate()} Cycling ({GetDuration()} min)- Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}