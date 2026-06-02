public class OutdoorGathering : Event
{
    private string _weatherConditions;

    public OutdoorGathering(string title, string description, string date, int time, Address address, string weatherConditions)
    : base(title, description, date, time, address)
    {
        _weatherConditions = weatherConditions;
    }

    public override void DisplayFullDetails()
    {
        Console.WriteLine("This is an outdoor gathering");
        Console.WriteLine($"During this event, the weather conditions will be {_weatherConditions}");
        base.DisplayFullDetails();
    }

    public override void DisplayShortDescription()
    {
        Console.WriteLine("This is an outdoor gathering");
        base.DisplayShortDescription();
    }
}