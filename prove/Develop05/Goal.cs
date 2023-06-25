public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _completed;
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = false;
    }
    public Goal(string name, string description, int points, bool completed)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = completed;
    }
    public bool IsComplete()
    {
        return _completed;
    }
    public virtual void Display()
    {
        if (_completed)
        {
            Console.WriteLine($"[X] {_name} ({_description})");
        }
        else 
        {
            Console.WriteLine($"[ ] {_name} ({_description})");
        }
    }
    public abstract string GetStringRepresentation();
    public abstract int RecordEvent();
}