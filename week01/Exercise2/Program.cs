using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int number = int.Parse(gradePercentage);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int remainder = number % 10;
        string sign = "";
        if (remainder >= 7)
        {
            sign = "+";
        }
        else if (remainder < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (letter == "A" || letter == "F")
        {
            Console.WriteLine($"Your grade is: {letter}");
        }
        else
        {
            Console.WriteLine($"Your grade is: {letter}{sign}");
        }

        if (number >= 70)
        {
            Console.WriteLine("Congrulations, you passed!");
        }
        else
        {
            Console.WriteLine("I beleive in you, try again. You've got it!");
        }
    }
}