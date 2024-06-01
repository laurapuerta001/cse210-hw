public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void CreateComment(string text, string author)
    {
        Comment comment = new Comment(text, author);
        AddComment(comment);
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} by {_author} ({_length} seconds)");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.DisplayComment());
        }
        Console.WriteLine();
    }

}