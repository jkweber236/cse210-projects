using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.Write("What is the magic number? ");
        string number = Console.ReadLine();
        int magicNumber = int.Parse(number);
        */

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        int guess = -1;
        int count = 0;

        do
        {
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            guess = int.Parse(guessNumber);

            /*
            To simplify this we could also do:
            guess = int.Parse(Console.ReadLine())
            */

            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if(guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if(guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            count += 1;

        } while (guess != magicNumber);
        Console.WriteLine($"You used {count} guesses.");
    }
}