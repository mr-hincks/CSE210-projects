public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;
    private const int POINTS_PER_LEVEL = 1000;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("\nWhat is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                Console.WriteLine("\nSimple goal created successfully!");
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                Console.WriteLine("\nEternal goal created successfully!");
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                Console.WriteLine("\nChecklist goal created successfully!");
                break;
            default:
                Console.WriteLine("\nInvalid choice");
                break;
        }
        Thread.Sleep(1500);
    }

    public void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo goals available to record.");
            Thread.Sleep(1500);
            return;
        }

        Console.WriteLine("\nWhich goal did you accomplish?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
        Console.Write("Select a goal: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            _goals[choice].RecordEvent();
            int pointsEarned = _goals[choice].GetPoints();
            _score += pointsEarned;
            Console.WriteLine($"\nCongratulations! You earned {pointsEarned} points!");

            // Check for level up
            int newLevel = _score / POINTS_PER_LEVEL + 1;
            if (newLevel > _level)
            {
                _level = newLevel;
                Console.WriteLine($"\nLEVEL UP! You reached level {_level}!");
            }
        }
        else
        {
            Console.WriteLine("\nInvalid goal selection.");
        }
        Thread.Sleep(2000);
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nCurrent Score: {_score} points");
        Console.WriteLine($"Current Level: {_level}");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    public void SaveGoals(string filename)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);
                outputFile.WriteLine(_level);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("\nGoals saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError saving goals: {ex.Message}");
        }
        Thread.Sleep(1500);
    }

    public void LoadGoals(string filename)
    {
        try
        {
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                _score = int.Parse(lines[0]);
                _level = int.Parse(lines[1]);
                _goals.Clear();

                for (int i = 2; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(':');
                    string[] details = parts[1].Split(',');

                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            _goals.Add(new SimpleGoal(
                                details[0], details[1], 
                                int.Parse(details[2]), 
                                bool.Parse(details[3])));
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(
                                details[0], details[1], 
                                int.Parse(details[2]), 
                                int.Parse(details[3])));
                            break;
                        case "ChecklistGoal":
                            _goals.Add(new ChecklistGoal(
                                details[0], details[1], 
                                int.Parse(details[2]),
                                int.Parse(details[4]), 
                                int.Parse(details[3]),
                                int.Parse(details[5])));
                            break;
                    }
                }
                Console.WriteLine("\nGoals loaded successfully!");
            }
            else
            {
                Console.WriteLine("\nNo save file found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError loading goals: {ex.Message}");
        }
        Thread.Sleep(1500);
    }
}