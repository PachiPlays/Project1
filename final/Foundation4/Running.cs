public class Running : Activity
{
    private int _distance;

    public Running(string date, int activityLength, int distance) : base(date, activityLength)
    {
        _distance = distance;
    }

    public override double CalculateSpeed()
    {
        double length = GetActivityLength();
        double speed = _distance / length * 60;
        return speed;
    }

    public override double CalculatePace()
    {   
        double length = GetActivityLength();
        double pace = length / _distance;
        return pace;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }


}