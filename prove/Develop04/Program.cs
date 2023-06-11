using System;

class Program
// To exceed the requirements, I added to my program the capacity to keep a log of the activities completed in the current session.
// I also included another option in the menu to display the activity log, which shows the user the number of each activity that they
// completed and displays an encouraging message.
{
    static void Main(string[] args)
    {
        string userResponse = "";
        int breathActivity = 0;
        int reflecActivity = 0;
        int listinActivity = 0;

        while (userResponse != "5")
        {   
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Display activity log\n 5. Quit");
            Console.Write("Select a choice from the menu: ");
            userResponse = Console.ReadLine();

            if (userResponse == "1") 
            {
                BreathingActivity activity1 = new BreathingActivity();
                activity1.Run();
                breathActivity++;
            }
            else if (userResponse == "2")
            {
                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.Run();
                reflecActivity++;
            }
            else if (userResponse == "3")
            {
                ListingActivity activity3 = new ListingActivity();
                activity3.Run();
                listinActivity++;
            }
            else if (userResponse == "4")
            {
                Console.WriteLine($"You have completed {breathActivity} Breathing Activities, {reflecActivity} Reflecting Activities, and {listinActivity} Listing Activities.");
                Console.WriteLine("Congratulations! Remember mindfulness is a very helpful tool for emotional stability.");
            }
        }
    }
}