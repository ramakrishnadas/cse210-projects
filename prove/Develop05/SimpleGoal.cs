public class SimpleGoal : Goal
{
    
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public SimpleGoal(string name, string description, int points, bool completed) : base(name, description, points, completed)
    {
    }

    public override int RecordEvent()
    {
        _completed = true;
        int pointsGained = _points;
        return pointsGained; 
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_completed}";
    }
}