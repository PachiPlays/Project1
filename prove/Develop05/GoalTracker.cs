

public class GoalTracker()
{

    private int _totalPoints;
    List<Goal> listOfGoals = new List<Goal>();
    

    public void AddGoal(Goal goal)
    {
        listOfGoals.Add(goal);
    }

    public void SaveFile()
    {
        Console.WriteLine("What do you want the name of your file to be?");
        string filename = Console.ReadLine();
        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine(_totalPoints);
            foreach (Goal goal in listOfGoals)
            {
                string x = goal.ConvertGoalInfoToString();
                file.WriteLine(x);
            }
        }
        
    }

    public void DisplayGoals()
    {
        int y = 0;
        foreach (Goal goal in listOfGoals)
        {   string x = goal.ConvertGoalInfoToString();
            string[] p = x.Split(":");
            string pSplit = p[1];
            string[] parts = pSplit.Split(",");
            
            if(parts[2] == "False")
            {
                Console.WriteLine($"{y+1}. [ ] {parts[0]} ({parts[1]}) {parts[5]}");
            }
            else
            {
                Console.WriteLine($"{y+1}. [X] {parts[0]} ({parts[1]}) {parts[5]}");
            }
            y+=1;
            
        }
    }

    public void AddPoints(int pointsToAdd)
    {
        _totalPoints += pointsToAdd;
    }

    public void MarkComplete(int x)
    {
        listOfGoals[x].CompleteGoal();
        AddPoints(listOfGoals[x].GetPointWorth());
    }

    public void DisplayPoints()
    {
        Console.WriteLine($"You have {_totalPoints} points!");
    }

    public void LoadFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _totalPoints = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] split1 = line.Split(":");
            string objectType = split1[0];

            string[] split = split1[1].Split(",");
            
            if (objectType == "SimpleGoal")
            {
                SimpleGoal S1 = new SimpleGoal(split[0], split[1], bool.Parse(split[2]), int.Parse(split[3]));
                AddGoal(S1);
            }

            else if(objectType == "EternalGoal")
            {
                EternalGoal E1 = new EternalGoal(split[0], split[1], bool.Parse(split[2]), int.Parse(split[3]));
                AddGoal(E1);
            }

            else if(objectType == "CheckListGoal")
            {
                CheckListGoal C1 = new CheckListGoal(split[0], split[1], bool.Parse(split[2]), int.Parse(split[3]), 
                int.Parse(split[4]), int.Parse(split[5]), int.Parse(split[6]));
                AddGoal(C1);
            }


        }

    }
}