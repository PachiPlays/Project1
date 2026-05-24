class SimpleGoal : Goal
{

    public SimpleGoal()
    {
        
    }

    public SimpleGoal(string goalName, string goalDescription, bool isDone, int pointsWorth) 
    : base(goalName, goalDescription, isDone, pointsWorth)
    {
        
    }

    public override string ConvertGoalInfoToString()
    {
        string x = base.ConvertGoalInfoToString();
        return "SimpleGoal:" + x;
    }
}