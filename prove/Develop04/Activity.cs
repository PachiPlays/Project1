using System.Runtime.CompilerServices;
using System.Threading;
public class Activity
{
    private string _description;
    private string _endingPrompt;
    private int _length;
    private string _activityName;




public Activity(string activityName, string description)
{
    _activityName = activityName;
    _description = description;
    
}


public void DisplayLoadingIcon(int loadtime)
    {
        int y = 0;

        while (y < loadtime)
        {
        int x = 500;
        Console.WriteLine("/");
        Thread.Sleep(x);
        Console.Clear();
        Console.WriteLine("|");
        Thread.Sleep(x);
        Console.Clear();
        Console.WriteLine("\\");
        Thread.Sleep(x);
        Console.Clear();
        Console.WriteLine("─");
        Thread.Sleep(x);
        Console.Clear();
        y+=2;
        }
    }
public void DisplayStartingPrompt()
    {
        Console.WriteLine(_description);
        Console.WriteLine("How long do you want this activity to be? (enter your answer in seconds)");
        int duration = int.Parse(Console.ReadLine());
        SetLength(duration);
        Console.WriteLine("Please prepare to begin!");
        Thread.Sleep(3000);
    }
public void DisplayEndingPrompt()
    {

        _endingPrompt = $"Great job! You did the {_activityName} for {_length} seconds! Feel free to try another activity or redo the same one!";
        Console.WriteLine(_endingPrompt);
    }

public void SetLength(int x)
    {
        _length = x;
    }
public int GetLength()
    {
    int x = _length;
    return x;
    }
public void SetDescription(string x)
    {
        _description = x;
    }
public string GetDescription()
    {
        return _description;
    }


}