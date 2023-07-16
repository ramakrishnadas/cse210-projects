public class TaskManager
{
    private List<Task> _tasks;
    private List<User> _users;
    private List<Team> _teams;

    public TaskManager()
    {
        _tasks = new List<Task>();
        _users = new List<User>();
        _teams = new List<Team>();
    }

    public Task CreateTask (string name, string description, DateTime dueDate, int priority)
    {
        Task task = new Task(name, description, dueDate, priority);
        _tasks.Add(task);
        return task;
    }

    public void SortTasks(string attribute)
    {
        switch (attribute.ToLower())
        {
            case "name":
                _tasks.Sort((t1, t2) => string.Compare(t1.GetName(), t2.GetName()));
                break;
            case "priority":
                _tasks.Sort((t1, t2) => t1.GetPriority().CompareTo(t2.GetPriority()));
                break;
            case "due date":
                _tasks.Sort((t1, t2) => t1.GetDueDate().CompareTo(t2.GetDueDate()));
                break;
            // Add more cases for additional sorting criteria if needed
            default:
                Console.WriteLine("Invalid sorting attribute.");
                break;
        }
    }
    public List<Task> GetAllTasks()
    {
        return _tasks;
    }

    public void DisplayAllTasks()
    {
        for (int i = 0; i < _tasks.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _tasks[i].DisplayTask();
        }
    }
    public void AddTask(Task task)
    {
        _tasks.Add(task);
    }

    public void ClearTasks()
    {
        this._tasks.Clear();
    }

     public void AddUser(User user)
    {
        _users.Add(user);
    }
    public void AddTeam(Team team)
    {
        _teams.Add(team);
    }
    public void DisplayUsers()
    {
        for (int i = 0; i < _users.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            Console.WriteLine(_users[i].GetUsername());
        }
    }
    public void DisplayTeams()
    {
        for (int i = 0; i < _teams.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            Console.WriteLine(_teams[i].GetTeamName());
        }
    }
    public Task GetTaskByIndex(int index)
    {
        return _tasks[index];
    }
    public User GetUserByIndex(int index)
    {
        return _users[index];
    }
    public Team GetTeamByIndex(int index)
    {
        return _teams[index];
    }
}
