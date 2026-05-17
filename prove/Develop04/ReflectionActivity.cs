
using System.Security.Cryptography.X509Certificates;

class ReflectionActivity : Activity
{
    List<string> listOfPrompts = new List<string>();
    List<string> listOfQuestions = new List<string>();
    

    public ReflectionActivity(string _activityName, string _description) : base(_activityName, _description)
    {
    
    }

    public void DisplayRandomPrompt()
    {
        Random random = new Random();
        int r = random.Next(0, 4);

        listOfPrompts.Add("Think of a time when you stood up for someone else.");
        listOfPrompts.Add("Think of a time when you did something really difficult.");
        listOfPrompts.Add("Think of a time when you helped someone in need.");
        listOfPrompts.Add("Think of a time when you did something truly selfless.");

        string f = listOfPrompts[r];
        Console.WriteLine(f);
        Thread.Sleep(7000);
    }

    public void DisplayQuestions(int length)
    {
        Random random = new Random();
        listOfQuestions.Add("Why was this experience meaningful to you?");
        listOfQuestions.Add("Have you ever done anything like this before?");
        listOfQuestions.Add("How did you get started?");
        listOfQuestions.Add("How did you feel when it was complete?");
        listOfQuestions.Add("What made this time different than other times when you were not as successful?");
        listOfQuestions.Add("What is your favorite thing about this experience?");
        listOfQuestions.Add("What could you learn from this experience that applies to other situations?");
        listOfQuestions.Add("What did you learn about yourself through this experience?");
        listOfQuestions.Add("How can you keep this experience in mind in the future?");
        
        int x = 0;
        int y = 0;
        while(y < length){
            int r = random.Next(0, 9);
            string f = listOfQuestions[r];
        while (x < 7)
        {
            
            Console.WriteLine(f);
            Console.WriteLine("|");
            Thread.Sleep(1000);
            x+=1;
            y+=1;
            Console.Clear();
            Console.WriteLine(f);
            Console.WriteLine("\\");
            Thread.Sleep(1000);
            Console.Clear();
            x+=1;
            y+=1;
            Console.WriteLine(f);
            Console.WriteLine("--");
            Thread.Sleep(1000);
            Console.Clear();
            x+=1;
            y+=1;
            Console.WriteLine(f);
            Console.WriteLine("/");
            Thread.Sleep(1000);
            Console.Clear();
            x+=1;
            y+=1;

        }
        x = 0;
        }
    }



}