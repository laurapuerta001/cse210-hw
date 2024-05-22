public class Activity
{
    protected string _name;

    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration) 
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}! {_description}");
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

    }

    public void DisplayEndMessage()
    {
        Console.Clear();
        Console.WriteLine("Well Done!");
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        string[] animation = new string[] {"|", "/", "-", "\\"};

        _duration = seconds;

        for (int i = 0; i < _duration; i++)
        {
            foreach (string character in animation)
            {
                Console.Write(character);
                Thread.Sleep(_duration);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDown(int seconds)
    {

        _duration = seconds;

        for (int i = _duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(_duration);
            Console.Write("\b \b");
        }


    }
}