public class Task
{
    private string _name;
    private string _description;
    private DateTime _dueDate;
    private int _priority;
    private TaskStatus _taskStatus;

    public Task(string name, string description, DateTime dueDate, int priority)
    {
        _name = name;
        _description = description;
        _dueDate = dueDate;
        _priority = priority;
        _taskStatus = TaskStatus.ToDo;  
    }

    public Task(string name, string description, DateTime dueDate, int priority, TaskStatus taskStatus)
    {
        _name = name;
        _description = description;
        _dueDate = dueDate;
        _priority = priority;
        _taskStatus = taskStatus;  
    }

    public string GetName()
    {
        return _name;
    }
    public int GetPriority()
    {
        return _priority;
    }
    public DateTime GetDueDate()
    {
        return _dueDate;
    }
    public void UpdateStatus(TaskStatus newStatus)
    {
        _taskStatus = newStatus;
    }

    public void DisplayTask()
    {
        Console.WriteLine($"Task Name: {_name}, Description: {_description}, Due Date: {_dueDate.ToString("dd/MM/yyyy")}, Priority: {_priority}, Status: {_taskStatus}");
    }

    public string GetStringRepresentation()
    {
        return $"{_name},{_description},{_dueDate.ToString("dd/MM/yyyy")},{_priority},{_taskStatus}";
    }

}