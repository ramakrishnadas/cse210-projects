public class ReflectingActivity : Activity
{   
    private string _prompt;

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        StringGenerator prompt = new StringGenerator();
        _prompt = prompt.newPrompt();
    }

    public void Run()
    {
        Start();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n --- {_prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        PauseCountdownTimer();

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            StringGenerator question1 = new StringGenerator();
            string question = question1.newQuestion();
            Console.Write($"\n> {question} ");
            PauseSpinner(8);
        }

        End();
    }
}