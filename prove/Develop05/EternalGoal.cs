public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public override int RecordEvent()
    {
        int pointsGained = _points;
        return pointsGained; 
    }
    public override void Display()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name},{_description},{_points}";
    }
}