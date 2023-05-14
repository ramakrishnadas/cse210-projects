using System;
// I exceeded the core requirements in the Load Method of the Journal Class.
// The Load Method creates an Entry object for each entry in the file that the user wishes to load.
// It defines the attributes of each new Entry, including the date, prompt, and answer.
// In this way, the loaded Journal can then be displayed with the option provided in the Menu (option number 2).

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        
        Console.WriteLine("Welcome to the Journal Program!");

        string userResponse = "";
        Journal myJournal = new Journal();

        while (userResponse != "5") 
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");

            userResponse = Console.ReadLine();


            if (userResponse == "1")
            {
                myJournal.Add();

            } else if (userResponse == "2")
            {
                myJournal.DisplayAll();
                
            } else if (userResponse == "3")
            {
                myJournal.Load();

            } else if (userResponse == "4")
            {
                myJournal.Save();
            }
        }


    }
}