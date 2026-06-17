// Author = Oladele Blessed
// Creativity = 1. Addtion of a full list redundancy mitigation to ReflectionActivity & ListingActivity. Also ensuring the Prompts/Questions do not loop or match previous choices until clean structural reset triggers.
// 2. Added dynamic pacing text countdown frames matching standard user breathing mechanics.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case "4":
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid entry. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}