public class Journal
{
    private string _userName = "No Username yet";
    private string _fileName = "File not yet saved!!";


    
    List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        Console.WriteLine($"You are in {_fileName} and these entries were written by {_userName}");

        foreach (Entry e in entries)
        {
            string entryString = e.GetEntryString();
            Console.WriteLine(entryString);
            Console.WriteLine();
        }
    }
    
    public void SaveJournal()
    {
        Console.WriteLine("What should the file be called?");
        _fileName = Console.ReadLine();
        Console.WriteLine("What is your name?");
        _userName = Console.ReadLine();
        //put name on the first line
        List<string> csvLines = [$"{_userName},"];
        
        
        foreach (Entry e in entries)
        {
            string entryString = e.GetEntryInfoForCSV();
            csvLines.Add(entryString);

        }

        File.WriteAllLines(_fileName, csvLines);

    }

    public void ReadFile()
    {   
        entries.Clear();

        string[] lines = File.ReadAllLines(_fileName);
        //get name from the first line
        _userName = lines[0];

        //make it so that it skips the first line
        for(int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            

            string[] splitLines = line.Split(",");
            

            string dateOfEntry = splitLines[1].Replace("\"\"","").Trim('"');
            string userEntry = splitLines[2].Replace("\"\"","").Trim('"');
            string promptUsed = splitLines[0].Replace("\"\"","").Trim('"');


            Entry entry = new Entry(dateOfEntry, userEntry, promptUsed);
            entries.Add(entry);

        }

    }
    
    public void LoadNewJournal()
    {
        Console.WriteLine("What is the name of your saved file?");
        _fileName = Console.ReadLine();

        ReadFile();

        Console.WriteLine("File loaded!");
    }

}