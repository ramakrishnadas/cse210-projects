public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {   
        Start();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime) 
        {
            Console.Write("\n\nBreathe in... ");
            PauseCountdownTimer();
            Console.Write("\nNow breathe out... ");
            PauseCountdownTimer();
        }

        End();
    }
}