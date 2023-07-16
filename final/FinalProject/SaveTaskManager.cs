public class SaveTaskManager
{
    private string _filename;
    private TaskManager _taskManager;

    public SaveTaskManager(string filename, TaskManager taskManager)
    {
        _filename = filename;
        _taskManager = taskManager;
    }

    public void Save()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (Task t in _taskManager.GetAllTasks())
            {
                outputFile.WriteLine(t.GetStringRepresentation());
            }
        }
    }
}