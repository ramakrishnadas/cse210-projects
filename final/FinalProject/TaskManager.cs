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
    public List<Task> FilterTasks(TaskFilterCriteria criteria)
    {
        return _tasks;
    }
    public void SortTasks(string attribute)
    {

    }
    public void GenerateReports()
    {

    }
    public List<Task> GetAllTasks()
    {
        return _tasks;
    }

    public void DisplayAllTasks()
    {
        for (int i = 0; i < _tasks.Count; i++)
        {
            Console.Write($"{i}. ");
            _tasks[i].DisplayTask();
        }
    }
}