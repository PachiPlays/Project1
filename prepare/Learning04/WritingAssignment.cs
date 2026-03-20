public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
        
    }



    public string GetWritingInformation()
    {
        string n = GetStudentName();
        string s = $"{_title} by {n}";
        return s;
    }
}