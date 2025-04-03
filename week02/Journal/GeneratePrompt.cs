using System;
using System.Collections.Generic;
using System.IO;

public class GeneratePrompt
{
    public List<string> _prompts = new List<string>
    {
        "Who new did you meet today?",
        "What could you have done better?",
        "Have you done any good today? ",
        "Did you call any of your family relatives today? ",
        "What made you smile today?",
        "What challenge did you face today."
    };
    public Random _random = new Random();
    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)]; 
    }

}