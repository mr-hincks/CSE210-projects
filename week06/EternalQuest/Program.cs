class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string filename = "goals.txt";

        DisplayWelcomeMessage();

        while (true)
        {
            Console.Clear();
            DisplayMenu();
            Console.Write("\nSelect an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.CreateGoal();
                    break;
                case "2":
                    manager.ListGoals();
                    break;
                case "3":
                    manager.RecordEvent();
                    break;
                case "4":
                    manager.DisplayScore();
                    break;
                case "5":
                    manager.SaveGoals(filename);
                    break;
                case "6":
                    manager.LoadGoals(filename);
                    break;
                case "7":
                    Console.WriteLine("\nGoodbye! Keep working on your eternal quest!");
                    return;
                default:
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("\nWelcome to the Eternal Quest Goal Tracker!");
        Console.WriteLine("This program will help you track your goals and progress.");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nEternal Quest - Main Menu");
        Console.WriteLine("══════════════════════════");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Record Event");
        Console.WriteLine("4. Display Score");
        Console.WriteLine("5. Save Goals");
        Console.WriteLine("6. Load Goals");
        Console.WriteLine("7. Exit");
    }
}