public class Entry
{
    public string _prompt;
    public string _date;
    public string _response;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"> {_response}");
        Console.WriteLine();
    }

}