public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartMessage();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime) 
        {
            Console.WriteLine();
            Console.Write("Breath in...");
            ShowCountDown(5);
            Console.WriteLine();

            Console.Write("Breath out...");
            ShowCountDown(5);
            Console.WriteLine();
        }
        
        DisplayEndMessage();
    }

}