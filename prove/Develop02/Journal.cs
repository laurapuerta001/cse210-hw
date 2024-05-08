public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Load()
    {
        Console.WriteLine("What is the file name?");
        string filename = Console.ReadLine();

        _entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines)  
        {
            string[] parts = line.Split(" - ");
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._response = parts[2];

               AddEntry(entry);
            
        }
        
    }

    public void Save()
    {
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();

        using StreamWriter outputFile = new StreamWriter(fileName);
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} - {entry._prompt} - {entry._response}");
            }
        }
        
        outputFile.Close();
        Console.WriteLine("Journal saved");
    }


}