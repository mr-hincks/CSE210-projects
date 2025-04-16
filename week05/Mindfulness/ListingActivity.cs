using System;
using System.Collections.Generic;
using System.IO;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _remainingPrompts;
    private List<string> _itemsListed = new List<string>();
    private string _logFile = "listing_activity_log.txt";

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        InitializePrompts();
        Console.ForegroundColor = ConsoleColor.Green;
    }

    private void InitializePrompts()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you acheived today?",
            "Who are some of your personal heroes?",
            "What are you grateful for today?",
            "What made you smile recently?",
            "What challenges have you overcome?"
        };
        ResetRemainingPrompts();
    }

    private void ResetRemainingPrompts()
    {
        _remainingPrompts = new List<string>(_prompts);
        Shuffle(_remainingPrompts);
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        string prompt = GetUniquePrompt();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        
        Console.Write("You may begin in: ");
        ShowAnimatedCountdown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        _itemsListed.Clear();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                _itemsListed.Add(item);
                Console.WriteLine($"\x1B[1A> {item} ✓"); // Show checkmark
            }
        }

        SaveSessionToLog(prompt);
        DisplayResults();
        DisplayEndingMessage();
    }

    private string GetUniquePrompt()
    {
        if (_remainingPrompts.Count == 0)
        {
            ResetRemainingPrompts();
            Console.WriteLine("\nAll prompts have been used! Recycling prompts...\n");
        }
        
        string prompt = _remainingPrompts[0];
        _remainingPrompts.RemoveAt(0);
        return prompt;
    }

    private void ShowAnimatedCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.Write("  \b\b");
    }

    private void DisplayResults()
    {
        Console.WriteLine($"\nYou listed {_itemsListed.Count} items!");
        
        if (_itemsListed.Count > 0)
        {
            Console.WriteLine("\nYour items:");
            foreach (var item in _itemsListed)
            {
                Console.WriteLine($"- {item}");
            }
        }
        
        // Encouragement based on performance
        if (_itemsListed.Count >= 10)
            Console.WriteLine("\nAmazing flow of ideas! You're very reflective.");
        else if (_itemsListed.Count >= 5)
            Console.WriteLine("\nGood job! You're building mindfulness skills.");
        else
            Console.WriteLine("\nEvery reflection counts. Keep practicing!");
    }

    private void SaveSessionToLog(string prompt)
    {
        try
        {
            using (StreamWriter writer = File.AppendText(_logFile))
            {
                writer.WriteLine($"{DateTime.Now:g}");
                writer.WriteLine($"Prompt: {prompt}");
                writer.WriteLine($"Items listed: {_itemsListed.Count}");
                writer.WriteLine("------------------");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Could not save log: {ex.Message}");
        }
    }

    private void Shuffle<T>(IList<T> list)
    {
        Random rng = new Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}