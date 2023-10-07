using System;

class Motivator
{

    public List<string> _motivators = new List<string>(){
        "If you can dream it, you can do it.",
        "Action is the foundational key to all success.",
        "Mistakes are proof that you're trying.",
        "Everyday is a second chance.",
        "Believe you can and you're halfway there.",
        "Life isn't about falling. It's about getting back up every time you fall.",
        "Life is a journey, not a destination.",
        "Every accomplishment starts with the decision to try.",
    };

    public string SelectMotivator() 
    {
        Random random = new Random();
        int list_index = random.Next(_motivators.Count);
        return _motivators[list_index];
    }
}