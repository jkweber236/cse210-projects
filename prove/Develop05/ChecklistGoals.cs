public class ChecklistGoals : Goal
{
    private int _bonusPoints;
    private int _timesCompleted;
    private int _amountForBonus;

    public ChecklistGoals(string name, string description, int score, int bonusPoints, int amountForBonus)
        : base (name, description, score)
    {
        _bonusPoints = bonusPoints;
        _amountForBonus = amountForBonus;
    }

    public ChecklistGoals(string name, string description, int score, int bonusPoints, int amountForBonus, int timesCompleted)
        : base (name, description, score)
    {
        _bonusPoints = bonusPoints;
        _amountForBonus = amountForBonus;
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        _timesCompleted += 1;

        if(IsComplete() == true)
        {
            return GetScore() + _bonusPoints;
        }

        else
        {
            return GetScore();
        }
    }

    public override void DisplayGoal()
    {
        if (IsComplete())
        {
            Console.WriteLine($"[X] {GetName()} ({GetDescription()}) -- Currently completed: {_timesCompleted}/{_amountForBonus}");
        }

        else
        {
            Console.WriteLine($"[ ] {GetName()} ({GetDescription()}) -- Currently completed: {_timesCompleted}/{_amountForBonus}");
        }
    }

    public override bool IsComplete()
    {
        if(_timesCompleted >= _amountForBonus)
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
        return$"ChecklistGoal:{GetName()},{GetDescription()},{GetScore()},{_bonusPoints},{_amountForBonus},{_timesCompleted}";
    }
}