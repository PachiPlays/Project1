using System.Drawing;

public class EternalGoal : Goal
{
    
    public EternalGoal()
    {
        
    }

    public EternalGoal(string goalName, string goalDescription, bool isDone, int pointsWorth) 
    : base(goalName, goalDescription, isDone, pointsWorth)
    {
        
    }

    public override string ConvertGoalInfoToString()
    {
        string x = base.ConvertGoalInfoToString();
        return "EternalGoal:" + x;
    }

    public override void CompleteGoal()
    {
        
    }

}