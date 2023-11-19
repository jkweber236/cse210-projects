using System.ComponentModel.DataAnnotations;

public class EternalGoals : Goal
{
    private int _timesCompleted = 0;

    public EternalGoals(string name, string description, int score)
        : base (name, description, score)
    {

    }

    public EternalGoals(string name, string description, int score, int timesCompleted)
        : base (name, description, score)
    {
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        _timesCompleted += 1;
        return GetScore();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string FormatGoal()
    {
        return$"EternalGoal:{GetName()},{GetDescription()},{GetScore()}";
    }
}