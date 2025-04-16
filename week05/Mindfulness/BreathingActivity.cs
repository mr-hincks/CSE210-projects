using System;
using System.Threading;
using System.Collections.Generic;
using System.Media;

public class BreathingActivity : Activity
{
    private int _sessionsCompleted;
    private List<DateTime> _sessionHistory = new List<DateTime>();
    private List<string> _breathingPatterns = new List<string> 
    {
        "4-6 (Standard)",
        "4-7-8 (Relaxing)",
        "5-5 (Balanced)",
        "3-6 (Extended Exhale)"
    };

    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        Console.ForegroundColor = ConsoleColor.Cyan;
    }

    public void Run()
    {
        DisplayStartingMessage();
        ChooseBreathingPattern();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        _sessionHistory.Add(DateTime.Now);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            AnimateBreathCycle();
        }

        _sessionsCompleted++;
        DisplaySessionStats();
        DisplayEndingMessage();
    }

    private void ChooseBreathingPattern()
    {
        Console.WriteLine("\nAvailable Breathing Patterns:");
        for (int i = 0; i < _breathingPatterns.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_breathingPatterns[i]}");
        }
        Console.Write("Select a pattern (1-4): ");
        int choice = int.Parse(Console.ReadLine()) - 1;
        
        Console.WriteLine($"\nUsing {_breathingPatterns[choice]} pattern...");
        Thread.Sleep(1000);
    }

    private void AnimateBreathCycle()
    {
        // Visual animation with growing/shrinking text
        Console.Write("Breathe in... ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("»");
            Thread.Sleep(800);
            Console.ForegroundColor = (ConsoleColor)((i % 6) + 10); // Cycle colors
        }
        
        Console.Write("\nHold... ");
        ShowSpinner(3);
        
        Console.Write("\nBreathe out... ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write("«");
            Thread.Sleep(800);
            Console.ForegroundColor = (ConsoleColor)((i % 6) + 10);
        }
        Console.WriteLine();
    }

    private void DisplaySessionStats()
    {
        Console.WriteLine("\nSession Statistics:");
        Console.WriteLine($"Total sessions: {_sessionsCompleted}");
        Console.WriteLine("Recent sessions:");
        foreach (var session in _sessionHistory.GetRange(Math.Max(0, _sessionHistory.Count - 3), 
                 Math.Min(3, _sessionHistory.Count)))
        {
            Console.WriteLine($"- {session:g}");
        }
    }
}