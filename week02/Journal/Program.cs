using System;

// Creativity: I included more prompts, I also improved the display formatting,
// and used a loop menu.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("Choose: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGen.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");

                string text = Console.ReadLine();

                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = text;

                journal.AddEntry(entry);
            }

            else if (choice == 2)
            {
                journal.Display();
            }

            else if (choice == 3)
            {
                Console.Write("File name: ");
                string file = Console.ReadLine();

                journal.SaveToFile(file);
            }

            else if (choice == 4)
            {
                Console.Write("File name: ");
                string file = Console.ReadLine();

                journal.LoadFromFile(file);
            }
        }
    }
}