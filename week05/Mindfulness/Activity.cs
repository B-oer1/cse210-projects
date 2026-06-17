using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");

        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Invalid input. Please enter a positive number of seconds: ");
        }

        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(4);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        DisplaySpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        DisplaySpinner(4);
    }

    protected void DisplaySpinner(int seconds)
    {
        List<string> spinnerAnimation = new List<string> { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int counter = 0;
        while (DateTime.Now < endTime)
        {
            string frame = spinnerAnimation[counter % spinnerAnimation.Count];
            Console.Write(frame);
            Thread.Sleep(250);
            Console.Write("\b \b");
            counter++;
        }
    }

    protected void DisplayCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}