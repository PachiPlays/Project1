using System.Collections.Concurrent;
using System.Data;
using System.Diagnostics.Contracts;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private string _range;
    private string _fullReference;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _range = "";
    }

    public Reference(string book, int chapter, string range)
    {
        _book = book;
        _chapter = chapter;
        _verse = 0;
        _range = range;
        
    }

    public string GetReference()
    {
        if(_verse == 0){
        _fullReference = $"{_book} {_chapter}:{_range}";
        }
        else
        {
            _fullReference = $"{_book} {_chapter}:{_verse}";
        }
        string refToGet = _fullReference;
        return refToGet;
    }



}