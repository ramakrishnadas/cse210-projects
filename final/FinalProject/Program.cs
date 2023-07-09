using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        TaskManager taskManager = new TaskManager();

        User user1 = new User("johnsmith", "1234");
        User user2 = new User("jessicagranger", "5678");

        Team myTeam = new Team("myteam", "abcd", "TheBestTeamEver");
        myTeam.AddTeamMember(user1);
        myTeam.AddTeamMember(user2);

        string userChoice = "";

        while (userChoice != "0")
        {
            DisplayMainMenu();
            Console.Write("Please enter your choice: ");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    CreateTask();
                    break;
                case "2":
                    AssignTask();
                    break;
                case "3":
                    FilterTasks();
                    break;
                case "4":
                    SortTasks();
                    break;
                case "5":
                    GenerateReports();
                    break;
                case "6":
                    GetAllTasks();
                    break;
                case "7":
                    TrackUserTasks();
                    break;
                case "8":
                    SendEmailNotification();
                    break;
                case "9":
                    GenerateReport();
                    break;
                case "10":
                    AddTaskToProject();
                    break;
                case "11":
                    RemoveTaskFromProject();
                    break;
                case "12":
                    CreateProject();
                    break;
                case "0":
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }

            Console.WriteLine();
        
    }

    static void DisplayMainMenu()
    {
        Console.WriteLine("==== Task Management System ====");
        Console.WriteLine("1. Create a task");
        Console.WriteLine("2. Assign a task");
        Console.WriteLine("3. Filter tasks");
        Console.WriteLine("4. Sort tasks");
        Console.WriteLine("5. Generate reports");
        Console.WriteLine("6. Get all tasks");
        Console.WriteLine("7. Track user tasks");
        Console.WriteLine("8. Send email notification");
        Console.WriteLine("9. Generate report");
        Console.WriteLine("10. Add task to project");
        Console.WriteLine("11. Remove task from project");
        Console.WriteLine("12. Create Project");
        Console.WriteLine("0. Exit");
    }

    static void CreateTask()
    {
        Console.WriteLine("==== Create Task ====");
        // Prompt the user for task details (name, description, due date, priority)
        // Use taskManager.CreateTask to create the task
        // Display success or failure message
    }

    static void AssignTask()
    {
        Console.WriteLine("==== Assign Task ====");
        // Prompt the user for assignee details (username, team name)
        // Use taskManager.AssignTask to assign the task to the assignee
        // Display success or failure message
    }

    static void FilterTasks()
    {
        Console.WriteLine("==== Filter Tasks ====");
        // Prompt the user for filter criteria (priority, status, assignee)
        // Create a TaskFilterCriteria object with the provided criteria
        // Use taskManager.FilterTasks to get the filtered tasks
        // Display the filtered tasks
    }

    static void SortTasks()
    {
        Console.WriteLine("==== Sort Tasks ====");
        // Prompt the user for the sorting attribute (name, due date, priority, etc.)
        // Use taskManager.SortTasks to sort the tasks based on the attribute
        // Display the sorted tasks
    }

    static void GenerateReports()
    {
        Console.WriteLine("==== Generate Reports ====");
        // Use taskManager.GenerateReports to generate reports
        // Display the generated reports
    }

    static void GetAllTasks()
    {
        Console.WriteLine("==== Get All Tasks ====");
        // Use taskManager.GetAllTasks to get all tasks
        // Display the tasks
    }

    static void TrackUserTasks()
    {
        Console.WriteLine("==== Track User Tasks ====");
        // Prompt the user for their username
        // Find the user by username using taskManager.GetUserByUsername
        // Use user.TrackUserTasks to track the user's tasks
        // Display the user's tasks
    }

    static void SendEmailNotification()
    {
        Console.WriteLine("==== Send Email Notification ====");
        // Prompt the user for recipient email, subject, and body
        // Use the ReminderService class to send the email notification
        // Display success or failure message
    }

    static void GenerateReport()
    {
        Console.WriteLine("==== Generate Report ====");
        // Use the ReportingService class to generate the report
        // Display success or failure message
    }

    static void AddTaskToProject()
    {
        Console.WriteLine("==== Add Task to Project ====");
        // Prompt the user for project details (name, task details)
        // Use the Project class to add the task to the project
        // Display success or failure message
    }

    static void RemoveTaskFromProject()
    {
        Console.WriteLine("==== Remove Task from Project ====");
        // Prompt the user for project details (name, task details)
        // Use the Project class to remove the task from the project
        // Display success or failure message
    }

    static void CreateProject()
    {
        Console.WriteLine("==== CreateProject ====");
        // Prompt the user for username and password
        // Use Project class constructor to Create a New object
        // Display success or failure message
    }

    }
}