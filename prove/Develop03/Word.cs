class Word
{
    
    private string _wordText;
    private bool _isHidden;

    public Word(string wordText)
    {
        _wordText = wordText;
    }
    
    public void HideWord()
    {
        _isHidden = true;

        string hiddenWord = new string('_', _wordText.Length);
        _wordText = hiddenWord;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public string GetWordText()
    {
        return _wordText;
    }

}