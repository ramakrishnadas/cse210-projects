public class Activity
{
    protected string _name; 
    protected string _description; 
    protected int _duration; 
    private string _startMessage;
    private string _endMessage;

    public Activity() 
    {   
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 50;
        _startMessage = "Hello";
        _endMessage = "Goodbye";
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void Start()
    {   
        Console.Clear();
        _startMessage = $"Welcome to the {_name} Activity.\n\n{_description}";
        _endMessage = "\n\nWell Done!!";
        Console.WriteLine(_startMessage);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

        Console.Clear();

        Console.WriteLine("Get ready...");
        PauseSpinner(5);
    }

    public void PauseSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("—");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("—");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void PauseCountdownTimer()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void End()
    {
        Console.WriteLine(_endMessage);
        PauseSpinner(5);
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name} Activity.");
        PauseSpinner(5);
    }
}