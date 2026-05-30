public class Comment
{
    private string _nameOfCommenter;
    private string _commentText;

    public Comment(string nameOfCommenter, string commentText)
    {
        _nameOfCommenter = nameOfCommenter;
        _commentText = commentText;
    }

    public void DisplayCommentInfo()
    {
        string commentinfo = $"{_nameOfCommenter}: {_commentText}";
        Console.WriteLine(commentinfo);
    }
}