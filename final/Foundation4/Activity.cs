public abstract class Activity
{
    private string _date;
    private int _activityLength;
   
    public Activity(string date, int activityLength)
    {
        _date = date;
        _activityLength = activityLength;
    }    

    public string GetSummary()
    {
        string classType = GetType().Name;

        string summary = $"{_date} {classType} ({_activityLength} mins) - Distance {CalculateDistance()} km, Speed {CalculateSpeed()} km/h, Pace {CalculatePace()} minutes per km";
        return summary;
    }   
    public int GetActivityLength()
    {
        return _activityLength;
    }

    public virtual double CalculateSpeed()
    {
        return 0;
    }
    public virtual double CalculatePace()
    {
        return 0;
    }
    public virtual double CalculateDistance()
    {
        return 0;
    }
}