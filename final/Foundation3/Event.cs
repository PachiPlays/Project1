

public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private int _time;
    private Address _address;

    public Event(string title, string description, string date, int time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"This event takes place on {_date} at {_time}");
        Console.WriteLine($"This event is located at {_address.GetAddressString()}");

    }

    public virtual void DisplayFullDetails()
    {
        DisplayStandardDetails();

    }

    public virtual void DisplayShortDescription()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"This event takes place on {_date}");
    }
}