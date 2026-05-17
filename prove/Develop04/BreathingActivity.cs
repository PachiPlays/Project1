using System.Runtime.Intrinsics.X86;
using System.Threading;
class BreathingActivity : Activity
{
    
    
public BreathingActivity(string _activityName, string _description) : base(_activityName, _description)
    {
    
    }


public void BeginActivity(int userTime)
    {
        int x = 0;
        while (x < userTime){
        Console.WriteLine("Breathe in for 5 seconds");
        Console.WriteLine("5");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("4");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("3");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("2");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("1");
        Thread.Sleep(1000);
        Console.Clear();
        x+=5;
        Console.WriteLine("Breathe out for 5 seconds");
        Console.WriteLine("5");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("4");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("3");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("2");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("1");
        Thread.Sleep(1000);
        Console.Clear();
        x+=5;
        }

    }

}
