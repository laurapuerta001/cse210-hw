public class Comment
{
    //Rubric: 2.Abstraction: Comment Class - A Comment class exists that stores the name of the person and the text of the comment.
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