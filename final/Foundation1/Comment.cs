public class Comment
{
    private string _text;
    private string _author;

    public Comment(string text, string author)
    {
        _text = text;
        _author = author;
    }

    public string DisplayComment()
    {
        return $"{_author}: {_text}";
    }

}