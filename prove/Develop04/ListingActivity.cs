public class ListingActivity : Activity
{
    private int _count;

    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, List<string> prompts, int count) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;

    }

    public void Run()
    {
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        string prompt = _prompts[promptIndex];
        Console.WriteLine(prompt);
    }
}