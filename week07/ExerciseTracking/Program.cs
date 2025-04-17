class Program
{
    static void Main(string[] args)
    {
        // Create activities
        var activities = new List<Activity>
        {
            new Running(new DateTime(2025, 04, 17), 30, 3.0),
            new Cycling(new DateTime(2025, 04, 17), 30, 15.0),
            new Swimming(new DateTime(2025, 04, 17), 30, 40)
        };

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}