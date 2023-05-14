public class PromptGenerator
// Responsibility:
// *to generate a random prompt from an array of prompts.
{
    public string[] _prompts = {"What was the happiest moment of your day? ", 
	"What was the worst thing that happened today? ", "What are you grateful for today? ", 
	"What made you feel sad today? ", "What are some good news you heard today? "};

    public PromptGenerator()
    {
    }

    public string New()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Length);
        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }
}