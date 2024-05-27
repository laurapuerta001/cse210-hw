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
        DisplayStartMessage();

        string prompt = GetRandomPrompt();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---"); 
        Console.Write("You may begin in...");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> responses = GetListOfPrompts();
        Console.WriteLine($"You listed {responses.Count} items.");

        DisplayEndMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        string prompt = _prompts[promptIndex];

        return prompt;
    }

    public List<string> GetListOfPrompts()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        List<string> responses = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
        }

        return responses;
        

    }
}