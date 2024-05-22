public class ScriptureGenerator
{
    public List<Scripture> _scriptures = new List<Scripture>();

    public Scripture AutoPromptGenerator()
    {
        Random random = new Random();
        
        int id = random.Next(_scriptures.Count);
        Scripture randomScripture = _scriptures[id];

        return randomScripture;

    }

    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }
}