using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity: ");

            string choice = Console.ReadLine();

            if (choice == "4") break;

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                _ => null
            };

            if (activity != null)
            {
                if (activity is BreathingActivity breathing)
                    breathing.Run();
                else if (activity is ReflectionActivity reflection)
                    reflection.Run();
                else if (activity is ListingActivity listing)
                    listing.Run();
            }
        }
    }
}