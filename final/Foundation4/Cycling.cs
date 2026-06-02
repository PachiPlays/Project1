public class Cycling : Activity
{
    private int _speed;
    
    public Cycling(string date, int activityLength, int speed) : base(date, activityLength)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        double length = GetActivityLength();
        double distance = _speed * length / 60;
        return distance;
    }

    public override double CalculatePace()
    {
        double length = GetActivityLength();
        double distance = CalculateDistance();
        double pace = length / distance;
        return pace;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }
}