public class Project
{
    private string _name;
    private string _description;
    private DateTime _startDate;
    private DateTime _endDate;
    private List<Task> _tasks;

    public Project(string name, string description, DateTime startDate, DateTime endDate)
    {
        _name = name;
        _description = description;
        _startDate = startDate;
        _endDate = endDate;
        _tasks = new List<Task>();
    }

    public void AddTask(Task task)
    {
        _tasks.Add(task);
    }
    public void RemoveTask(int taskIndex)
    {
         _tasks.RemoveAt(taskIndex);
    }
    public List<Task> GetTasks()
    {
        return _tasks;
    }
    public string GetName()
    {
        return _name;
    }
}