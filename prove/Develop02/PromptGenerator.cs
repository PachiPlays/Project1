using System.Security.Cryptography.X509Certificates;




public class Prompt
{
    
    

    string _promptString1 = "What was the best part of your day?";   
    string _promptString2 = "Who do you wish you'd been able to see today?"; 
    string _promptString3 = "How did you feel guided by the Lord today?";
    string _promptString4 = "What is something you wish you could have changed about today?";
    string _promptString5 = "What are you looking forward to tomorrow?";
    string _promptString6 = "What are some goals that you would like to set after today?";

    


    static Random rng = new Random();
        
    public int x = rng.Next(6);
    
    

    public int _promptNumber;

    public List<string> _listOfPrompts = new List<string>();

    
    void StorePrompt()
    {
        _listOfPrompts.Add(_promptString1);
        _listOfPrompts.Add(_promptString2);
        _listOfPrompts.Add(_promptString3);
        _listOfPrompts.Add(_promptString4);
        _listOfPrompts.Add(_promptString5);
        _listOfPrompts.Add(_promptString6);
    }

    

    public void GeneratePrompt()
    {
              
        StorePrompt();

        x = rng.Next(6);
        
        Console.WriteLine($"{_listOfPrompts[x]} -- (Prompt {x+1})");
        


    }


}