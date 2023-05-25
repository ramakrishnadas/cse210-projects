using System;
// I ecxeeded the core requirements in the Scripture.HideWords() Method. 
// When hiding words, this method will only select words that weren't already hidden. 
// Therefore, every time the user presses enter, three random words will be hidden and replaced with underscores,
// and the program will not try to hide words that are already hidden.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference reference1 = new Reference("Proverbs", 3, 5);
        string verse1 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        Scripture scripture1 = new Scripture(reference1, verse1);

        Reference reference2 = new Reference("Proverbs", 3, 5, 6);
        string verse2 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture2 = new Scripture(reference2, verse2);

        Console.WriteLine("Which scripture would you like to memorize?");
        Console.WriteLine("1. Proverbs 3:5");
        Console.WriteLine("2. Proverbs 3:5-6");
        
        string userSelection = "3";
        while (userSelection != "")
        {   
            Console.Write("Please enter 1 or 2: ");
            userSelection = Console.ReadLine();
            if (userSelection == "1")
            {
                StartProgram(scripture1);
                break;
            }
            else if (userSelection == "2")
            {
                StartProgram(scripture2);
                break;
            }
            else 
            {
                Console.WriteLine("Please enter a valid option (1 or 2).");
            }
        }
        
    }
    static void StartProgram(Scripture scripture)
    {
        Console.WriteLine(scripture.GetRenderedText());

        string userResponse = "";

        while (userResponse == "" && !scripture.IsCompletelyHidden())
        {
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            userResponse = Console.ReadLine();
            scripture.HideWords();
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            
        }
    }
}