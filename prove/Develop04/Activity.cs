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

        Console.Clear();
        Console.WriteLine("Get ready...");

        ShowSpinner(6);
        Console.WriteLine();

    }

    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        ShowSpinner(6);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(6);
    }

    public void ShowSpinner(int seconds)
    {
        string[] animation = new string[] {"|", "/", "-", "\\"};
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string c = animation[i];
            Console.Write(c);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count())
            {
                i = 0;
            }
            
        }
            

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b \b \b");
        }
    }
}