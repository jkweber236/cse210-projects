using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        string menuItem = "";
        int points = 0; 
        int level = 1;

        while (menuItem != "6")
        {
            Console.WriteLine($"\nYou have {points} points.");
            Console.WriteLine($"You are level {level}.\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            menuItem = Console.ReadLine();

            if (menuItem == "1") 
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");

                string goalType = Console.ReadLine();

                if (goalType == "1")
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int score = int.Parse(Console.ReadLine());

                    SimpleGoals simple = new SimpleGoals(name, description, score);
                    goals.Add(simple);
                }

                else if (goalType == "2")
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int score = int.Parse(Console.ReadLine());

                    EternalGoals eternal = new EternalGoals(name, description, score);
                    goals.Add(eternal);
                }

                else if (goalType == "3")
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int score = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int amountForBonus = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPoints = int.Parse(Console.ReadLine());

                    ChecklistGoals checklist = new ChecklistGoals(name, description, score, bonusPoints, amountForBonus);
                    goals.Add(checklist);
                }
            }

            else if (menuItem == "2") 
            {
                Console.WriteLine("The goals are:");
                foreach(Goal goal in goals)
                {
                    int goalNum = goals.IndexOf(goal) + 1;
                    Console.Write($"{goalNum}. ");
                    goal.DisplayGoal();
                }
            }

            else if (menuItem == "3") 
            {
                Console.Write("What is the filename for the goal file? ");

                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine($"{points}");
                }    

                foreach (Goal goal in goals)
                {
                    using (StreamWriter outputFile = new StreamWriter(fileName, true))
                    {
                        outputFile.WriteLine($"{goal.FormatGoal()}");
                    }
                }
            }
            

            else if (menuItem == "4") 
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                goals.Clear();

                if (File.Exists(fileName))
                {
                    points = int.Parse(lines[0]);

                    foreach(string line in lines[1..])
                    {
                        string[] sections = line.Split(":");
                        string[] listInfo = sections[1].Split(",");


                        if (sections[0] == "SimpleGoal")
                        {
                            string name = listInfo[0];
                            string description = listInfo[1];
                            int score = int.Parse(listInfo[2]);
                            bool isComplete = bool.Parse(listInfo[3]);

                            SimpleGoals simple = new SimpleGoals(name, description, score, isComplete);
                            goals.Add(simple);
                        }

                        else if (sections[0] == "EternalGoal")
                        {
                            string name = listInfo[0];
                            string description = listInfo[1];
                            int score = int.Parse(listInfo[2]);

                            EternalGoals eternal = new EternalGoals(name, description, score);
                            goals.Add(eternal);
                        }

                        else if (sections[0] == "ChecklistGoal")
                        {
                            string name = listInfo[0];
                            string description = listInfo[1];
                            int score = int.Parse(listInfo[2]);
                            int bonusPoints = int.Parse(listInfo[3]);
                            int amountForBonus = int.Parse(listInfo[4]);
                            int timesCompleted = int.Parse(listInfo[5]);

                            ChecklistGoals checklist = new ChecklistGoals(name, description, score, bonusPoints, amountForBonus, timesCompleted);
                            goals.Add(checklist);
                        }

                        if (points >= 100 && points <= 199)
                        {
                            level = 2;
                        }
                        
                        else if (points >= 200 && points <= 299)
                        {
                            level = 3;
                        }

                         else if (points >= 300 && points <= 399)
                        {
                            level = 4;
                        }

                         else if (points >= 400 && points <= 499)
                        {
                            level = 5;
                        }

                         else if (points >= 500 )
                        {
                            level = 6;
                        }
                    }
                }

                else
                {
                    Console.WriteLine("This file does not exist.");
                }
            }

            else if (menuItem == "5") 
            {
                Console.WriteLine("The goals are: ");
                
                foreach (Goal goal in goals)
                {
                    int goalNum = goals.IndexOf(goal) + 1;
                    string name = goal.GetName();
                    Console.WriteLine($"{goalNum}. {name}");
                    goal.IsComplete();
                }

                Console.Write("Which goal did you accomplish? ");
                int num = int.Parse(Console.ReadLine());

                int oldScore = points;

                num -= 1;
                int pointValue = goals[num].RecordEvent();
                points += pointValue;
                
                Console.WriteLine($"Congratulations! You have earned {pointValue} points!");
                Console.WriteLine($"You now have {points} points.");

                int oldLevel = level;
                if (points >= 100 && points <= 199)
                {
                    level = 2;
                    if (oldLevel != level)
                    {
                        Console.WriteLine("You have leveled up to level 2!");
                    }
                }

                else if (points >= 200 && points <= 299)
                {
                    level = 3;
                    if (oldLevel != level)
                    {
                        Console.WriteLine("You have leveled up to level 3!");
                    }
                }

                else if (points >= 300 && points <= 399)
                {
                    level = 4;
                    if (oldLevel != level)
                    {
                        Console.WriteLine("You have leveled up to level 4!");
                    }
                }

                else if (points >= 400 && points <= 499)
                {
                    level = 5;
                    if (oldLevel != level)
                    {
                        Console.WriteLine("You have leveled up to level 5!");
                    }
                }

                else if (points >= 500)
                {
                    level = 6;
                    if (oldLevel != level)
                    {
                        Console.WriteLine("You have reached 500 points! You are now level 6 and have reached the max level.");
                    }
                }
            }
        }
    }
}