public class Entry{
    
    private string _dateOfEntry;
    private string _userEntry;
    private string _promptUsed;

    List<string> prompts = [
    "What was the best part of your day?", 
    "Who do you wish you'd been able to see today?",
    "How did you feel guided by the Lord today?",
    "What is something you wish you could have changed about today?",
    "What are you looking forward to tomorrow?",
    "What are some goals that you would like to set after today?"
    ];

    public Entry(string dateOfEntry)
    {
        _dateOfEntry = dateOfEntry;
    }

    public Entry(string dateOfEntry, string userEntry, string promptUsed)
    {
        _dateOfEntry = dateOfEntry;
        _userEntry = userEntry;
        _promptUsed = promptUsed;
    }

    public string GetRandomPrompt()
    {
        int i = Random.Shared.Next(prompts.Count());
        return prompts[i];
    }
    
    public string GetEntryString()
    {
        return $"Prompt: {_promptUsed} on {_dateOfEntry} - {_userEntry}";
    }

    public void SaveEntry(string userEntry, string promptUsed)
    {
        _userEntry = userEntry;
        _promptUsed = promptUsed;
    }

    public string GetEntryInfoForCSV()
    {
        string entry = $"\"{_promptUsed}\",\"{_dateOfEntry}\",\"{_userEntry}\"";
        string fixedEntry = entry.Replace("\"", "\"\"");
        return fixedEntry;
    }
}
