public class SimpleGoals : Goal
{
    private bool _completed;

    public SimpleGoals(string name, string description, int score)
        : base (name, description, score)
    {

    }

    public SimpleGoals(string name, string description, int score, bool completed)
        : base (name, description, score)
    {
        _completed = completed;
    }

    public override int RecordEvent()
    {
        _completed = true;
        return GetScore();
    }


    public override bool IsComplete()
    {
        if(_completed == true)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public override string FormatGoal()
    {
        return$"SimpleGoal:{GetName()},{GetDescription()},{GetScore()},{IsComplete()}";
    }
}