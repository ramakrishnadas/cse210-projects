using System;
// I added another type of goal (Negative Goal), which is a derived class of the Goal class.
// Whenever a Negative Goal event is registered, the user will lose the set number of points 
// and will receive an encouraging message.
class Program
{
    static void Main(string[] args)
    {
        GoalsLog myGoals = new GoalsLog();

        string userChoice = "";
        while (userChoice != "6")
        {
            Console.WriteLine($"\nYou have {myGoals.GetCurrentScore()} points.");
            Console.WriteLine("\nMenu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1") 
            {
                Console.WriteLine("The types of goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\n  4. Negative Goal");
                Console.Write("Which type of goal would you like to create? ");
                string newGoal = Console.ReadLine();
                if (newGoal == "1")
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int goalPoints = int.Parse(Console.ReadLine());

                    SimpleGoal newSimpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                    myGoals.AddGoal(newSimpleGoal);
                } 
                else if (newGoal == "2")
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int goalPoints = int.Parse(Console.ReadLine());

                    EternalGoal newEternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                    myGoals.AddGoal(newEternalGoal);
                }
                else if (newGoal == "3")
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int goalPoints = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int goalTimesNeeded = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int goalBonusPoints = int.Parse(Console.ReadLine());


                    ChecklistGoal newChecklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTimesNeeded, goalBonusPoints);
                    myGoals.AddGoal(newChecklistGoal);
                }    
                else if (newGoal == "4")
                {
                    Console.Write("What is the name of your negative goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("How many points will you lose if you do this? ");
                    int goalPoints = int.Parse(Console.ReadLine());

                    NegativeGoal newNegativeGoal = new NegativeGoal(goalName, goalDescription, goalPoints);
                    myGoals.AddGoal(newNegativeGoal);
                }
            }
            else if (userChoice == "2")
            {
                Console.WriteLine("The goals are: ");
                myGoals.DisplayList();
            }
            else if (userChoice == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                myGoals.Save(filename);
            }
            else if (userChoice == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                myGoals.Load(filename);
            }
            else if (userChoice == "5")
            {
                Console.WriteLine("The goals are: ");
                myGoals.DisplayList();
                Console.Write("Which goal did you accomplish? ");
                int accomplishedGoal = int.Parse(Console.ReadLine());
                myGoals.RecordEvent(accomplishedGoal - 1);
            }  
        }
    }      
}