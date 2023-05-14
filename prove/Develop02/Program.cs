using System;

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