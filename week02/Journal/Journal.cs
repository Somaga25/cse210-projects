using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter output = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                output.WriteLine($"{e._date}|{e._promptText}|{e._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry e = new Entry();

            e._date = parts[0];
            e._promptText = parts[1];
            e._entryText = parts[2];

            _entries.Add(e);
        }
    }
}