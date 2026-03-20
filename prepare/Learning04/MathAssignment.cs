public class MathAssignment : Assignment
{
    string _textBookSection;
    string _problems;


    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _problems = problems;
        _textBookSection = textBookSection;
    }

    public string GetHomeWorkList()
    {
        string s = $"{_textBookSection}: {_problems}";
        return s;
    }
    
}