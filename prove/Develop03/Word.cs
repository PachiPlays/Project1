using System.ComponentModel;
using System.Reflection.PortableExecutable;
using System.Text;

class Word
{
    
    private string _word;
    private bool _isHidden;



    public List<string> GetList(string scripture)
    {
        List<string> list = new List<string>();
       string [] split = scripture.Split(new char[] {}, StringSplitOptions.RemoveEmptyEntries);
        
        foreach(string w in split)
        {
            list.Add(w);
        }

        return list;
    }

   /* public string HideWord(List<string> list, int numToHide)
    {
    StringBuilder newString = new StringBuilder();
    StringBuilder sb = new StringBuilder();

    
    
    int y = numToHide;
      foreach (string w in list)
        {
            
            int i = w.Length;
        
                if(y == 6)
                {
                    for(int t = 0; t < i; t++)
                    {
                sb.Append('-');
                    y = 1;
                    }
                    
                    
                }
                else
                {
                    sb.Append(w);
                    y++;
                }
                
            
           
            
            
            sb.Append(' ');
            newString.Append(sb);
            sb.Clear();
           
            
            
        }
    string finalString = newString.ToString();
    return finalString;

    }*/



    public void SetWord(string word)
    {
        _word = word;
    }
    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }
    public string GetWord()
    {
        
        StringBuilder sb = new StringBuilder();
        if (_isHidden == true)
        {
            foreach(char c in _word)
            {
                sb.Append('-');
            }
            string w1 = sb.ToString();
            return w1;
        }

        else
        {
            return _word;
        }
    }
    public bool GetIsHidden()
    {
        return _isHidden;
    }

}