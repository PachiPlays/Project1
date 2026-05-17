using System.Diagnostics;
class ListingActivity : Activity
{
    List<string> listOfEntries = new List<string>();
        List<string> listOfPrompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?"
,"Who are some of your personal heroes?"};
    public ListingActivity(string _activityName, string _description) : base(_activityName, _description)
    {
        
        
    }

    public void DisplayPrompt(int length)
    {

    Random random = new Random();
    int x = random.Next(0, 4);

    Console.WriteLine("This is your prompt!");
    Console.WriteLine(listOfPrompts[x]);

    Thread.Sleep(7000);
    Stopwatch timer = new Stopwatch();
    timer.Start();

    while (timer.Elapsed.TotalSeconds < length)
        {
            Console.WriteLine("List an item!");
            string z = Console.ReadLine();
            listOfEntries.Add(z);
            Console.Clear();

        }
        timer.Stop();
    }


    public void DisplayUserEntries()
    {
        Console.WriteLine("This is your list!!");
        foreach (string x in listOfEntries)
        {
            Thread.Sleep(250);
            Console.WriteLine(x);
        }
    }


}