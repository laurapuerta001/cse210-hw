public class Video
{
    //Rubric: 1. Abstraction: Video Class - A Video class exists and has a way to track the title, author, and length.
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

    //Rubric: 3. Class Composition - The Video class stores a list of Comment class objects.
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void CreateComment(string text, string author)
    {
        Comment comment = new Comment(text, author);
        AddComment(comment);
    }

    
    //Rubric: 4. Class Behaviors - The Video class contains a method that returns the number of comments directly from the way comments are stored (for example returns the length of the list).
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"{_title} by {_author} ({_length} seconds)");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.DisplayComment());
        }
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine();
    }

}