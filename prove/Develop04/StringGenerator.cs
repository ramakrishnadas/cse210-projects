public class StringGenerator
{
    private string[] _prompts = {"Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."};

    private string[] _questions = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?",
    "How did you get started?", "How did you feel when it was complete?", 
    "What made this time different than other times when you were not as successful?", 
    "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    private string[] _listPrompts = {"Who are people that you appreciate?", "What are personal strengths of yours?",
    "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};

    public StringGenerator()
    {
    }

    public string newPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Length);
        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }

    public string newQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _questions.Length);
        string randomQuestion = _questions[randomIndex];

        return randomQuestion;
    }

    public string newListPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _listPrompts.Length);
        string randomListPrompt = _listPrompts[randomIndex];

        return randomListPrompt;
    }
}