public class TaskFilterCriteria
{
    private int _priority;
    private TaskStatus _status;
    private string _assignee;

    public TaskFilterCriteria(int priority, TaskStatus status, string assignee)
    {
        _priority = priority;
        _status = status;
        _assignee = assignee;
    }

    // no methods (behaviors)
}