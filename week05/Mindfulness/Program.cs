using System;

/*
EXCEEDING REQUIREMENTS:
1. Added activity tracking system (counts total completed activities).
2. Prevented immediate repetition of prompts/questions in ReflectingActivity.
3. Improved user feedback at the end showing total activities completed.
*/

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        int totalActivities = 0;

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("\nSelect a choice: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                totalActivities++;
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
                totalActivities++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                totalActivities++;
            }
            else if (choice == "4")
            {
                Console.WriteLine("\nGoodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            if (choice != "4")
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }

        Console.WriteLine($"\nYou completed {totalActivities} activities. Great job!");
    }
}