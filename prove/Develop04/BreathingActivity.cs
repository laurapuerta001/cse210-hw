public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartMessage();
        ShowSpinner(_duration);
        ShowCountDown(_duration);
        DisplayEndMessage();
    }
}