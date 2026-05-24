public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private bool _isDone = false;
    private int _pointsWorth;

    

    public Goal()
    {
       
    }

    public Goal(string goalName, string goalDescription, bool isDone, int pointsWorth)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _isDone = isDone;
        _pointsWorth = pointsWorth;
    }

    public virtual void GetGoalInfo()
    {
        Console.WriteLine("What is the goal name?");
        _goalName = Console.ReadLine();
        Console.WriteLine("Give a brief description of the goal");
        _goalDescription = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth?");
        _pointsWorth = int.Parse(Console.ReadLine());
    }

    public virtual string ConvertGoalInfoToString()
    {
        string description = $"{_goalName},{_goalDescription},{_isDone},{_pointsWorth}, ,";
        return description;
    }

    public virtual int GetPointWorth()
    {
        return _pointsWorth;
    }

    public virtual void CompleteGoal()
    {
        _isDone = true;
    }


    

}