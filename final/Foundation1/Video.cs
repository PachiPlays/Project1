public class Video
{
    private string _title;
    private string _author;
    private int _length;

    List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetNumberOfComments()
    {
        return comments.Count();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"// Video title: {_title}");
        Console.WriteLine($"Video author: {_author}");
        Console.WriteLine($"This video is {_length} seconds long");

        int numComments = GetNumberOfComments();
        Console.WriteLine($"This video has {numComments} comments.");

        foreach (Comment comment in comments)
        {
            comment.DisplayCommentInfo();
        }
        Console.WriteLine("\\\\");
        Console.WriteLine();

    }
}