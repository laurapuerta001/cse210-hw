public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DisplayStartMessage();

        DisplayPrompt();

        DisplayQuestions();
        
        DisplayEndMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        string prompt = _prompts[promptIndex];

        return prompt;
    }

    public string GetRandomQuestion()
    {
        Random randomQuestion = new Random();
        int questionIndex = randomQuestion.Next(_questions.Count);
        string question = _questions[questionIndex];
    
        return question;
    }

    public void DisplayPrompt(){

        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();

        DateTime dateTime = DateTime.Now;
        DateTime endTime = dateTime.AddSeconds(_duration);

        
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience:");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        while (DateTime.Now < endTime)
        {
            Console.Write(question);
            ShowSpinner(10);
            Console.WriteLine();

            question = GetRandomQuestion();

        }
    }

    

}