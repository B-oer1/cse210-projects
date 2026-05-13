using System;

Console.WriteLine("Hello World! This is the Exercise3 Project.");
// Console.Write("What is the magic number? ");
// int magicNumber = int.Parse(Console.ReadLine());

Random randomGenerator = new Random();
int magicNumber = randomGenerator.Next(1, 101);

int guess = 0;
do
{
    Console.Write("What is your guess? ");
    guess = int.Parse(Console.ReadLine());

    if (magicNumber > guess)
    {
        Console.WriteLine("Higher");
    }
    else if (magicNumber < guess)
    {
        Console.WriteLine("Lower");
    }
    else
    {
        Console.WriteLine("You guessed it, right!");
    }
} while (guess != magicNumber);