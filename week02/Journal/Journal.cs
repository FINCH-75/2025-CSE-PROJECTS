    // Created the class Journal.
public class Journal()
{
    // Created a list of _entries so the Journal can keep track and store them.
    public List<Entry> _entries = new List<Entry>();

    // Created an AddEntry method so the Journal can store.
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);

    }

    // Created a DisplayAll method so the journal program can look through the journal and see if there are entrys and if so display them.
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the Journal");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // created a method to safe the users entry to a file.
    public void SaveToFile(string file)
    {
        using (StreamWriter sw = new StreamWriter(file, true))
        {
            foreach (var entry in _entries)
            {
                sw.WriteLine($"{entry._date}|{entry._prompt}|{entry._entryText}");
            }
            
        }
        Console.WriteLine("\nJournal saved successfully!");
    }

    // Created a method so the user can load the file to view it.
    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine($"{file} does not exist.");
            return ;
        }
        _entries.Clear();

        foreach (var line  in File.ReadAllLines(file))
        {
            var parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry  = new Entry();
                {
                   entry._date = parts[0];
                   entry._prompt = parts[1];
                   entry._entryText=parts[2]; 
                }
                _entries.Add(entry);
            }
                

        };
        Console.WriteLine("\nJournal loaded successfully!");
        
    }
    
}
