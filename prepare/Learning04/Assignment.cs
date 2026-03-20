public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        string s = $"{_studentName} - {_topic}";
        return s;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

}