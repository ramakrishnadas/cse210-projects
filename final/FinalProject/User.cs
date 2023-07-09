public class User
{
    private string _username;
    private string _password;
    private List<Task> _tasks;

    public User(string username, string password)
    {
        _username = username;
        _password = password;
        _tasks = new List<Task>();
    }

    public void Authenticate()
    {

    }
    public virtual void AssignTask(Task task, User assignee)
    {
        if (assignee == this)
        {
            // Assign the task to the current user
            _tasks.Add(task);
        }
        else
        {
            // Assign the task to another user
            assignee._tasks.Add(task);
        }
    }
    public void TrackUserTasks()
    {
        for (int i = 0; i < _tasks.Count; i++)
        {
            Console.Write($"{i}. ");
            _tasks[i].DisplayTask();
        }
    }

    public void AddTask(Task task)
    {
        _tasks.Add(task);
    }
}