using System;
using System.Collections.Generic;
using System.IO;

public class GeneratePrompt
{
    private List<string> _prompts = new List<string>
    {
        "Who new did you meet today?",
        "What could you have done better?",
        "Have you done any good today? ",
        "Did you call any of your family relatives today? ",
        "What made you smile today?",
        "What challenge did you face today."
    };
    private Random _random = new Random();
    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)]; 
    }

}