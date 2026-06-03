
class Scripture
{
    
    private string _scripture;
    private Reference _reference;

    List<Word> words = new List<Word>();

    public Scripture(string scripture, Reference reference)
    {
        _scripture = scripture;
        _reference = reference;

        string[] splitScripture = _scripture.Split(" ");

        foreach(string word in splitScripture)
        {
            Word W = new Word(word);
            words.Add(W);
        }
    
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference.GetRefAsString());
        _scripture = "";
        foreach(Word word in words)
        {
            _scripture += word.GetWordText();
            _scripture += " ";
        }
        Console.WriteLine(_scripture);
    }

    public void DisplayScriptureWithHiddenWords()
    {   
        int x = 1;
        
        for(int i = 1; i < 5; i++)
        {
            int y = Random.Shared.Next(words.Count());
            if(words[y].GetIsHidden() != true)
            {
               words[y].HideWord(); 
            }
            else
            {
                i -= 1;

                x += 1;
                if(x == words.Count() * 3)
                {
                    break;
                }
            }
        }
        DisplayScripture();
    }

    public int GetNumberOfHiddenWords()
    {
        int x = 0;
        foreach (Word word in words)
        {
            if (word.GetIsHidden() != true)
            {
                x += 1;
            }
        }
        return x;
    }
}