using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _unusedPrompts;

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt peace or inspiration this month?",
            "Who are some of your personal heroes?"
        };
        _unusedPrompts = new List<string>(_prompts);
    }

    private string GetRandomPrompt()
    {
        if (_unusedPrompts.Count == 0)
        {
            _unusedPrompts = new List<string>(_prompts);
        }
        Random random = new Random();
        int index = random.Next(_unusedPrompts.Count);
        string prompt = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);
        return prompt;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many items as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
        Console.Write("You may begin in: ");
        DisplayCountDown(5);
        Console.WriteLine();

        List<string> userItems = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                Console.Write("> ");
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                {
                    userItems.Add(item);
                }
            }
            else
            {
                System.Threading.Thread.Sleep(100);
            }
        }

        Console.WriteLine($"\nYou listed {userItems.Count} items!");
        DisplayEndingMessage();
    }
}