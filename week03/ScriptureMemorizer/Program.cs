using System;

// Author = Oladele Blessed
// Creativity = Optimization in Scripture.cs (specifically complies strecth challenge), active complilation of tracking list of non-hidden word indices.
// Ensuring the random selector never wastes iterations guessing words that are already obscured, there by maintaining a clean, snappy interface response (till every word is cleared).

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the LORD with all your heart. Never rely on what you think you know.";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press enter to hide more words or type 'quit' to end:");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}