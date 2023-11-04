using System;

public class BreathingActivity : Activity 
{
    private int _breatheInDuration;
    private int _breatheOutDuration;

    public BreathingActivity(string name, string description)
        : base(name, description)
    {}

    public void RunActivity()
    {
        int duration = DisplayStartMessage();
        _breatheInDuration = duration / 2;
        _breatheOutDuration = duration - _breatheInDuration;
        Console.Write($"\n");

        while (_breatheInDuration > 0 && _breatheOutDuration > 0)
        {
            BreatheIn();
            BreatheOut();
        }
        DisplayEndMessage();
        Console.Clear();
    }

    public void BreatheIn()
    {   
        if (_breatheInDuration >= 5){
            Console.Write($"Breathe in...");
            PauseWithTimer(5);
            _breatheInDuration -= 5;
        }

        else if (_breatheInDuration < 5 && _breatheInDuration > 0){
            Console.Write($"Breathe in...");
            PauseWithTimer(_breatheInDuration);
            _breatheInDuration = 0;
        }
    }

    public void BreatheOut()
    {
        if (_breatheOutDuration >= 5){
            Console.Write($"\nNow breathe out...");
            PauseWithTimer(5);
            Console.Write($"\n\n");
            _breatheOutDuration -= 5;
         }

        else if (_breatheOutDuration < 5 && _breatheOutDuration > 0){
            Console.Write($"\nNow breathe out...");
            PauseWithTimer(_breatheOutDuration);
            Console.Write($"\n");
            _breatheOutDuration = 0;
        }
    }
}