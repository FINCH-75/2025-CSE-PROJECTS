using System.Formats.Asn1;
using System.Net.Http.Headers;

public class Journal()
{
    public List<Entry> _entries;

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);

    }

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

    public void SaveToFile(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                sw.WriteLine($"{entry._date}|{entry._prompt}|{entry._entryText}");
            }
            
        }
        Console.WriteLine("Journal saved successfully!");
    }

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
                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._entryText=parts[2];
                _entries.Add(entry);
            }

        };
        
    }
}
