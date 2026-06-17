using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            // Creative breathing expansion text display adjustments
            Console.Write("\nBreathe in... [  ]");
            for (int i = 4; i > 0; i--)
            {
                Console.Write($"\b\b\b {i}]");
                System.Threading.Thread.Sleep(1000);
            }
            Console.Write("\b\b\b\b    \n");

            Console.Write("Now breathe out... [  ]");
            for (int i = 6; i > 0; i--)
            {
                Console.Write($"\b\b\b {i}]");
                System.Threading.Thread.Sleep(1000);
            }
            Console.Write("\b\b\b\b    \n");
        }

        DisplayEndingMessage();
    }
}