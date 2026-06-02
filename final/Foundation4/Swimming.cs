public class Swimming : Activity
{
    private int _lapsSwum;

    public Swimming(string date, int activityLength, int lapsSwum) : base(date, activityLength)
    {
        _lapsSwum = lapsSwum;
    }


    public override double CalculateDistance()
    {   
        double distanceInMeters = _lapsSwum * 50;
        double distance = distanceInMeters / 1000;
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
        double distance = CalculateDistance();
        double length = GetActivityLength();
        double speed = distance * 60 / length;
        return speed;
    }

}