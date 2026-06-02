public class Reception : Event
{
    private string _emailForRSVP;

    public Reception(string title, string description, string date, int time, Address address, string emailForRSVP) 
    : base(title, description, date, time, address)
    {
        _emailForRSVP = emailForRSVP;
    }

    public override void DisplayFullDetails()
    {
        Console.WriteLine("This is a reception");
        base.DisplayFullDetails();
        Console.WriteLine($"Attendees must RSVP using the email listed below:");
        Console.WriteLine($"RSVP: {_emailForRSVP}");
    }

    public override void DisplayShortDescription()
    {
        Console.WriteLine("This is a reception");
        base.DisplayShortDescription();
    }
}