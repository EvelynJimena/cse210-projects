using System;

Console.Write("What is the magic number? ");
int magicnNumber = int.Parse(Console.ReadLine());

Random randomGenerator = new Random();
int magicNumber = randomGenerator.Next(1, 101);

int guess = -1;

while (guess != magicnNumber)
{
    Console.Write("what is your guess?");
            guess = int.Parse(Console.ReadLine());
    if (magicnNumber > guess)
    {
        Console.WriteLine("higher");
    }
    else if (magicnNumber < guess)
    {
        Console.WriteLine("Lower");
    }
    else
    {
        Console.WriteLine("You guessed it!");
    }
}