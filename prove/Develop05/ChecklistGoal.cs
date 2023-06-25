public class ChecklistGoal : Goal
{
    private int _timesNeeded;
    private int _timesCompleted;
    private int _bonusPoints;
    public ChecklistGoal(string name, string description, int points, int timesNeeded, int bonusPoints) : base(name, description, points)
    {
        _timesNeeded = timesNeeded;
        _bonusPoints = bonusPoints;
        _timesCompleted = 0;
    }
    public ChecklistGoal(string name, string description, int points, int timesNeeded, int bonusPoints, int timesCompleted, bool completed) : base(name, description, points)
    {
        _timesNeeded = timesNeeded;
        _bonusPoints = bonusPoints;
        _timesCompleted = timesCompleted;
        _completed = completed;
    }
    public override int RecordEvent()
    {   
        _timesCompleted += 1;
        int pointsGained = _points;
        if (_timesCompleted == _timesNeeded)
        {
            pointsGained += _bonusPoints;
            _completed = true;
        }
        return pointsGained; 
    }
    public override void Display()
    {   
        if (_completed)
        {
            Console.WriteLine($"[X] {_name} ({_description}) -- Currently completed: {_timesCompleted}/{_timesNeeded}");
        }
        else 
        {
            Console.WriteLine($"[ ] {_name} ({_description}) -- Currently completed: {_timesCompleted}/{_timesNeeded}");
        }
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_bonusPoints},{_timesNeeded},{_timesCompleted}";
    }
}