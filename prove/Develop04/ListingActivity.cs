public class ListingActivity : Activity
{
    private string _listPrompt = "";
    private List<string> _items = new List<string>();

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        StringGenerator listPrompt = new StringGenerator();
        _listPrompt = listPrompt.newListPrompt();
    }

    public void Run()
    {
        Start();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"\n --- {_listPrompt} ---");
        Console.Write("You may begin in: ");
        PauseCountdownTimer();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            _items.Add(item);
        }
        
        Console.WriteLine($"You listed {_items.Count} items!");

        End();
    }
}