using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Text;


class Scripture
{
    
    private string _scripture;

    public Scripture(string scripture)
    {
        _scripture = scripture;
    }

    List<Word> words = new List<Word>();
    
    public void SetScripture(string scrip)
    {
        _scripture = scrip;
    }
    public string GetScripture()
    {
        string scrip = _scripture;
        return scrip;
    }


    /*public string GetHiddenScripture(int numToHide)
    {
        Word w = new Word();
        List<string> list = w.GetList(_scripture);
        string hiddenScripture = w.HideWord(list, numToHide);

        return hiddenScripture;
    }*/

    public void SplitScripture()
    {
        
        StringBuilder sb = new StringBuilder();
        
        string [] split = _scripture.Split(new char[] {}, StringSplitOptions.RemoveEmptyEntries);
        foreach(string s in split)
        {
            Word w = new Word();
            w.SetWord(s);
            w.SetIsHidden(false);
            words.Add(w);
        }

        /*foreach(Word w in words)
        {
            string w1 = w.GetWord();
            sb.Append(w1);
            sb.Append(' ');
        }
        string finalString = sb.ToString();*/
        
    }

    public string HideWords(int num, out bool isDone)
    {
        int y = num;
        int x = 0;

        StringBuilder sb = new StringBuilder();
        foreach(Word w in words)
        {
            if(y == 5)
            {
                w.SetIsHidden(true);
                y = 0;
            }

            string w1 = w.GetWord();
            sb.Append(w1);
            sb.Append(' ');
            y++;
            
            bool isHidden = w.GetIsHidden();
            if(isHidden == false)
            {
                x++;
                isDone = false;
            }
            
        }

        if(x == 0)
        {
            isDone = true;
        }
        else
        {
            isDone = false;
        }

        string finalString = sb.ToString();
        return finalString;


    }
    
    

    

}