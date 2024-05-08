public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string AutoPromptGenerator()
    {
        Random random = new Random();
        
        int id = random.Next(_prompts.Count);
        string randomPrompt = _prompts[id];

        return randomPrompt;

    }
}