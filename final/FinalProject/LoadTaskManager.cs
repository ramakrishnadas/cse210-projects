using System.Globalization;
public class LoadTaskManager
{
    private string _filename;
    private TaskManager _taskManager;
    public LoadTaskManager(string filename, TaskManager taskManager)
    {
        _filename = filename;
        _taskManager = taskManager;
    }

    public void Load()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);
        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(",");

            string name = parts[0];
            string description = parts[1];
            DateTime dueDate;
            DateTime.TryParseExact(parts[2], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dueDate);
            int priority = int.Parse(parts[3]);
            string status = parts[4];
            TaskStatus taskStatus = (TaskStatus)Enum.Parse(typeof(TaskStatus), status);

            Task task = new Task(name, description, dueDate, priority, taskStatus);
            _taskManager.AddTask(task);
        }
        
    }

}