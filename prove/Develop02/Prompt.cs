using System;

class Prompt
{

    public List<string> _prompts = new List<string>(){
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
        "What was something I learned today? ",
        "What is a personal goal of mine? ",
        "What are my best qualities? ",
        "What are my weekend plans? ",
        "What are 3 things that inspired me today? ",
        "What am I going to do tomorrow to make it great? ",
        "How am I feeling today? ",
        "What am I proud of the most? " 
    };

    public string SelectPrompt() 
    {
        Random random = new Random();
        int list_index = random.Next(_prompts.Count);
        return _prompts[list_index];
    }
}