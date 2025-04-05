using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
{
    Scripture scripture = LoadRandomScripture("scripture.txt");

    while (!scripture.IsCompletelyHidden())
    {
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
        string input = Console.ReadLine().ToLower();

        if (input == "quit") break;

        scripture.HideRandomWords(3);
    }

    Console.Clear();
    Console.WriteLine(scripture.GetDisplayText());
    Console.WriteLine("\nAll words are now hidden. Goodbye!");
}

// Load a random scripture from the file
static Scripture LoadRandomScripture(string scripture)
{
    // Read lines and pick a random one
    string[] lines = File.ReadAllLines(scripture);
    Random rand = new Random();
    string line = lines[rand.Next(lines.Length)];

    // Expected format: "Book Chapter:Verse Text..."
    string[] parts = line.Split(' ');
    string book = parts[0];
    string[] chapterAndVerse = parts[1].Split(':');
    int chapter = int.Parse(chapterAndVerse[1]);

    Reference reference;

    if (chapterAndVerse[1].Contains("-"))
    {
        string[] verses = chapterAndVerse[1].Split('-');
        reference = new Reference(book, chapter, int.Parse(verses[0]), int.Parse(verses[1]));
    }
    else
    {
        reference = new Reference(book, chapter, int.Parse(chapterAndVerse[1]));
    }

    // Join the rest as scripture text
    string text = string.Join(" ", parts.Skip(2));
    return new Scripture(reference, text);
}

}