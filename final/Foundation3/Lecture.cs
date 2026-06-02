public class Lecture : Event
{
    private string _speakerName;
    private int _eventCapacity;

    public Lecture(string title, string desciption, string date, int time, Address address, string speakerName, int eventCapacity)
    : base(title, desciption, date, time, address)
    {
        _speakerName = speakerName;
        _eventCapacity = eventCapacity;
    }

    public override void DisplayFullDetails()
    {
        Console.WriteLine($"This is a lecture given by {_speakerName}");
        base.DisplayFullDetails();
        Console.WriteLine($"This event has a capacity of {_eventCapacity}");

    }

    public override void DisplayShortDescription()
    {
        Console.WriteLine("This is a lecture event");
        base.DisplayShortDescription();
    }
}