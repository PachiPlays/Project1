

public class CheckListGoal : Goal
{
    private int _completionsForBonus;
    private int _pointsForBonus;
    private int _totalCompletions;

    
    public CheckListGoal()
    {
        
    }

    public CheckListGoal(string goalName, string goalDescription, bool isDone, int pointsWorth, 
    int completitionsForBonus, int pointsForBonus, int totalCompletions) 
    : base(goalName, goalDescription, isDone, pointsWorth)
    {
        _completionsForBonus = completitionsForBonus;
        _pointsForBonus = pointsForBonus;
        _totalCompletions = totalCompletions;
    }
    
    public override void GetGoalInfo()
    {
        base.GetGoalInfo();
        Console.WriteLine("How many times do you want to complete this goal for a bonus?");
        _completionsForBonus = int.Parse(Console.ReadLine());
        Console.WriteLine("How many points should the bonus be worth?");
        _pointsForBonus = int.Parse(Console.ReadLine());
    }

    public override string ConvertGoalInfoToString()
    {
        string description = base.ConvertGoalInfoToString();
        string description2 = $",{_pointsForBonus}, - {_totalCompletions} out of {_completionsForBonus}";
        string description3 = description + "," + description2;
        return "CheckListGoal:" + description3;
    }

    public override int GetPointWorth()
    {
        int ogPoints = base.GetPointWorth();
        if (_totalCompletions == _completionsForBonus)
        {
            int totalPoints = ogPoints + _pointsForBonus;
            return totalPoints;
        }
        else
        {
            return ogPoints;
        }



        
    }

    public override void CompleteGoal()
    {
        _totalCompletions += 1;
        if(_completionsForBonus == _totalCompletions)
        {
            base.CompleteGoal();
        }
        
    }
}