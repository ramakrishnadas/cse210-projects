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

    public void UpdateStatus(TaskStatus newStatus)
    {
        _taskStatus = newStatus;
    }

    public void TrackProgress()
    {
        Console.WriteLine($"The status of this task is: {_taskStatus}.");
    }

    public void DisplayTask()
    {
        Console.WriteLine($"Task Name: {_name}, Description: {_description}, Due Date: {_dueDate}, Priority: {_priority}, Status: {_taskStatus}");
    }

}