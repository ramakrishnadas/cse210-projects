using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        TaskManager taskManager = new TaskManager();

        User user1 = new User("John Smith");
        User user2 = new User("Jessica Granger");

        Team myTeam = new Team("My Team", "TheBestTeamEver");
        myTeam.AddTeamMember(user1);
        myTeam.AddTeamMember(user2);

        taskManager.AddUser(user1);
        taskManager.AddUser(user2);
        taskManager.AddTeam(myTeam);
        Console.WriteLine(user1.GetUsername());

        List<Project> myProjects = new List<Project>();

        string userChoice = "";

        while (userChoice != "0")
        {
            DisplayMainMenu();
            Console.Write("Please enter your choice: ");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    CreateTask(taskManager);
                    break;
                case "2":
                    AssignTask(taskManager);
                    break;
                case "3":
                    SortTasks(taskManager);
                    break;
                case "4":
                    UpdateTaskStatus(taskManager);
                    break;
                case "5":
                    DisplayAllTasks(taskManager);
                    break;
                case "6":
                    TrackUserTasks(taskManager);
                    break;
                case "7":
                    SaveCurrentTaskManager(taskManager);
                    break;
                case "8":
                    LoadNewTaskManager(taskManager);
                    break;
                case "9":
                    AddTaskToProject(taskManager, myProjects);
                    break;
                case "10":
                    RemoveTaskFromProject(myProjects);
                    break;
                case "11":
                    CreateProject(myProjects);
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
    }


    static void DisplayMainMenu()
    {
        Console.WriteLine("==== Task Management System ====");
        Console.WriteLine("1. Create a task");
        Console.WriteLine("2. Assign a task");
        Console.WriteLine("3. Sort tasks");
        Console.WriteLine("4. Update task status");
        Console.WriteLine("5. Display all tasks");
        Console.WriteLine("6. Track user tasks");
        Console.WriteLine("7. Save current Task Manager");
        Console.WriteLine("8. Load Task Manager");
        Console.WriteLine("9. Add task to project");
        Console.WriteLine("10. Remove task from project");
        Console.WriteLine("11. Create Project");
        Console.WriteLine("0. Exit");
    }

    static void CreateTask(TaskManager taskManager)
    {
        Console.WriteLine("==== Create Task ====");
        // Prompt the user for task details (name, description, due date, priority)
        // Use taskManager.CreateTask to create the task
        // Display success or failure message
        Console.Write("Please enter the name of the task: ");
        string name = Console.ReadLine();
        Console.Write("Please enter the description of the task: ");
        string description = Console.ReadLine();
        Console.Write("Please enter the due date of this task (format: dd/mm/yyyy): ");
        string dueDateString = Console.ReadLine();
        DateTime dueDate;
        if (DateTime.TryParseExact(dueDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dueDate))
        {
            Console.WriteLine("Due date entered: " + dueDate.ToString("dd/MM/yyyy"));
        }
        else
        {
            Console.WriteLine("Invalid date format.");
        }
        Console.Write("What is the priority level of this task (1 to 3): ");
        int priority =  int.Parse(Console.ReadLine());

        Task newTask = taskManager.CreateTask(name, description, dueDate, priority);
        newTask.DisplayTask();
        Console.WriteLine("Task created successfully!");
    }

    static void AssignTask(TaskManager taskManager)
    {
        Console.WriteLine("==== Assign Task ====");
        // Prompt the user for assignee details (username, team name)
        // Use taskManager.AssignTask to assign the task to the assignee
        // Display success or failure message
        taskManager.DisplayAllTasks();
        Console.Write("Please select a task by entering its index: ");
        int taskIndex = int.Parse(Console.ReadLine()) - 1;
        Task taskToAssign = taskManager.GetTaskByIndex(taskIndex);
        Console.Write("Would you like to assign this task to a TEAM or a USER? ");
        string teamOrUser = Console.ReadLine();
        if (teamOrUser.ToLower() == "user")
        {
            taskManager.DisplayUsers();
            Console.Write("Please select a user by entering its index: ");
            int userIndex = int.Parse(Console.ReadLine()) - 1;
            User user = taskManager.GetUserByIndex(userIndex);
            user.AssignTask(taskToAssign, user);
        } 
        else if (teamOrUser.ToLower() == "team")
        {
            taskManager.DisplayTeams();
            Console.Write("Please select a team by entering its index: ");
            int teamIndex = int.Parse(Console.ReadLine()) - 1;
            Team team = taskManager.GetTeamByIndex(teamIndex);
            team.AssignTask(taskToAssign, team);
        }
        Console.WriteLine("The task was assigned successfully!");
    }

    static void SortTasks(TaskManager taskManager)
    {
        Console.WriteLine("==== Sort Tasks ====");
        // Prompt the user for the sorting attribute (name, due date, priority, etc.)
        // Use taskManager.SortTasks to sort the tasks based on the attribute
        // Display the sorted tasks
        Console.Write("Please select a sorting attribute (name, due date, priority): ");
        string sortingAttribute = Console.ReadLine();

        taskManager.SortTasks(sortingAttribute);
        Console.WriteLine("Tasks were sorted successfully!");
        taskManager.DisplayAllTasks();
    }

    static void UpdateTaskStatus(TaskManager taskManager)
    {
        Console.WriteLine("==== Update Task Status ====");
        taskManager.DisplayAllTasks();
        Console.Write("Please select a task by entering its index: ");
        int taskIndex = int.Parse(Console.ReadLine()) - 1;
        Task taskToUpdate = taskManager.GetTaskByIndex(taskIndex);
        Console.Write("What is the new status?\n    1. ToDo\n    2. InProgress\n    3. Completed\n");
        string newStatus = Console.ReadLine();
        if (newStatus.ToLower() == "1")
        {
            taskToUpdate.UpdateStatus(TaskStatus.ToDo);
        } 
        else if (newStatus.ToLower() == "2")
        {
            taskToUpdate.UpdateStatus(TaskStatus.InProgress);
        }
        else if (newStatus.ToLower() == "3")
        {
            taskToUpdate.UpdateStatus(TaskStatus.Completed);
        }
        
        Console.WriteLine("The task's status was updated successfully!");
    }

    static void DisplayAllTasks(TaskManager taskManager)
    {
        Console.WriteLine("==== Display All Tasks ====");
        taskManager.DisplayAllTasks();
    }

    static void TrackUserTasks(TaskManager taskManager)
    {
        Console.WriteLine("==== Track User Tasks ====");
        // Prompt the user for their username
        // Find the user by username using taskManager.GetUserByUsername
        // Use user.TrackUserTasks to track the user's tasks
        // Display the user's tasks

        Console.Write("Would you like to track the tasks of a TEAM or a USER? ");
        string teamOrUser = Console.ReadLine();
        if (teamOrUser.ToLower() == "user")
        {
            taskManager.DisplayUsers();
            Console.Write("Please select a user by entering its index: ");
            int userIndex = int.Parse(Console.ReadLine()) - 1;
            User user = taskManager.GetUserByIndex(userIndex);
            user.TrackUserTasks();
        } 
        else if (teamOrUser.ToLower() == "team")
        {
            taskManager.DisplayTeams();
            Console.Write("Please select a team by entering its index: ");
            int teamIndex = int.Parse(Console.ReadLine()) - 1;
            Team team = taskManager.GetTeamByIndex(teamIndex);
            team.TrackUserTasks();
        }
    }

    static void SaveCurrentTaskManager(TaskManager taskManager)
    {
        Console.WriteLine("==== Save Current Task Manager ====");
        Console.Write("Please enter a filename (with .txt extension): ");
        string filename = Console.ReadLine();

        SaveTaskManager saveCurrent = new SaveTaskManager(filename, taskManager);
        saveCurrent.Save();
        Console.WriteLine("Your Task Manager was successfully saved!");
    }

    static void LoadNewTaskManager(TaskManager taskManager)
    {
        Console.WriteLine("==== Load Task Manager ====");
        taskManager.ClearTasks();
        Console.Write("Please enter a filename (with .txt extension): ");
        string filename = Console.ReadLine();

        LoadTaskManager loadNew = new LoadTaskManager(filename, taskManager);
        loadNew.Load();
        Console.WriteLine("Your Task Manager was successfully loaded!");
        
    }

    static void AddTaskToProject(TaskManager taskManager, List<Project> myProjects)
    {
        Console.WriteLine("==== Add Task to Project ====");
       
        taskManager.DisplayAllTasks();
        Console.Write("Please select a task by entering its index: ");
        int taskIndex = int.Parse(Console.ReadLine()) - 1;
        Task taskToAdd = taskManager.GetTaskByIndex(taskIndex);
        Console.WriteLine("Please select the project that you would like to modify: ");
        for (int i = 0; i < myProjects.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            Console.WriteLine(myProjects[i].GetName());
        }
        Console.Write("Enter the number of the project: ");
        int projectIndex = int.Parse(Console.ReadLine()) - 1;

        myProjects[projectIndex].AddTask(taskToAdd);

        Console.WriteLine("The task was succesfully added to the project.");

        List<Task> myTasks = myProjects[projectIndex].GetTasks();
        foreach (Task task in myTasks)
        {
            task.DisplayTask();
        }
    }

    static void RemoveTaskFromProject(List<Project> myProjects)
    {
        Console.WriteLine("==== Remove Task from Project ====");
        // Prompt the user for project details (name, task details)
        // Use the Project class to remove the task from the project
        // Display success or failure message
        Console.WriteLine("Please select the project that you would like to modify: ");
        for (int i = 0; i < myProjects.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            Console.WriteLine(myProjects[i].GetName());
        }
        Console.Write("Enter the number of the project: ");
        int projectIndex = int.Parse(Console.ReadLine()) - 1;
        
        List<Task> tasks = myProjects[projectIndex].GetTasks();
        Console.WriteLine("Please select the task you would like to remove: ");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            tasks[i].DisplayTask();
        }
        Console.Write("Enter the number of the task: ");
        int taskIndex = int.Parse(Console.ReadLine()) - 1;
        

        myProjects[projectIndex].RemoveTask(taskIndex);
        Console.WriteLine("The task was successfully removed!");

    }

    static void CreateProject(List<Project> Projects)
    {
        Console.WriteLine("==== Create Project ====");
        Console.Write("Please enter the name of the project: ");
        string name = Console.ReadLine();
        Console.Write("Please enter the description of the project: ");
        string description = Console.ReadLine();
        Console.Write("Please enter the start date of this project (format: dd/mm/yyyy): ");
        string startDateString = Console.ReadLine();
        DateTime startDate;
        if (DateTime.TryParseExact(startDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate))
        {
            Console.WriteLine("Start date entered: " + startDate.ToString("dd/MM/yyyy"));
        }
        else
        {
            Console.WriteLine("Invalid date format.");
        }
        Console.Write("Please enter the end date of this project (format: dd/mm/yyyy): ");
        string endDateString = Console.ReadLine();
        DateTime endDate;
        if (DateTime.TryParseExact(endDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out endDate))
        {
            Console.WriteLine("End date entered: " + endDate.ToString("dd/MM/yyyy"));
        }
        else
        {
            Console.WriteLine("Invalid date format.");
        }

        Project newProject = new Project(name, description, startDate, endDate);

        Projects.Add(newProject);
        Console.WriteLine("The Project was created successfully!");
    }
}
