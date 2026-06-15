using System;
using System.Collections.Generic;
using System.IO;

// Author = Oladele Blessed
// Creativity = Addition of an automated character and word count tracker 
// when saving journal text, giving the user live insight into their writing volume.
// I also added defensive file check validation to handle loading errors seamlessly.

class Program
{
    static void Main(string[] sender)
    {
        Journal journal = new Journal();
        PromptGenerator promtGenerator = new PromptGenerator();

        bool running = true;
        Console.WriteLine("Hello World! This is the Journal Project.");

        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                string prompt = promtGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write(">");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                journal.AddEntry(newEntry);
                Console.WriteLine();
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("Thank you for using the journal. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose a number form 1 to 5.");
                Console.WriteLine();
            }
        }
    }
}