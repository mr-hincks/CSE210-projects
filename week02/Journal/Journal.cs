using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }
    public void DisplayAll()
    {
       if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        foreach (var entry in _entries)
        {
            entry.Display();
        }

    }
    
    public void SaveToFile(string file)
    {
         if (_entries.Count == 0)
            {
                Console.WriteLine("Saving to file....");
            }
         string filename = "myJournal.txt";
         using (StreamWriter outputFile = new StreamWriter(filename))
         {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
         }
            
    }
        
    public void LoadFromFile(string file)
    {
        Console.WriteLine("Reding from file....");
        string filename = "myJournal.txt";
        string[]lines =System.IO.File.ReadAllLines(filename);
        foreach(string line in lines)
        {
            string[] parts = line.Split();
             
        }
        
            
        
    }

}